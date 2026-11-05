
namespace Computer_Laboratory_Equipment
{
    partial class MainMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.headerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.labelwelcome = new System.Windows.Forms.Label();
            this.statsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.total = new System.Windows.Forms.Panel();
            this.labeltotalcount = new System.Windows.Forms.Label();
            this.labelequipment = new System.Windows.Forms.Label();
            this.working = new System.Windows.Forms.Panel();
            this.labelworkingcount = new System.Windows.Forms.Label();
            this.labelworking = new System.Windows.Forms.Label();
            this.forrepair = new System.Windows.Forms.Panel();
            this.labelrepaircount = new System.Windows.Forms.Label();
            this.labelforrepain = new System.Windows.Forms.Label();
            this.urgent = new System.Windows.Forms.Panel();
            this.labelurgentcount = new System.Windows.Forms.Label();
            this.labelurgent = new System.Windows.Forms.Label();
            this.labellaboverview = new System.Windows.Forms.Label();
            this.labovertable = new System.Windows.Forms.TableLayoutPanel();
            this.overcomlab = new System.Windows.Forms.Label();
            this.overtotalequip = new System.Windows.Forms.Label();
            this.overtotalworking = new System.Windows.Forms.Label();
            this.overtotalrepair = new System.Windows.Forms.Label();
            this.overtotalurgent = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.labellogin = new System.Windows.Forms.Label();

            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.headerLayout.SuspendLayout();
            this.statsLayout.SuspendLayout();
            this.total.SuspendLayout();
            this.working.SuspendLayout();
            this.forrepair.SuspendLayout();
            this.urgent.SuspendLayout();
            this.labovertable.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            this.pnlSidebar.Anchor = System.Windows.Forms.AnchorStyles.Top |
                                     System.Windows.Forms.AnchorStyles.Bottom |
                                     System.Windows.Forms.AnchorStyles.Left;
            this.pnlSidebar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlSidebar.Controls.Add(this.labelProjectName);
            this.pnlSidebar.Controls.Add(this.btnmenu);
            this.pnlSidebar.Controls.Add(this.btnEL);
            this.pnlSidebar.Controls.Add(this.btnreport);
            this.pnlSidebar.Controls.Add(this.btnaintenance);
            this.pnlSidebar.Controls.Add(this.btncrud);
            this.pnlSidebar.Controls.Add(this.btnlogout);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(230, 714);
            this.pnlSidebar.TabIndex = 0;

            this.labelProjectName.Anchor = System.Windows.Forms.AnchorStyles.Top |
                                           System.Windows.Forms.AnchorStyles.Left |
                                           System.Windows.Forms.AnchorStyles.Right;
            this.labelProjectName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelProjectName.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.labelProjectName.Location = new System.Drawing.Point(15, 12);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(200, 45);
            this.labelProjectName.TabIndex = 0;
            this.labelProjectName.Text = "Computer Laboratory Equipment";
            this.labelProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnmenu.Anchor = System.Windows.Forms.AnchorStyles.Top |
                                  System.Windows.Forms.AnchorStyles.Left |
                                  System.Windows.Forms.AnchorStyles.Right;
            this.btnmenu.Location = new System.Drawing.Point(15, 70);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(200, 48);
            this.btnmenu.TabIndex = 1;
            this.btnmenu.Text = "Main Menu";
            this.btnmenu.UseVisualStyleBackColor = true;

            this.btnEL.Anchor = System.Windows.Forms.AnchorStyles.Top |
                                System.Windows.Forms.AnchorStyles.Left |
                                System.Windows.Forms.AnchorStyles.Right;
            this.btnEL.Location = new System.Drawing.Point(15, 132);
            this.btnEL.Name = "btnEL";
            this.btnEL.Size = new System.Drawing.Size(200, 48);
            this.btnEL.TabIndex = 2;
            this.btnEL.Text = "Equipment List";
            this.btnEL.UseVisualStyleBackColor = true;

