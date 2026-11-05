using System;
using System.Windows.Forms;

namespace Computer_Laboratory_Equipment
{
    public partial class activitylogs : Form
    {
        public activitylogs()
        {
            InitializeComponent();

            btnmenu.Click += (s, e) => Close();
            btnEL.Click += (s, e) => Nav.Go(this, new equipmentlist());
            btnaintenance.Click += (s, e) => Nav.Go(this, new maintenance());
            btncrud.Click += (s, e) => Nav.Go(this, new crud());
            btnlogout.Click += (s, e) => Nav.LogOut(this);

            labellogin.Text = "Logged In: " + Session.DisplayName;
            Theme.Apply(this);
            Load += (s, e) => LoadLogs();
        }

        private void LoadLogs()
        {
            try
            {
                gridLogs.DataSource = Db.GetActivityLogs();
                gridLogs.ClearSelection();

                if (gridLogs.Columns.Contains("Date"))
                {
                    gridLogs.Columns["Date"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
                }

                labelstatus.Text = "Ready";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load the activity logs.\n\n" + ex.Message, "Database error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}