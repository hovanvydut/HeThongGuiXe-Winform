
namespace HeThongGiuXe
{
    partial class GeneralManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmployeeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustomerUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFinance = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRevenue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExportReport = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageAttenđanceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShift = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAttendance = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountMenu,
            this.menuFinance,
            this.ManageAttenđanceMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1361, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountMenu
            // 
            this.accountMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogout,
            this.menuEmployeeUser,
            this.menuCustomerUser});
            this.accountMenu.Name = "accountMenu";
            this.accountMenu.Size = new System.Drawing.Size(85, 24);
            this.accountMenu.Text = "Tài khoản";
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(271, 26);
            this.menuLogout.Text = "Đăng xuất";
            this.menuLogout.Click += new System.EventHandler(this.logoutMenu_Click);
            // 
            // menuEmployeeUser
            // 
            this.menuEmployeeUser.Name = "menuEmployeeUser";
            this.menuEmployeeUser.Size = new System.Drawing.Size(271, 26);
            this.menuEmployeeUser.Text = "Quản lí tài khoản nhân viên";
            // 
            // menuCustomerUser
            // 
            this.menuCustomerUser.Name = "menuCustomerUser";
            this.menuCustomerUser.Size = new System.Drawing.Size(271, 26);
            this.menuCustomerUser.Text = "Quản lí tài khoản sinh viên";
            // 
            // menuFinance
            // 
            this.menuFinance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRevenue,
            this.menuExportReport});
            this.menuFinance.Name = "menuFinance";
            this.menuFinance.Size = new System.Drawing.Size(80, 24);
            this.menuFinance.Text = "Tài chính";
            // 
            // menuRevenue
            // 
            this.menuRevenue.Name = "menuRevenue";
            this.menuRevenue.Size = new System.Drawing.Size(224, 26);
            this.menuRevenue.Text = "Quản lí doanh số";
            // 
            // menuExportReport
            // 
            this.menuExportReport.Name = "menuExportReport";
            this.menuExportReport.Size = new System.Drawing.Size(224, 26);
            this.menuExportReport.Text = "Xuất bào cáo";
            // 
            // ManageAttenđanceMenu
            // 
            this.ManageAttenđanceMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuShift,
            this.menuAttendance});
            this.ManageAttenđanceMenu.Name = "ManageAttenđanceMenu";
            this.ManageAttenđanceMenu.Size = new System.Drawing.Size(98, 24);
            this.ManageAttenđanceMenu.Text = "Chấm công";
            // 
            // menuShift
            // 
            this.menuShift.Name = "menuShift";
            this.menuShift.Size = new System.Drawing.Size(224, 26);
            this.menuShift.Text = "Ca làm việc";
            // 
            // menuAttendance
            // 
            this.menuAttendance.Name = "menuAttendance";
            this.menuAttendance.Size = new System.Drawing.Size(224, 26);
            this.menuAttendance.Text = "Điểm danh";
            // 
            // GeneralManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 797);
            this.Controls.Add(this.menuStrip1);
            this.Name = "GeneralManagement";
            this.Text = "Quản lí chung";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountMenu;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuEmployeeUser;
        private System.Windows.Forms.ToolStripMenuItem menuCustomerUser;
        private System.Windows.Forms.ToolStripMenuItem menuFinance;
        private System.Windows.Forms.ToolStripMenuItem menuRevenue;
        private System.Windows.Forms.ToolStripMenuItem menuExportReport;
        private System.Windows.Forms.ToolStripMenuItem ManageAttenđanceMenu;
        private System.Windows.Forms.ToolStripMenuItem menuShift;
        private System.Windows.Forms.ToolStripMenuItem menuAttendance;
    }
}