            this.btnreport.Anchor = System.Windows.Forms.AnchorStyles.Top |
                                    System.Windows.Forms.AnchorStyles.Left |
                                    System.Windows.Forms.AnchorStyles.Right;
            this.btnreport.Location = new System.Drawing.Point(15, 194);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(200, 48);
            this.btnreport.TabIndex = 3;
            this.btnreport.Text = "Reports";
            this.btnreport.UseVisualStyleBackColor = true;

            this.btnaintenance.Anchor = System.Windows.Forms.AnchorStyles.Top |
                                        System.Windows.Forms.AnchorStyles.Left |
                                        System.Windows.Forms.AnchorStyles.Right;
            this.btnaintenance.Location = new System.Drawing.Point(15, 256);
            this.btnaintenance.Name = "btnaintenance";
            this.btnaintenance.Size = new System.Drawing.Size(200, 48);
            this.btnaintenance.TabIndex = 4;
            this.btnaintenance.Text = "Maintenance";
            this.btnaintenance.UseVisualStyleBackColor = true;

            this.btncrud.Anchor = System.Windows.Forms.AnchorStyles.Top |
                                  System.Windows.Forms.AnchorStyles.Left |
                                  System.Windows.Forms.AnchorStyles.Right;
            this.btncrud.Location = new System.Drawing.Point(15, 318);
            this.btncrud.Name = "btncrud";
            this.btncrud.Size = new System.Drawing.Size(200, 48);
            this.btncrud.TabIndex = 5;
            this.btncrud.Text = "CRUD";
            this.btncrud.UseVisualStyleBackColor = true;

