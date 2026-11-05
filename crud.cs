using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Computer_Laboratory_Equipment
{
    public partial class crud : Form
    {
        private readonly string startId;
        private EquipmentItem current;

        public crud() : this(null) { }

        public crud(string propertyNo)
        {
            InitializeComponent();
            startId = propertyNo;

            pnlContent.Resize += (s, e) => CenterPanel();
            CenterPanel();

            btnmenu.Click += (s, e) => Close();
            btnEL.Click += (s, e) => Nav.Go(this, new equipmentlist());
            btnreport.Click += (s, e) => Nav.Go(this, new activitylogs());
            btnaintenance.Click += (s, e) => Nav.Go(this, new maintenance());
            btnlogout.Click += (s, e) => Nav.LogOut(this);

            btncancel.Click += (s, e) => Close();
            btnsave.Click += btnsave_Click;
            btnupdate.Click += btnupdate_Click;
            btndelete.Click += btndelete_Click;

            btnAddCategory.Click += btnAddCategory_Click;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            btnAddLab.Click += btnAddLab_Click;
            btnDeleteLab.Click += btnDeleteLab_Click;

            txtId.Leave += (s, e) => LookupId();
            txtId.KeyDown += txtId_KeyDown;

            Theme.Apply(this);
            Theme.Primary(btncancel, Theme.Grey);
        }

        private void CenterPanel()
        {
            panel1.Left = Math.Max(0, (pnlContent.ClientSize.Width - panel1.Width) / 2);
            panel1.Top = Math.Max(0, (pnlContent.ClientSize.Height - panel1.Height) / 2);
        }

        private void crud_Load(object sender, EventArgs e)
        {
            try
            {
                Db.EnsureDefaultCategories();
                FillCategories(null);
                FillLabs();
            }
            catch (Exception ex)
            {
                ShowError("Could not load the dropdown lists.", ex);
            }

            cmbStatus.SelectedIndex = 0;
            SetLoaded(false);

            ActiveControl = txtId;

            if (!string.IsNullOrWhiteSpace(startId))
            {
                txtId.Text = startId;
                LookupId();
            }
        }

        private void FillCategories(int? selectId)
        {
            DataTable categories = Db.GetCategories();

            cmbCategory.DisplayMember = "name";
            cmbCategory.ValueMember = "id";
            cmbCategory.DataSource = categories;

            if (selectId.HasValue)
            {
                cmbCategory.SelectedValue = selectId.Value;
            }
            else
            {
                cmbCategory.SelectedIndex = -1;
            }
        }

        private void FillLabs()
        {
            cmbLaboratory.DataSource = Db.GetLabNames();
            cmbLaboratory.SelectedIndex = -1;
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LookupId();
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (current != null &&
                !string.Equals(txtId.Text.Trim(), current.PropertyNo, StringComparison.OrdinalIgnoreCase))
            {
                SetLoaded(false);
            }
        }

        private void LookupId()
        {
            string id = txtId.Text.Trim();

            if (id.Length == 0)
            {
                return;
            }

            if (current != null && string.Equals(id, current.PropertyNo, StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            try
            {
                EquipmentItem item = Db.GetEquipmentItem(id);

                if (item == null)
                {
                    return;
                }

                current = item;
                txtId.Text = item.PropertyNo;
                txtName.Text = item.Name;
                cmbCategory.SelectedValue = item.CategoryId;
                cmbLaboratory.SelectedIndex = cmbLaboratory.FindStringExact(item.Location);
                txtPc.Text = item.PcNo;
                cmbStatus.SelectedIndex = cmbStatus.FindStringExact(item.Status);
                txtRemarks.Text = item.Remarks;

                SetLoaded(true);
            }
            catch (Exception ex)
            {
                ShowError("Could not load that equipment.", ex);
            }
        }

        private void SetLoaded(bool loaded)
        {
            if (!loaded)
            {
                current = null;
            }

            Theme.SetEnabled(btnsave, !loaded, Theme.Navy);
            Theme.SetEnabled(btnupdate, loaded, Theme.Green);
            Theme.SetEnabled(btndelete, loaded, Theme.Red);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            string id = txtId.Text.Trim();

            try
            {
                if (Db.EquipmentExists(id))
                {
                    MessageBox.Show("Equipment ID \"" + id + "\" already exists. Press Enter in the ID box to load it, then use Update.",
                        "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtId.Focus();
                    return;
                }

                Db.AddEquipment(ReadForm());
                Db.LogActivity(Session.Username, "Added equipment " + id);

                MessageBox.Show("Equipment saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                ShowError("Could not save the equipment.", ex);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (current == null || !ValidateForm())
            {
                return;
            }

            try
            {
                Db.UpdateEquipment(ReadForm());
                Db.LogActivity(Session.Username, "Updated equipment " + current.PropertyNo);

                MessageBox.Show("Equipment updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowError("Could not update the equipment.", ex);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (current == null)
            {
                return;
            }

            string id = current.PropertyNo;

            DialogResult answer = MessageBox.Show(
                "Delete equipment \"" + id + "\"? This cannot be undone.",
                "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (answer != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Db.DeleteEquipment(id);
                Db.LogActivity(Session.Username, "Deleted equipment " + id);

                MessageBox.Show("Equipment deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                ShowError("Could not delete the equipment. It may still have maintenance records.", ex);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = PromptText("Add Category", "New category name:");

            if (name == null)
            {
                return;
            }

            name = name.Trim();

            if (name.Length == 0)
            {
                MessageBox.Show("Please enter a category name.", "Add Category",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Db.CategoryExists(name))
                {
                    MessageBox.Show("That category already exists.", "Add Category",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbCategory.SelectedIndex = cmbCategory.FindStringExact(name);
                    return;
                }

                int newId = Db.AddCategory(name);
                Db.LogActivity(Session.Username, "Added category " + name);

                FillCategories(newId);
            }
            catch (Exception ex)
            {
                ShowError("Could not add the category.", ex);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Select a category to delete first.", "Delete Category",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(cmbCategory.SelectedValue);
            string name = Convert.ToString(cmbCategory.Text);

            try
            {
                int inUse = Db.CountEquipmentInCategory(id);

                if (inUse > 0)
                {
                    MessageBox.Show(
                        "Cannot delete \"" + name + "\": " + inUse + " equipment item(s) still use it.",
                        "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult answer = MessageBox.Show(
                    "Delete category \"" + name + "\"?",
                    "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (answer != DialogResult.Yes)
                {
                    return;
                }

                Db.DeleteCategory(id);
                Db.LogActivity(Session.Username, "Deleted category " + name);

                FillCategories(null);
            }
            catch (Exception ex)
            {
                ShowError("Could not delete the category.", ex);
            }
        }

        private void btnAddLab_Click(object sender, EventArgs e)
        {
            string name = PromptText("Add Laboratory", "New laboratory name:");

            if (name == null)
            {
                return;
            }

            name = name.Trim();

            if (name.Length == 0)
            {
                MessageBox.Show("Please enter a laboratory name.", "Add Laboratory",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Db.LabExists(name))
                {
                    MessageBox.Show("That laboratory already exists.", "Add Laboratory",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbLaboratory.SelectedIndex = cmbLaboratory.FindStringExact(name);
                    return;
                }

                Db.AddLab(name);
                Db.LogActivity(Session.Username, "Added laboratory " + name);

                FillLabs();
                cmbLaboratory.SelectedIndex = cmbLaboratory.FindStringExact(name);
            }
            catch (Exception ex)
            {
                ShowError("Could not add the laboratory.", ex);
            }
        }

        private void btnDeleteLab_Click(object sender, EventArgs e)
        {
            if (cmbLaboratory.SelectedItem == null)
            {
                MessageBox.Show("Select a laboratory to delete first.", "Delete Laboratory",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = Convert.ToString(cmbLaboratory.SelectedItem);

            try
            {
                int inUse = Db.CountEquipmentInLab(name);

                if (inUse > 0)
                {
                    MessageBox.Show(
                        "Cannot delete \"" + name + "\": " + inUse + " equipment item(s) are still there.",
                        "Delete Laboratory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult answer = MessageBox.Show(
                    "Delete laboratory \"" + name + "\"?",
                    "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (answer != DialogResult.Yes)
                {
                    return;
                }

                Db.DeleteLab(name);
                Db.LogActivity(Session.Username, "Deleted laboratory " + name);

                FillLabs();
            }
            catch (Exception ex)
            {
                ShowError("Could not delete the laboratory.", ex);
            }
        }

        private bool ValidateForm()
        {
            if (txtId.Text.Trim().Length == 0)
            {
                return Invalid("Please enter the Equipment ID.", txtId);
            }

            if (txtName.Text.Trim().Length == 0)
            {
                return Invalid("Please enter the Equipment Name.", txtName);
            }

            if (cmbCategory.SelectedValue == null)
            {
                return Invalid("Please select a Category (use + to add a new one).", cmbCategory);
            }

            if (cmbLaboratory.SelectedItem == null)
            {
                return Invalid("Please select a Laboratory.", cmbLaboratory);
            }

            if (cmbStatus.SelectedItem == null)
            {
                return Invalid("Please select a Status.", cmbStatus);
            }

            return true;
        }

        private static bool Invalid(string message, Control focus)
        {
            MessageBox.Show(message, "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            focus.Focus();
            return false;
        }

        private EquipmentItem ReadForm()
        {
            EquipmentItem item = current ?? new EquipmentItem { PropertyNo = txtId.Text.Trim() };

            item.Name = txtName.Text.Trim();
            item.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
            item.Location = Convert.ToString(cmbLaboratory.SelectedItem);
            item.PcNo = txtPc.Text.Trim();
            item.Status = Convert.ToString(cmbStatus.SelectedItem);
            item.Remarks = txtRemarks.Text.Trim();

            return item;
        }

        private void ClearForm()
        {
            txtId.Clear();
            txtName.Clear();
            txtPc.Clear();
            txtRemarks.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbLaboratory.SelectedIndex = -1;
            cmbStatus.SelectedIndex = 0;
            SetLoaded(false);
            txtId.Focus();
        }

        private static void ShowError(string message, Exception ex)
        {
            MessageBox.Show(message + "\n\n" + ex.Message, "Database error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string PromptText(string title, string label)
        {
            using (var dlg = new Form())
            {
                dlg.Text = title;
                dlg.FormBorderStyle = FormBorderStyle.FixedDialog;
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.MinimizeBox = false;
                dlg.MaximizeBox = false;
                dlg.ShowInTaskbar = false;
                dlg.ClientSize = new Size(360, 130);

                var lbl = new Label { Text = label, Left = 15, Top = 15, AutoSize = true };
                var txt = new TextBox { Left = 15, Top = 42, Width = 330 };
                var ok = new Button { Text = "OK", Left = 175, Top = 85, Width = 80, DialogResult = DialogResult.OK };
                var cancel = new Button { Text = "Cancel", Left = 265, Top = 85, Width = 80, DialogResult = DialogResult.Cancel };

                dlg.Controls.Add(lbl);
                dlg.Controls.Add(txt);
                dlg.Controls.Add(ok);
                dlg.Controls.Add(cancel);
                dlg.AcceptButton = ok;
                dlg.CancelButton = cancel;

                return dlg.ShowDialog(this) == DialogResult.OK ? txt.Text : null;
            }
        }
    }
}