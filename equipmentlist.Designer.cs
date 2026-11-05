
namespace Computer_Laboratory_Equipment
{
    partial class equipmentlist
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
            this.labelshowing = new System.Windows.Forms.Label();
            this.labelselected = new System.Windows.Forms.Label();
            this.labelstatus = new System.Windows.Forms.Label();
            this.labellogin = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.gridEquipment = new System.Windows.Forms.DataGridView();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.flowLabs = new System.Windows.Forms.FlowLayoutPanel();
            this.Laboratories = new System.Windows.Forms.Button();
            this.labelsearch = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.labeltitle = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipment)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.flowLabs.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(230, 714);
            this.pnlSidebar.TabIndex = 0;
            // 
            // labelProjectName
            // 
            this.labelProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProjectName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.labelProjectName.Location = new System.Drawing.Point(15, 12);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(200, 45);
            this.labelProjectName.TabIndex = 0;
            this.labelProjectName.Text = "Computer Laboratory Equipment";
            this.labelProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelProjectName.Click += new System.EventHandler(this.labelProjectName_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmenu.Location = new System.Drawing.Point(15, 70);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(200, 48);
            this.btnmenu.TabIndex = 1;
            this.btnmenu.Text = "Main Menu";
            this.btnmenu.UseVisualStyleBackColor = true;
            // 
            // btnEL
            // 
            this.btnEL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEL.Location = new System.Drawing.Point(15, 132);
            this.btnEL.Name = "btnEL";
            this.btnEL.Size = new System.Drawing.Size(200, 48);
            this.btnEL.TabIndex = 2;
            this.btnEL.Text = "Equipment List";
            this.btnEL.UseVisualStyleBackColor = true;
            // 
            // btnreport
            // 
            this.btnreport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnreport.Location = new System.Drawing.Point(15, 194);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(200, 48);
            this.btnreport.TabIndex = 3;
            this.btnreport.Text = "Reports";
            this.btnreport.UseVisualStyleBackColor = true;
            // 
            // btnaintenance
            // 
            this.btnaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaintenance.Location = new System.Drawing.Point(15, 256);
            this.btnaintenance.Name = "btnaintenance";
            this.btnaintenance.Size = new System.Drawing.Size(200, 48);
            this.btnaintenance.TabIndex = 4;
            this.btnaintenance.Text = "Maintenance";
            this.btnaintenance.UseVisualStyleBackColor = true;
            // 
            // btncrud
            // 
            this.btncrud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btncrud.Location = new System.Drawing.Point(15, 318);
            this.btncrud.Name = "btncrud";
            this.btncrud.Size = new System.Drawing.Size(200, 48);
            this.btncrud.TabIndex = 5;
            this.btncrud.Text = "CRUD";
            this.btncrud.UseVisualStyleBackColor = true;
            // 
            // btnlogout
            // 
            this.btnlogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlogout.Location = new System.Drawing.Point(15, 660);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(200, 40);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = true;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlFooter.Controls.Add(this.labelshowing);
            this.pnlFooter.Controls.Add(this.labelselected);
            this.pnlFooter.Controls.Add(this.labelstatus);
            this.pnlFooter.Controls.Add(this.labellogin);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 714);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1350, 36);
            this.pnlFooter.TabIndex = 2;
            // 
            // labelshowing
            // 
            this.labelshowing.AutoSize = true;
            this.labelshowing.Location = new System.Drawing.Point(21, 8);
            this.labelshowing.Name = "labelshowing";
            this.labelshowing.Size = new System.Drawing.Size(77, 20);
            this.labelshowing.TabIndex = 0;
            this.labelshowing.Text = "Showing:";
            // 
            // labelselected
            // 
            this.labelselected.AutoSize = true;
            this.labelselected.Location = new System.Drawing.Point(380, 8);
            this.labelselected.Name = "labelselected";
            this.labelselected.Size = new System.Drawing.Size(79, 20);
            this.labelselected.TabIndex = 1;
            this.labelselected.Text = "Selected:";
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.Location = new System.Drawing.Point(640, 8);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(56, 20);
            this.labelstatus.TabIndex = 2;
            this.labelstatus.Text = "Ready";
            // 
            // labellogin
            // 
            this.labellogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labellogin.AutoSize = true;
            this.labellogin.Location = new System.Drawing.Point(1170, 8);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(139, 20);
            this.labellogin.TabIndex = 3;
            this.labellogin.Text = "Logged In: Admin";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlContent.Controls.Add(this.pnlData);
            this.pnlContent.Controls.Add(this.pnlFilter);
            this.pnlContent.Controls.Add(this.labeltitle);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(230, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.pnlContent.Size = new System.Drawing.Size(1120, 714);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlData.Controls.Add(this.gridEquipment);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(20, 180);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(1080, 514);
            this.pnlData.TabIndex = 2;
            // 
            // gridEquipment
            // 
            this.gridEquipment.AllowUserToAddRows = false;
            this.gridEquipment.AllowUserToDeleteRows = false;
            this.gridEquipment.AllowUserToResizeRows = false;
            this.gridEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEquipment.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.gridEquipment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEquipment.Location = new System.Drawing.Point(0, 0);
            this.gridEquipment.MultiSelect = false;
            this.gridEquipment.Name = "gridEquipment";
            this.gridEquipment.ReadOnly = true;
            this.gridEquipment.RowHeadersVisible = false;
            this.gridEquipment.RowHeadersWidth = 51;
            this.gridEquipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEquipment.Size = new System.Drawing.Size(1080, 514);
            this.gridEquipment.TabIndex = 0;
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlFilter.Controls.Add(this.flowLabs);
            this.pnlFilter.Controls.Add(this.labelsearch);
            this.pnlFilter.Controls.Add(this.txtsearch);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(20, 80);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1080, 100);
            this.pnlFilter.TabIndex = 1;
            // 
            // flowLabs
            // 
            this.flowLabs.Controls.Add(this.Laboratories);
            this.flowLabs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLabs.Location = new System.Drawing.Point(0, 52);
            this.flowLabs.Name = "flowLabs";
            this.flowLabs.Size = new System.Drawing.Size(1080, 48);
            this.flowLabs.TabIndex = 2;
            // 
            // Laboratories
            // 
            this.Laboratories.Location = new System.Drawing.Point(0, 0);
            this.Laboratories.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Laboratories.Name = "Laboratories";
            this.Laboratories.Size = new System.Drawing.Size(160, 36);
            this.Laboratories.TabIndex = 0;
            this.Laboratories.Text = "All Laboratories";
            this.Laboratories.UseVisualStyleBackColor = true;
            // 
            // labelsearch
            // 
            this.labelsearch.AutoSize = true;
            this.labelsearch.Location = new System.Drawing.Point(2, 12);
            this.labelsearch.Name = "labelsearch";
            this.labelsearch.Size = new System.Drawing.Size(67, 20);
            this.labelsearch.TabIndex = 0;
            this.labelsearch.Text = "Search:";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(75, 8);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(380, 27);
            this.txtsearch.TabIndex = 1;
            // 
            // labeltitle
            // 
            this.labeltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeltitle.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.labeltitle.Location = new System.Drawing.Point(20, 10);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(1080, 70);
            this.labeltitle.TabIndex = 0;
            this.labeltitle.Text = "Equipment List";
            this.labeltitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // equipmentlist
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1350, 750);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlFooter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "equipmentlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipment List";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipment)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.flowLabs.ResumeLayout(false);
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
        private System.Windows.Forms.Label labelshowing;
        private System.Windows.Forms.Label labelselected;
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label labelsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.FlowLayoutPanel flowLabs;
        private System.Windows.Forms.Button Laboratories;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView gridEquipment;
    }
}