            this.btnlogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom |
                                    System.Windows.Forms.AnchorStyles.Left |
                                    System.Windows.Forms.AnchorStyles.Right;
            this.btnlogout.Location = new System.Drawing.Point(15, 660);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(200, 40);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.BtnLogout_Click);

            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top |
                                    System.Windows.Forms.AnchorStyles.Bottom |
                                    System.Windows.Forms.AnchorStyles.Left |
                                    System.Windows.Forms.AnchorStyles.Right;
            this.pnlHeader.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlHeader.Controls.Add(this.headerLayout);
            this.pnlHeader.Location = new System.Drawing.Point(230, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1120, 714);
            this.pnlHeader.TabIndex = 1;

            this.headerLayout.ColumnCount = 1;
            this.headerLayout.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent, 100F
                )
            );
            this.headerLayout.Controls.Add(this.labelwelcome, 0, 0);
            this.headerLayout.Controls.Add(this.statsLayout, 0, 1);
            this.headerLayout.Controls.Add(this.labellaboverview, 0, 2);
            this.headerLayout.Controls.Add(this.labovertable, 0, 3);
            this.headerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLayout.Location = new System.Drawing.Point(0, 0);
            this.headerLayout.Name = "headerLayout";
            this.headerLayout.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.headerLayout.RowCount = 4;
            this.headerLayout.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.AutoSize
                )
            );
            this.headerLayout.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Absolute, 150F
                )
            );
            this.headerLayout.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.AutoSize
                )
            );
            this.headerLayout.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent, 100F
                )
            );
            this.headerLayout.Size = new System.Drawing.Size(1120, 714);
            this.headerLayout.TabIndex = 0;

            this.labelwelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelwelcome.Font = new System.Drawing.Font("Arial", 27.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwelcome.Name = "labelwelcome";
            this.labelwelcome.Size = new System.Drawing.Size(1080, 70);
            this.labelwelcome.TabIndex = 0;
            this.labelwelcome.Text = "Welcome, Admin!";
            this.labelwelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.statsLayout.BackColor = System.Drawing.Color.AliceBlue;
            this.statsLayout.ColumnCount = 4;
            this.statsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.statsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.statsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.statsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.statsLayout.Controls.Add(this.total, 0, 0);
            this.statsLayout.Controls.Add(this.working, 1, 0);
            this.statsLayout.Controls.Add(this.forrepair, 2, 0);
            this.statsLayout.Controls.Add(this.urgent, 3, 0);
            this.statsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statsLayout.Location = new System.Drawing.Point(20, 90);
            this.statsLayout.Name = "statsLayout";
            this.statsLayout.RowCount = 1;
            this.statsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.statsLayout.Size = new System.Drawing.Size(1080, 150);
            this.statsLayout.TabIndex = 1;

            this.total.BackColor = System.Drawing.Color.LightSteelBlue;
            this.total.Controls.Add(this.labeltotalcount);
            this.total.Controls.Add(this.labelequipment);
            this.total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.total.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.total.Name = "total";
            this.total.TabIndex = 0;

            this.labeltotalcount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labeltotalcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.labeltotalcount.Name = "labeltotalcount";
            this.labeltotalcount.TabIndex = 0;
            this.labeltotalcount.Text = "0";
            this.labeltotalcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.labelequipment.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelequipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelequipment.Height = 40;
            this.labelequipment.Name = "labelequipment";
            this.labelequipment.TabIndex = 1;
            this.labelequipment.Text = "Total Equipment";
            this.labelequipment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.working.BackColor = System.Drawing.Color.LightSteelBlue;
            this.working.Controls.Add(this.labelworkingcount);
            this.working.Controls.Add(this.labelworking);
            this.working.Dock = System.Windows.Forms.DockStyle.Fill;
            this.working.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.working.Name = "working";
            this.working.TabIndex = 1;

            this.labelworkingcount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelworkingcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.labelworkingcount.Name = "labelworkingcount";
            this.labelworkingcount.TabIndex = 0;
            this.labelworkingcount.Text = "0";
            this.labelworkingcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.labelworking.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelworking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelworking.Height = 40;
            this.labelworking.Name = "labelworking";
            this.labelworking.TabIndex = 1;
            this.labelworking.Text = "Working";
            this.labelworking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.forrepair.BackColor = System.Drawing.Color.LightSteelBlue;
            this.forrepair.Controls.Add(this.labelrepaircount);
            this.forrepair.Controls.Add(this.labelforrepain);
            this.forrepair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forrepair.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.forrepair.Name = "forrepair";
            this.forrepair.TabIndex = 2;

            this.labelrepaircount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelrepaircount.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.labelrepaircount.Name = "labelrepaircount";
            this.labelrepaircount.TabIndex = 0;
            this.labelrepaircount.Text = "0";
            this.labelrepaircount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.labelforrepain.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelforrepain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelforrepain.Height = 40;
            this.labelforrepain.Name = "labelforrepain";
            this.labelforrepain.TabIndex = 1;
            this.labelforrepain.Text = "Under Repair";
            this.labelforrepain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.urgent.BackColor = System.Drawing.Color.LightSteelBlue;
            this.urgent.Controls.Add(this.labelurgentcount);
            this.urgent.Controls.Add(this.labelurgent);
            this.urgent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urgent.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.urgent.Name = "urgent";
            this.urgent.TabIndex = 3;

            this.labelurgentcount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelurgentcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.labelurgentcount.Name = "labelurgentcount";
            this.labelurgentcount.TabIndex = 0;
            this.labelurgentcount.Text = "0";
            this.labelurgentcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.labelurgent.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelurgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelurgent.Height = 40;
            this.labelurgent.Name = "labelurgent";
            this.labelurgent.TabIndex = 1;
            this.labelurgent.Text = "Urgent";
            this.labelurgent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.labellaboverview.AutoSize = true;
            this.labellaboverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.labellaboverview.Name = "labellaboverview";
            this.labellaboverview.Size = new System.Drawing.Size(163, 31);
            this.labellaboverview.TabIndex = 2;
            this.labellaboverview.Text = "Lab Overview";

            this.labovertable.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labovertable.ColumnCount = 5;
            this.labovertable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.labovertable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.labovertable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.labovertable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.labovertable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.labovertable.Controls.Add(this.overcomlab, 0, 0);
            this.labovertable.Controls.Add(this.overtotalequip, 1, 0);
            this.labovertable.Controls.Add(this.overtotalworking, 2, 0);
            this.labovertable.Controls.Add(this.overtotalrepair, 3, 0);
            this.labovertable.Controls.Add(this.overtotalurgent, 4, 0);
            this.labovertable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labovertable.Name = "labovertable";
            this.labovertable.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labovertable.RowCount = 2;
            this.labovertable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.labovertable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.labovertable.TabIndex = 3;

            this.overcomlab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overcomlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.overcomlab.Name = "overcomlab";
            this.overcomlab.TabIndex = 0;
            this.overcomlab.Text = "Comlab";
            this.overcomlab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.overtotalequip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overtotalequip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.overtotalequip.Name = "overtotalequip";
            this.overtotalequip.TabIndex = 1;
            this.overtotalequip.Text = "Total Equipment";
            this.overtotalequip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.overtotalworking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overtotalworking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.overtotalworking.Name = "overtotalworking";
            this.overtotalworking.TabIndex = 2;
            this.overtotalworking.Text = "Working";
            this.overtotalworking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.overtotalrepair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overtotalrepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.overtotalrepair.Name = "overtotalrepair";
            this.overtotalrepair.TabIndex = 3;
            this.overtotalrepair.Text = "Under Repair";
            this.overtotalrepair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.overtotalurgent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overtotalurgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.overtotalurgent.Name = "overtotalurgent";
            this.overtotalurgent.TabIndex = 4;
            this.overtotalurgent.Text = "Urgent";
            this.overtotalurgent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnlFooter.Anchor = System.Windows.Forms.AnchorStyles.Bottom |
                                    System.Windows.Forms.AnchorStyles.Left |
                                    System.Windows.Forms.AnchorStyles.Right;
            this.pnlFooter.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlFooter.Controls.Add(this.labellogin);
            this.pnlFooter.Location = new System.Drawing.Point(0, 714);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1350, 36);
            this.pnlFooter.TabIndex = 2;

            this.labellogin.AutoSize = true;
            this.labellogin.Location = new System.Drawing.Point(21, 8);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(141, 20);
            this.labellogin.TabIndex = 0;
            this.labellogin.Text = "Logged In: Admin";

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 750);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);

            this.pnlSidebar.ResumeLayout(false);
            this.labovertable.ResumeLayout(false);
            this.labovertable.PerformLayout();
            this.urgent.ResumeLayout(false);
            this.forrepair.ResumeLayout(false);
            this.working.ResumeLayout(false);
            this.total.ResumeLayout(false);
            this.statsLayout.ResumeLayout(false);
            this.headerLayout.ResumeLayout(false);
            this.headerLayout.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TableLayoutPanel headerLayout;
        private System.Windows.Forms.Label labelwelcome;
        private System.Windows.Forms.TableLayoutPanel statsLayout;
        private System.Windows.Forms.Panel total;
        private System.Windows.Forms.Label labeltotalcount;
        private System.Windows.Forms.Label labelequipment;
        private System.Windows.Forms.Panel working;
        private System.Windows.Forms.Label labelworkingcount;
        private System.Windows.Forms.Label labelworking;
        private System.Windows.Forms.Panel forrepair;
        private System.Windows.Forms.Label labelrepaircount;
        private System.Windows.Forms.Label labelforrepain;
        private System.Windows.Forms.Panel urgent;
        private System.Windows.Forms.Label labelurgentcount;
        private System.Windows.Forms.Label labelurgent;
        private System.Windows.Forms.Label labellaboverview;
        private System.Windows.Forms.TableLayoutPanel labovertable;
        private System.Windows.Forms.Label overcomlab;
        private System.Windows.Forms.Label overtotalequip;
        private System.Windows.Forms.Label overtotalworking;
        private System.Windows.Forms.Label overtotalrepair;
        private System.Windows.Forms.Label overtotalurgent;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label labellogin;
    }
}
