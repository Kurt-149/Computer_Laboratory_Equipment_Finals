
using System;
using System.Windows.Forms;

namespace Computer_Laboratory_Equipment
{
    public partial class maintenance : Form
    {
        public maintenance()
        {
            InitializeComponent();

            btnmenu.Click += (s, e) => Close();
            btnEL.Click += (s, e) => Nav.Go(this, new equipmentlist());
            btnreport.Click += (s, e) => Nav.Go(this, new activitylogs());
            btncrud.Click += (s, e) => Nav.Go(this, new crud());
            btnlogout.Click += (s, e) => Nav.LogOut(this);

            labellogin.Text = "Logged In: " + Session.DisplayName;
            cmbcondition.SelectedIndex = 0;

            btnaddlog.Click += BtnAddLog_Click;

            Theme.Apply(this);
            Theme.Primary(btnaddlog, Theme.Navy);

            ActiveControl = txtasset;

            Load += (s, e) => LoadLogs();
        }

        private void LoadLogs()
        {
            try
            {
                gridLogs.DataSource = Db.GetMaintenanceLogs();
                gridLogs.ClearSelection();

                if (gridLogs.Columns.Contains("Date"))
                {
                    gridLogs.Columns["Date"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
                }
            }
            catch (Exception ex)
            {
                ShowError("Could not load the maintenance logs.", ex);
            }
        }

        private void BtnAddLog_Click(object sender, EventArgs e)
        {
            string assetId = txtasset.Text.Trim();

            if (assetId.Length == 0)
            {
                MessageBox.Show(
                    "Please enter the Asset ID.",
                    "Missing information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtasset.Focus();
                return;
            }

            if (cmbcondition.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a Condition.",
                    "Missing information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbcondition.Focus();
                return;
            }

            string condition = cmbcondition.SelectedItem.ToString();

            string admin = string.IsNullOrWhiteSpace(Session.DisplayName)
                ? Session.Username
                : Session.DisplayName;

            try
            {
                if (!Db.EquipmentExists(assetId))
                {
                    MessageBox.Show(
                        "No equipment with Asset ID \"" + assetId + "\" was found.",
                        "Not found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtasset.Focus();
                    return;
                }

                Db.AddMaintenanceLog(assetId, admin, condition, txtremarks.Text);
                Db.UpdateEquipmentStatus(assetId, condition);
                Db.LogActivity(
                    Session.Username,
                    "Maintenance logged for " + assetId + ": " + condition);

                txtasset.Clear();
                txtremarks.Clear();
                cmbcondition.SelectedIndex = 0;

                labelstatus.Text = "Log added";

                LoadLogs();
            }
            catch (Exception ex)
            {
                ShowError("Could not save the maintenance log.", ex);
            }
        }

        private static void ShowError(string message, Exception ex)
        {
            MessageBox.Show(
                message + "\n\n" + ex.Message,
                "Database error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
