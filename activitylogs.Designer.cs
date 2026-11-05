namespace Computer_Laboratory_Equipment
{
    partial class activitylogs
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.btnmenu = new System.Windows.Forms.Button();
            this.btnEL = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnaintenance = new System.Windows.Forms.Button();
            this.btncrud = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.labellogin = new System.Windows.Forms.Label();
            this.labelstatus = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.labeltitle = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.gridLogs = new System.Windows.Forms.DataGridView();
            this.pnlSidebar.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLogs)).BeginInit();
            this.SuspendLayout();
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
            this.pnlSidebar.Size = new System.Drawing.Size(230, 714);
            this.pnlSidebar.TabIndex = 0;
            this.labelProjectName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.labelProjectName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelProjectName.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.labelProjectName.Location = new System.Drawing.Point(15, 12);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(200, 45);
            this.labelProjectName.TabIndex = 0;
            this.labelProjectName.Text = "Computer Laboratory Equipment";
            this.labelProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnmenu.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnmenu.Location = new System.Drawing.Point(15, 70);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(200, 48);
            this.btnmenu.TabIndex = 1;
            this.btnmenu.Text = "Main Menu";
            this.btnmenu.UseVisualStyleBackColor = true;
            this.btnEL.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnEL.Location = new System.Drawing.Point(15, 132);
            this.btnEL.Name = "btnEL";
            this.btnEL.Size = new System.Drawing.Size(200, 48);
            this.btnEL.TabIndex = 2;
            this.btnEL.Text = "Equipment List";
            this.btnEL.UseVisualStyleBackColor = true;
            this.btnreport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnreport.Location = new System.Drawing.Point(15, 194);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(200, 48);
            this.btnreport.TabIndex = 3;
            this.btnreport.Text = "Reports";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnaintenance.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnaintenance.Location = new System.Drawing.Point(15, 256);
            this.btnaintenance.Name = "btnaintenance";
            this.btnaintenance.Size = new System.Drawing.Size(200, 48);
            this.btnaintenance.TabIndex = 4;
            this.btnaintenance.Text = "Maintenance";
            this.btnaintenance.UseVisualStyleBackColor = true;
            this.btncrud.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btncrud.Location = new System.Drawing.Point(15, 318);
            this.btncrud.Name = "btncrud";
            this.btncrud.Size = new System.Drawing.Size(200, 48);
            this.btncrud.TabIndex = 5;
            this.btncrud.Text = "CRUD";
            this.btncrud.UseVisualStyleBackColor = true;
            this.btnlogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnlogout.Location = new System.Drawing.Point(15, 660);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(200, 40);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.pnlFooter.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlFooter.Controls.Add(this.labellogin);
            this.pnlFooter.Controls.Add(this.labelstatus);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1350, 36);
            this.pnlFooter.TabIndex = 2;
            this.labellogin.AutoSize = true;
            this.labellogin.Location = new System.Drawing.Point(21, 8);
            this.labellogin.Name = "labellogin";
            this.labellogin.TabIndex = 0;
            this.labellogin.Text = "Logged In: Admin";
            this.labelstatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.labelstatus.AutoSize = true;
            this.labelstatus.Location = new System.Drawing.Point(1270, 8);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.TabIndex = 1;
            this.labelstatus.Text = "Ready";
            this.pnlContent.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlContent.Controls.Add(this.pnlData);
            this.pnlContent.Controls.Add(this.labeltitle);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.pnlContent.Size = new System.Drawing.Size(1120, 714);
            this.pnlContent.TabIndex = 1;
            this.labeltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeltitle.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.labeltitle.Height = 70;
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.TabIndex = 0;
            this.labeltitle.Text = "Reports";
            this.labeltitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlData.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Name = "pnlData";
            this.pnlData.TabIndex = 1;
            this.pnlData.Controls.Add(this.gridLogs);
            this.gridLogs.AllowUserToAddRows = false;
            this.gridLogs.AllowUserToDeleteRows = false;
            this.gridLogs.AllowUserToResizeRows = false;
            this.gridLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLogs.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.gridLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLogs.MultiSelect = false;
            this.gridLogs.Name = "gridLogs";
            this.gridLogs.ReadOnly = true;
            this.gridLogs.RowHeadersVisible = false;
            this.gridLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLogs.TabIndex = 0;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1350, 750);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlFooter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "activitylogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLogs)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Button btnEL;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnaintenance;
        private System.Windows.Forms.Button btncrud;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView gridLogs;
    }
}