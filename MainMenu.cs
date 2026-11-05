
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Computer_Laboratory_Equipment
{
    public partial class MainMenu : Form
    {
        private readonly login loginForm;
        private string username = "";

        public MainMenu()
        {
            InitializeComponent();
            Nav.Menu = this;
            SetupLaboverviewtable();

            btnmenu.Click += (s, e) => LoadCounts();
            btnEL.Click += BtnEL_Click;
            btnreport.Click += BtnReport_Click;
            btnaintenance.Click += BtnMaintenance_Click;
            btncrud.Click += BtnCrud_Click;

            Theme.Apply(this);

            Shown += (s, e) => ActiveControl = null;

            VisibleChanged += (s, e) =>
            {
                if (Visible && username.Length > 0)
                {
                    LoadCounts();
                }
            };
        }

        public MainMenu(login loginForm, string username, string fullName) : this()
        {
            this.loginForm = loginForm;
            this.username = username;
            Session.Username = username;

            string displayName = string.IsNullOrWhiteSpace(fullName)
                ? username
                : fullName;

            labelwelcome.Text = "Welcome, " + displayName + "!";
            labellogin.Text = "Logged In: " + displayName;
            Session.DisplayName = displayName;

            LoadCounts();
        }

        public bool LoggedOut { get; private set; }

        private void SetupLaboverviewtable()
        {
            labovertable.ColumnCount = 5;
            labovertable.ColumnStyles.Clear();

            for (int i = 0; i < 5; i++)
            {
                labovertable.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Percent, 20F)
                );
            }
        }

        private void LoadCounts()
        {
            try
            {
                Dictionary<string, int> counts = Db.GetStatusCounts();

                labeltotalcount.Text = counts["Total"].ToString();
                labelworkingcount.Text = counts["Working"].ToString();
                labelrepaircount.Text = counts["Under Repair"].ToString();
                labelurgentcount.Text = counts["Urgent"].ToString();

                LoadLabOverview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load equipment counts: " + ex.Message,
                    "Database error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void LoadLabOverview()
        {
            DataTable table = Db.GetLabOverview();

            labovertable.SuspendLayout();

            for (int i = labovertable.Controls.Count - 1; i >= 0; i--)
            {
                Control cell = labovertable.Controls[i];

                if (labovertable.GetRow(cell) > 0)
                {
                    labovertable.Controls.RemoveAt(i);
                    cell.Dispose();
                }
            }

            labovertable.RowStyles.Clear();
            labovertable.RowCount = table.Rows.Count + 2;

            labovertable.RowStyles.Add(
                new RowStyle(SizeType.AutoSize)
            );

            for (int row = 0; row < table.Rows.Count; row++)
            {
                labovertable.RowStyles.Add(
                    new RowStyle(SizeType.Absolute, 36F)
                );

                for (int col = 0; col < 5; col++)
                {
                    Label label = new Label
                    {
                        Text = Convert.ToString(table.Rows[row][col]),
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Margin = new Padding(0)
                    };

                    labovertable.Controls.Add(label, col, row + 1);
                }
            }

            labovertable.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F)
            );

            labovertable.ResumeLayout(true);
        }

        private void OpenForm(Form form)
        {
            Nav.Open(form);
            Hide();
        }

        private void BtnEL_Click(object sender, EventArgs e)
        {
            OpenForm(new equipmentlist());
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            OpenForm(new activitylogs());
        }

        private void BtnMaintenance_Click(object sender, EventArgs e)
        {
            OpenForm(new maintenance());
        }

        private void BtnCrud_Click(object sender, EventArgs e)
        {
            OpenForm(new crud());
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            PerformLogout();
        }

        public void PerformLogout()
        {
            Db.LogActivity(username, "Logged out");
            LoggedOut = true;

            if (loginForm != null)
            {
                loginForm.ShowAgain();
            }
            else
            {
                new login().Show();
            }

            Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
        }
    }
}
