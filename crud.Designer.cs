namespace Computer_Laboratory_Equipment
{
    partial class crud
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.btnmenu = new System.Windows.Forms.Button();
            this.btnEL = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnaintenance = new System.Windows.Forms.Button();
            this.btncrud = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.cmbLaboratory = new System.Windows.Forms.ComboBox();
            this.btnAddLab = new System.Windows.Forms.Button();
            this.btnDeleteLab = new System.Windows.Forms.Button();
            this.txtPc = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.pnlSidebar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.btnAddCategory);
            this.panel1.Controls.Add(this.btnDeleteCategory);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbLaboratory);
            this.panel1.Controls.Add(this.btnAddLab);
            this.panel1.Controls.Add(this.btnDeleteLab);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtPc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtRemarks);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Location = new System.Drawing.Point(240, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 600);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipment ID*";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(190, 40);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(400, 26);
            this.txtId.TabIndex = 1;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Equipment Name*";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(190, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(400, 26);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category*";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(190, 160);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(300, 26);
            this.cmbCategory.TabIndex = 5;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(496, 158);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(34, 30);
            this.btnAddCategory.TabIndex = 6;
            this.btnAddCategory.Text = "+";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Location = new System.Drawing.Point(536, 158);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(34, 30);
            this.btnDeleteCategory.TabIndex = 7;
            this.btnDeleteCategory.Text = "-";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Laboratory*";
            // 
            // cmbLaboratory
            // 
            this.cmbLaboratory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLaboratory.FormattingEnabled = true;
            this.cmbLaboratory.Location = new System.Drawing.Point(190, 220);
            this.cmbLaboratory.Name = "cmbLaboratory";
            this.cmbLaboratory.Size = new System.Drawing.Size(300, 26);
            this.cmbLaboratory.TabIndex = 9;
            // 
            // btnAddLab
            // 
            this.btnAddLab.BackColor = System.Drawing.Color.White;
            this.btnAddLab.Location = new System.Drawing.Point(496, 218);
            this.btnAddLab.Name = "btnAddLab";
            this.btnAddLab.Size = new System.Drawing.Size(34, 30);
            this.btnAddLab.TabIndex = 10;
            this.btnAddLab.Text = "+";
            this.btnAddLab.UseVisualStyleBackColor = false;
            // 
            // btnDeleteLab
            // 
            this.btnDeleteLab.BackColor = System.Drawing.Color.White;
            this.btnDeleteLab.Location = new System.Drawing.Point(536, 218);
            this.btnDeleteLab.Name = "btnDeleteLab";
            this.btnDeleteLab.Size = new System.Drawing.Size(34, 30);
            this.btnDeleteLab.TabIndex = 11;
            this.btnDeleteLab.Text = "-";
            this.btnDeleteLab.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = "PC#";
            // 
            // txtPc
            // 
            this.txtPc.Location = new System.Drawing.Point(190, 280);
            this.txtPc.Name = "txtPc";
            this.txtPc.Size = new System.Drawing.Size(400, 26);
            this.txtPc.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Status*";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Working",
            "Under Repair",
            "Urgent"});
            this.cmbStatus.Location = new System.Drawing.Point(190, 340);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(400, 26);
            this.cmbStatus.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(190, 400);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(400, 90);
            this.txtRemarks.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.label7.Location = new System.Drawing.Point(40, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "*Required Fields";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnupdate.Location = new System.Drawing.Point(57, 535);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(120, 39);
            this.btnupdate.TabIndex = 19;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.Location = new System.Drawing.Point(192, 535);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(120, 39);
            this.btndelete.TabIndex = 20;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.DarkGray;
            this.btnsave.Location = new System.Drawing.Point(327, 535);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(120, 39);
            this.btnsave.TabIndex = 21;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.DarkGray;
            this.btncancel.Location = new System.Drawing.Point(462, 535);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(120, 39);
            this.btncancel.TabIndex = 22;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlSidebar.Controls.Add(this.labelProjectName);
            this.pnlSidebar.Controls.Add(this.btnmenu);
            this.pnlSidebar.Controls.Add(this.btnEL);
            this.pnlSidebar.Controls.Add(this.btnreport);
            this.pnlSidebar.Controls.Add(this.btnaintenance);
            this.pnlSidebar.Controls.Add(this.btncrud);
            this.pnlSidebar.Controls.Add(this.btnlogout);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(230, 750);
            this.pnlSidebar.TabIndex = 0;
            // 
            // labelProjectName
            // 
            this.labelProjectName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.labelProjectName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelProjectName.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.labelProjectName.Location = new System.Drawing.Point(15, 12);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(200, 45);
            this.labelProjectName.TabIndex = 0;
            this.labelProjectName.Text = "Computer Laboratory Equipment";
            this.labelProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnmenu
            // 
            this.btnmenu.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnmenu.Location = new System.Drawing.Point(15, 70);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(200, 48);
            this.btnmenu.TabIndex = 1;
            this.btnmenu.Text = "Main Menu";
            this.btnmenu.UseVisualStyleBackColor = true;
            // 
            // btnEL
            // 
            this.btnEL.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnEL.Location = new System.Drawing.Point(15, 132);
            this.btnEL.Name = "btnEL";
            this.btnEL.Size = new System.Drawing.Size(200, 48);
            this.btnEL.TabIndex = 2;
            this.btnEL.Text = "Equipment List";
            this.btnEL.UseVisualStyleBackColor = true;
            // 
            // btnreport
            // 
            this.btnreport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnreport.Location = new System.Drawing.Point(15, 194);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(200, 48);
            this.btnreport.TabIndex = 3;
            this.btnreport.Text = "Reports";
            this.btnreport.UseVisualStyleBackColor = true;
            // 
            // btnaintenance
            // 
            this.btnaintenance.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnaintenance.Location = new System.Drawing.Point(15, 256);
            this.btnaintenance.Name = "btnaintenance";
            this.btnaintenance.Size = new System.Drawing.Size(200, 48);
            this.btnaintenance.TabIndex = 4;
            this.btnaintenance.Text = "Maintenance";
            this.btnaintenance.UseVisualStyleBackColor = true;
            // 
            // btncrud
            // 
            this.btncrud.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btncrud.Location = new System.Drawing.Point(15, 318);
            this.btncrud.Name = "btncrud";
            this.btncrud.Size = new System.Drawing.Size(200, 48);
            this.btncrud.TabIndex = 5;
            this.btncrud.Text = "CRUD";
            this.btncrud.UseVisualStyleBackColor = true;
            // 
            // btnlogout
            // 
            this.btnlogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnlogout.Location = new System.Drawing.Point(15, 660);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(200, 40);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1120, 750);
            this.pnlContent.TabIndex = 1;
            // 
            // crud
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.MinimumSize = new System.Drawing.Size(1000, 720);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(1350, 750);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "crud";
            this.Text = "Equipment Details";
            this.Load += new System.EventHandler(this.crud_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Button btnEL;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnaintenance;
        private System.Windows.Forms.Button btncrud;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPc;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbLaboratory;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddLab;
        private System.Windows.Forms.Button btnDeleteLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
    }
}