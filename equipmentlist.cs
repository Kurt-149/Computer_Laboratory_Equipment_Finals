
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Computer_Laboratory_Equipment
{
    public partial class equipmentlist : Form
    {
        private string selectedLab = "";

        public equipmentlist()
        {
            InitializeComponent();

            btnmenu.Click += (s, e) => Close();

            btnreport.Click += (s, e) =>
                Nav.Go(this, new activitylogs());

            btnaintenance.Click += (s, e) =>
                Nav.Go(this, new maintenance());

            btncrud.Click += (s, e) =>
                Nav.Go(this, new crud());

            btnlogout.Click += (s, e) =>
                Nav.LogOut(this);

            labellogin.Text = "Logged In: " + Session.DisplayName;
            labelstatus.Text = "Double-click a row to edit it";

            Laboratories.Click += (s, e) => FilterLab("");

            txtsearch.TextChanged += (s, e) => LoadEquipment();

            gridEquipment.SelectionChanged += (s, e) =>
                UpdateSelected();

            gridEquipment.CellDoubleClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    OpenSelected();
                }
            };

            Theme.Apply(this);

            Load += (s, e) =>
            {
                BuildLabButtons();
                LoadEquipment();
            };
        }

        private void BuildLabButtons()
        {
            try
            {
                for (int i = flowLabs.Controls.Count - 1; i >= 0; i--)
                {
                    Control control = flowLabs.Controls[i];

                    if (control is Button button &&
                        button != Laboratories)
                    {
                        flowLabs.Controls.Remove(control);
                        control.Dispose();
                    }
                }

                foreach (string lab in Db.GetLabNames())
                {
                    string labName = lab;

                    Button button = new Button
                    {
                        Text = labName,
                        Size = new Size(140, 36),
                        Margin = new Padding(0, 0, 10, 0),
                        UseVisualStyleBackColor = false,
                        FlatStyle = FlatStyle.Flat,
                        FlatAppearance =
                        {
                            BorderSize = 1
                        }
                    };

                    button.Click += (s, e) =>
                        FilterLab(labName);

                    flowLabs.Controls.Add(button);
                }

                Theme.ApplyChildren(flowLabs);
                HighlightLab();
            }
            catch (Exception ex)
            {
                ShowError("Could not load the laboratories.", ex);
            }
        }

        private void FilterLab(string labName)
        {
            selectedLab = labName;

            HighlightLab();
            LoadEquipment();
        }

        private void HighlightLab()
        {
            foreach (Control control in flowLabs.Controls)
            {
                if (control is Button button)
                {
                    bool active = button == Laboratories
                        ? selectedLab.Length == 0
                        : button.Text == selectedLab;

                    button.BackColor = active
                        ? Theme.Navy
                        : Color.White;

                    button.ForeColor = active
                        ? Color.White
                        : Color.Black;
                }
            }
        }

        private void LoadEquipment()
        {
            try
            {
                DataTable table = Db.GetEquipmentList(
                    txtsearch.Text.Trim(),
                    selectedLab
                );

                gridEquipment.DataSource = table;

                labelshowing.Text =
                    "Showing: " + table.Rows.Count + " item(s)" +
                    (selectedLab.Length > 0
                        ? " in " + selectedLab
                        : "");

                UpdateSelected();

                labelstatus.Text = "Equipment list loaded";
            }
            catch (Exception ex)
            {
                ShowError("Could not load the equipment list.", ex);
                labelstatus.Text = "Error loading equipment";
            }
        }

        private string SelectedId()
        {
            if (gridEquipment.CurrentRow == null)
            {
                return null;
            }

            if (!gridEquipment.Columns.Contains("Asset ID"))
            {
                return null;
            }

            object value =
                gridEquipment.CurrentRow.Cells["Asset ID"].Value;

            return Convert.ToString(value);
        }

        private void UpdateSelected()
        {
            string id = SelectedId();

            labelselected.Text =
                "Selected: " +
                (string.IsNullOrEmpty(id) ? "none" : id);
        }

        private void OpenSelected()
        {
            string id = SelectedId();

            if (!string.IsNullOrEmpty(id))
            {
                Nav.Go(this, new crud(id));
            }
        }

        private static void ShowError(string message, Exception ex)
        {
            MessageBox.Show(
                message + "\n\n" + ex.Message,
                "Database error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        private void labelProjectName_Click(object sender, EventArgs e)
        {

        }
    }
}
