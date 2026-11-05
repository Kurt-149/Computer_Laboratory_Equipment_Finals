using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Computer_Laboratory_Equipment
{
    internal static class Db
    {
        private static string ConnectionString =
            @"Server=(localdb)\MSSQLLocalDB;
              Database=lab_equipment_db;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public static bool ValidateUser(string username, string password, out string fullName, out string role)
        {
            fullName = "";
            role = "";

            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(
                "SELECT full_name, role, password_hash FROM users WHERE username = @u", conn))
            {
                cmd.Parameters.AddWithValue("@u", username);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        return false;
                    }

                    if (!string.Equals(reader.GetString(2), Hash(password), StringComparison.OrdinalIgnoreCase))
                    {
                        return false;
                    }

                    fullName = reader.IsDBNull(0) ? username : reader.GetString(0);
                    role = reader.GetString(1);
                    return true;
                }
            }
        }

        public static void LogActivity(string username, string activity)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(
                "INSERT INTO activity_logs (username, activity) VALUES (@u, @a)", conn))
            {
                cmd.Parameters.AddWithValue("@u", username ?? "");
                cmd.Parameters.AddWithValue("@a", activity);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static List<string> GetLabNames()
        {
            var labs = new List<string>();

            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("SELECT lab_name FROM labs ORDER BY id", conn))
            {
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        labs.Add(reader.GetString(0));
                    }
                }
            }

            return labs;
        }

        public static bool LabExists(string name)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM labs WHERE lab_name = @n", conn))
            {
                cmd.Parameters.AddWithValue("@n", name);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public static int AddLab(string name)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(
                "INSERT INTO labs (lab_name) OUTPUT INSERTED.id VALUES (@n)", conn))
            {
                cmd.Parameters.AddWithValue("@n", name);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static int CountEquipmentInLab(string labName)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM equipment WHERE location = @n", conn))
            {
                cmd.Parameters.AddWithValue("@n", labName);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static void DeleteLab(string name)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("DELETE FROM labs WHERE lab_name = @n", conn))
            {
                cmd.Parameters.AddWithValue("@n", name);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetCategories()
        {
            var table = new DataTable();

            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("SELECT id, name FROM categories ORDER BY id", conn))
            using (var adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(table);
            }

            return table;
        }

        public static List<string> GetCategoryNames()
        {
            var names = new List<string>();

            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("SELECT name FROM categories ORDER BY id", conn))
            {
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        names.Add(reader.GetString(0));
                    }
                }
            }

            return names;
        }

        public static int GetCategoryId(string name)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("SELECT id FROM categories WHERE name = @n", conn))
            {
                cmd.Parameters.AddWithValue("@n", name);
                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                {
                    throw new InvalidOperationException("Unknown category: " + name);
                }

                return Convert.ToInt32(result);
            }
        }

        public static bool CategoryExists(string name)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM categories WHERE name = @n", conn))
            {
                cmd.Parameters.AddWithValue("@n", name);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public static int AddCategory(string name)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(
                "INSERT INTO categories (name) OUTPUT INSERTED.id VALUES (@n)", conn))
            {
                cmd.Parameters.AddWithValue("@n", name);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static int CountEquipmentInCategory(int categoryId)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM equipment WHERE category_id = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", categoryId);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static void DeleteCategory(int categoryId)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("DELETE FROM categories WHERE id = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", categoryId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void EnsureDefaultCategories()
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(
                @"IF NOT EXISTS (SELECT 1 FROM categories)
                  INSERT INTO categories (name) VALUES ('Category 1'), ('Category 2'), ('Category 3')", conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetEquipmentList(string search, string laboratory)
        {
            const string sql = @"
                SELECT
                    e.property_no AS [Asset ID],
                    e.name AS [Equipment Name],
                    COALESCE(c.name, CAST(e.category_id AS VARCHAR(20))) AS [Category],
                    e.location AS [Laboratory],
                    e.status AS [Status]
                FROM equipment e
                LEFT JOIN categories c ON c.id = e.category_id
                WHERE
                    (@search = '' OR e.name LIKE @like OR e.property_no LIKE @like OR c.name LIKE @like)
                    AND (@lab = '' OR e.location = @lab)
                ORDER BY e.property_no";

            var table = new DataTable();
            string term = search ?? "";

            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@search", term);
                cmd.Parameters.AddWithValue("@like", "%" + term + "%");
                cmd.Parameters.AddWithValue("@lab", laboratory ?? "");

                using (var adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }

        public static EquipmentItem GetEquipmentItem(string propertyNo)
        {
            const string sql = @"
                SELECT property_no, name, brand, model, serial_no, date_acquired,
                       category_id, status, location, remarks, pc_no
                FROM equipment
                WHERE property_no = @pn";

            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@pn", propertyNo);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        return null;
                    }

                    return new EquipmentItem
                    {
                        PropertyNo = reader.GetString(0),
                        Name = reader.GetString(1),
                        Brand = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        Model = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        SerialNo = reader.IsDBNull(4) ? "" : reader.GetString(4),
                        DateAcquired = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5),
                        CategoryId = reader.GetInt32(6),
                        Status = reader.GetString(7),
                        Location = reader.IsDBNull(8) ? "" : reader.GetString(8),
                        Remarks = reader.IsDBNull(9) ? "" : reader.GetString(9),
                        PcNo = reader.IsDBNull(10) ? "" : reader.GetString(10)
                    };
                }
            }
        }

        public static bool EquipmentExists(string propertyNo)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM equipment WHERE property_no = @pn", conn))
            {
                cmd.Parameters.AddWithValue("@pn", propertyNo);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public static void AddEquipment(EquipmentItem item)
        {
            const string sql = @"
                INSERT INTO equipment
                (property_no, name, brand, model, serial_no, date_acquired, category_id, status, location, remarks, pc_no)
                VALUES
                (@pn, @name, @brand, @model, @serial, @date, @cat, @status, @location, @remarks, @pc)";

            Execute(sql, item);
        }

        public static void UpdateEquipment(EquipmentItem item)
        {
            const string sql = @"
                UPDATE equipment
                SET name = @name, brand = @brand, model = @model, serial_no = @serial,
                    date_acquired = @date, category_id = @cat, status = @status,
                    location = @location, remarks = @remarks, pc_no = @pc
                WHERE property_no = @pn";

            Execute(sql, item);
        }

        public static void UpdateEquipmentStatus(string propertyNo, string status)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("UPDATE equipment SET status = @s WHERE property_no = @pn", conn))
            {
                cmd.Parameters.AddWithValue("@s", status);
                cmd.Parameters.AddWithValue("@pn", propertyNo);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteEquipment(string propertyNo)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("DELETE FROM equipment WHERE property_no = @pn", conn))
            {
                cmd.Parameters.AddWithValue("@pn", propertyNo);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static Dictionary<string, int> GetStatusCounts()
        {
            var counts = new Dictionary<string, int>
            {
                { "Total", 0 },
                { "Working", 0 },
                { "Under Repair", 0 },
                { "Urgent", 0 }
            };

            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("SELECT status, COUNT(*) FROM equipment GROUP BY status", conn))
            {
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string status = reader.GetString(0);
                        int count = Convert.ToInt32(reader.GetValue(1));

                        counts["Total"] += count;

                        if (counts.ContainsKey(status))
                        {
                            counts[status] = count;
                        }
                    }
                }
            }

            return counts;
        }

        public static DataTable GetLabOverview()
        {
            const string sql = @"
                SELECT
                    l.lab_name AS [Laboratory],
                    COUNT(e.property_no) AS [Total],
                    COALESCE(SUM(CASE WHEN e.status = 'Working' THEN 1 ELSE 0 END), 0) AS [Working],
                    COALESCE(SUM(CASE WHEN e.status = 'Under Repair' THEN 1 ELSE 0 END), 0) AS [Under Repair],
                    COALESCE(SUM(CASE WHEN e.status = 'Urgent' THEN 1 ELSE 0 END), 0) AS [Urgent]
                FROM labs l
                LEFT JOIN equipment e ON e.location = l.lab_name
                GROUP BY l.id, l.lab_name
                ORDER BY l.id";

            var table = new DataTable();

            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(sql, conn))
            using (var adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(table);
            }

            return table;
        }

        public static void AddMaintenanceLog(string propertyNo, string adminName, string conditionStatus, string remarks)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(
                @"INSERT INTO maintenance_logs (property_no, condition_status, remarks, admin_name)
                  VALUES (@pn, @cond, @remarks, @admin)", conn))
            {
                cmd.Parameters.AddWithValue("@pn", propertyNo);
                cmd.Parameters.AddWithValue("@cond", conditionStatus);
                cmd.Parameters.AddWithValue("@remarks", NullIfEmpty(remarks));
                cmd.Parameters.AddWithValue("@admin", adminName);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetMaintenanceLogs()
        {
            const string sql = @"
                WITH latest AS (
                    SELECT
                        property_no,
                        condition_status,
                        remarks,
                        admin_name,
                        logged_at,
                        ROW_NUMBER() OVER (PARTITION BY property_no ORDER BY logged_at DESC) AS rn
                    FROM maintenance_logs
                )
                SELECT
                    logged_at AS [Date],
                    property_no AS [Asset ID],
                    admin_name AS [Admin],
                    condition_status AS [Condition],
                    remarks AS [Remarks]
                FROM latest
                WHERE rn = 1
                ORDER BY logged_at DESC";

            var table = new DataTable();

            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(sql, conn))
            using (var adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(table);
            }

            return table;
        }

        public static DataTable GetActivityLogs()
        {
            const string sql = @"
                SELECT
                    logged_at AS [Date],
                    username AS [User],
                    activity AS [Activity]
                FROM activity_logs
                ORDER BY logged_at DESC";

            var table = new DataTable();

            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(sql, conn))
            using (var adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(table);
            }

            return table;
        }

        public static string Hash(string text)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(text));
                var sb = new StringBuilder();

                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }

        private static void Execute(string sql, EquipmentItem item)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@pn", item.PropertyNo);
                cmd.Parameters.AddWithValue("@name", item.Name);
                cmd.Parameters.AddWithValue("@brand", NullIfEmpty(item.Brand));
                cmd.Parameters.AddWithValue("@model", NullIfEmpty(item.Model));
                cmd.Parameters.AddWithValue("@serial", NullIfEmpty(item.SerialNo));
                cmd.Parameters.AddWithValue("@date",
                    item.DateAcquired.HasValue ? (object)item.DateAcquired.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@cat", item.CategoryId);
                cmd.Parameters.AddWithValue("@status", item.Status);
                cmd.Parameters.AddWithValue("@location", NullIfEmpty(item.Location));
                cmd.Parameters.AddWithValue("@remarks", NullIfEmpty(item.Remarks));
                cmd.Parameters.AddWithValue("@pc", NullIfEmpty(item.PcNo));
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private static object NullIfEmpty(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? (object)DBNull.Value : value.Trim();
        }
    }

    public class EquipmentItem
    {
        public string PropertyNo { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNo { get; set; }
        public DateTime? DateAcquired { get; set; }
        public int CategoryId { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public string Remarks { get; set; }
        public string PcNo { get; set; }
    }
}