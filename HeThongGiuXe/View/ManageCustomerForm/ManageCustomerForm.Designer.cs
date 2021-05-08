
namespace HeThongGiuXe
{
    partial class ManageCustomer
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
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lbCardID = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbFullname = new System.Windows.Forms.Label();
            this.groupControl = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupList = new System.Windows.Forms.GroupBox();
            this.tableCustomers = new System.Windows.Forms.DataGridView();
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.txtStudentIDFilter = new System.Windows.Forms.TextBox();
            this.txtEmailFilter = new System.Windows.Forms.TextBox();
            this.txtPhoneFilter = new System.Windows.Forms.TextBox();
            this.txtFullnameFilter = new System.Windows.Forms.TextBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lbStudentIdFilter = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbEmailFilter = new System.Windows.Forms.Label();
            this.lbPhoneFilter = new System.Windows.Forms.Label();
            this.lbFullnameFilter = new System.Windows.Forms.Label();
            this.groupInfo.SuspendLayout();
            this.groupControl.SuspendLayout();
            this.groupList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCustomers)).BeginInit();
            this.groupFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.cbPort);
            this.groupInfo.Controls.Add(this.txtCardID);
            this.groupInfo.Controls.Add(this.txtPassword);
            this.groupInfo.Controls.Add(this.txtUsername);
            this.groupInfo.Controls.Add(this.txtStudentID);
            this.groupInfo.Controls.Add(this.txtEmail);
            this.groupInfo.Controls.Add(this.txtPhone);
            this.groupInfo.Controls.Add(this.txtFullname);
            this.groupInfo.Controls.Add(this.lbCardID);
            this.groupInfo.Controls.Add(this.lbPassword);
            this.groupInfo.Controls.Add(this.lbUsername);
            this.groupInfo.Controls.Add(this.lbStudentID);
            this.groupInfo.Controls.Add(this.lbEmail);
            this.groupInfo.Controls.Add(this.lbPhone);
            this.groupInfo.Controls.Add(this.lbFullname);
            this.groupInfo.Location = new System.Drawing.Point(85, 24);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(477, 245);
            this.groupInfo.TabIndex = 0;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Thông tin";
            // 
            // cbPort
            // 
            this.cbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(364, 200);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(84, 24);
            this.cbPort.TabIndex = 17;
            this.cbPort.SelectedIndexChanged += new System.EventHandler(this.cbPort_SelectedIndexChanged);
            // 
            // txtCardID
            // 
            this.txtCardID.Location = new System.Drawing.Point(159, 200);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.ReadOnly = true;
            this.txtCardID.Size = new System.Drawing.Size(198, 22);
            this.txtCardID.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(159, 172);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(289, 22);
            this.txtPassword.TabIndex = 15;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(159, 144);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(289, 22);
            this.txtUsername.TabIndex = 14;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(159, 116);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(289, 22);
            this.txtStudentID.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(159, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(289, 22);
            this.txtEmail.TabIndex = 12;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(159, 60);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(289, 22);
            this.txtPhone.TabIndex = 11;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(159, 32);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(289, 22);
            this.txtFullname.TabIndex = 10;
            // 
            // lbCardID
            // 
            this.lbCardID.AutoSize = true;
            this.lbCardID.Location = new System.Drawing.Point(16, 205);
            this.lbCardID.Name = "lbCardID";
            this.lbCardID.Size = new System.Drawing.Size(67, 17);
            this.lbCardID.TabIndex = 9;
            this.lbCardID.Text = "Mã thẻ từ";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(17, 177);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(66, 17);
            this.lbPassword.TabIndex = 8;
            this.lbPassword.Text = "Mật khẩu";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(16, 149);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(95, 17);
            this.lbUsername.TabIndex = 7;
            this.lbUsername.Text = "Tên tài khoản";
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Location = new System.Drawing.Point(17, 120);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(106, 17);
            this.lbStudentID.TabIndex = 6;
            this.lbStudentID.Text = "Mã số sinh viên";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(17, 88);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(39, 17);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Emai";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(17, 59);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(91, 17);
            this.lbPhone.TabIndex = 3;
            this.lbPhone.Text = "Số điện thoại";
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.Location = new System.Drawing.Point(17, 32);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(88, 17);
            this.lbFullname.TabIndex = 2;
            this.lbFullname.Text = "Họ và tên (*)";
            // 
            // groupControl
            // 
            this.groupControl.Controls.Add(this.btnOK);
            this.groupControl.Controls.Add(this.btnReset);
            this.groupControl.Controls.Add(this.btnCancel);
            this.groupControl.Location = new System.Drawing.Point(632, 24);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(208, 245);
            this.groupControl.TabIndex = 1;
            this.groupControl.TabStop = false;
            this.groupControl.Text = "Thao tác";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 54);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(185, 35);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = "Thêm";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 105);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(185, 35);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 159);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(185, 35);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Xoá";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupList
            // 
            this.groupList.Controls.Add(this.tableCustomers);
            this.groupList.Location = new System.Drawing.Point(85, 379);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(755, 435);
            this.groupList.TabIndex = 2;
            this.groupList.TabStop = false;
            this.groupList.Text = "Danh sách";
            // 
            // tableCustomers
            // 
            this.tableCustomers.AllowUserToAddRows = false;
            this.tableCustomers.AllowUserToDeleteRows = false;
            this.tableCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tableCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCustomers.Location = new System.Drawing.Point(19, 32);
            this.tableCustomers.Name = "tableCustomers";
            this.tableCustomers.ReadOnly = true;
            this.tableCustomers.RowHeadersWidth = 51;
            this.tableCustomers.RowTemplate.Height = 24;
            this.tableCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableCustomers.Size = new System.Drawing.Size(715, 386);
            this.tableCustomers.TabIndex = 0;
            this.tableCustomers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableCustomers_RowHeaderMouseClick);
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.txtStudentIDFilter);
            this.groupFilter.Controls.Add(this.txtEmailFilter);
            this.groupFilter.Controls.Add(this.txtPhoneFilter);
            this.groupFilter.Controls.Add(this.txtFullnameFilter);
            this.groupFilter.Controls.Add(this.btnShowAll);
            this.groupFilter.Controls.Add(this.lbStudentIdFilter);
            this.groupFilter.Controls.Add(this.btnSearch);
            this.groupFilter.Controls.Add(this.lbEmailFilter);
            this.groupFilter.Controls.Add(this.lbPhoneFilter);
            this.groupFilter.Controls.Add(this.lbFullnameFilter);
            this.groupFilter.Location = new System.Drawing.Point(85, 276);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(755, 100);
            this.groupFilter.TabIndex = 3;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Tìm kiếm";
            // 
            // txtStudentIDFilter
            // 
            this.txtStudentIDFilter.Location = new System.Drawing.Point(92, 60);
            this.txtStudentIDFilter.Name = "txtStudentIDFilter";
            this.txtStudentIDFilter.Size = new System.Drawing.Size(168, 22);
            this.txtStudentIDFilter.TabIndex = 9;
            // 
            // txtEmailFilter
            // 
            this.txtEmailFilter.Location = new System.Drawing.Point(541, 30);
            this.txtEmailFilter.Name = "txtEmailFilter";
            this.txtEmailFilter.Size = new System.Drawing.Size(203, 22);
            this.txtEmailFilter.TabIndex = 8;
            // 
            // txtPhoneFilter
            // 
            this.txtPhoneFilter.Location = new System.Drawing.Point(363, 30);
            this.txtPhoneFilter.Name = "txtPhoneFilter";
            this.txtPhoneFilter.Size = new System.Drawing.Size(124, 22);
            this.txtPhoneFilter.TabIndex = 7;
            // 
            // txtFullnameFilter
            // 
            this.txtFullnameFilter.Location = new System.Drawing.Point(92, 30);
            this.txtFullnameFilter.Name = "txtFullnameFilter";
            this.txtFullnameFilter.Size = new System.Drawing.Size(168, 22);
            this.txtFullnameFilter.TabIndex = 6;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(269, 57);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(218, 27);
            this.btnShowAll.TabIndex = 5;
            this.btnShowAll.Text = "Xem tất cả";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lbStudentIdFilter
            // 
            this.lbStudentIdFilter.AutoSize = true;
            this.lbStudentIdFilter.Location = new System.Drawing.Point(20, 64);
            this.lbStudentIdFilter.Name = "lbStudentIdFilter";
            this.lbStudentIdFilter.Size = new System.Drawing.Size(46, 17);
            this.lbStudentIdFilter.TabIndex = 4;
            this.lbStudentIdFilter.Text = "Mã số";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(496, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(248, 27);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbEmailFilter
            // 
            this.lbEmailFilter.AutoSize = true;
            this.lbEmailFilter.Location = new System.Drawing.Point(493, 30);
            this.lbEmailFilter.Name = "lbEmailFilter";
            this.lbEmailFilter.Size = new System.Drawing.Size(42, 17);
            this.lbEmailFilter.TabIndex = 2;
            this.lbEmailFilter.Text = "Email";
            // 
            // lbPhoneFilter
            // 
            this.lbPhoneFilter.AutoSize = true;
            this.lbPhoneFilter.Location = new System.Drawing.Point(266, 30);
            this.lbPhoneFilter.Name = "lbPhoneFilter";
            this.lbPhoneFilter.Size = new System.Drawing.Size(91, 17);
            this.lbPhoneFilter.TabIndex = 1;
            this.lbPhoneFilter.Text = "Số điện thoại";
            // 
            // lbFullnameFilter
            // 
            this.lbFullnameFilter.AutoSize = true;
            this.lbFullnameFilter.Location = new System.Drawing.Point(17, 30);
            this.lbFullnameFilter.Name = "lbFullnameFilter";
            this.lbFullnameFilter.Size = new System.Drawing.Size(69, 17);
            this.lbFullnameFilter.TabIndex = 0;
            this.lbFullnameFilter.Text = "Họ và tên";
            // 
            // ManageCustomer
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 837);
            this.Controls.Add(this.groupFilter);
            this.Controls.Add(this.groupList);
            this.Controls.Add(this.groupControl);
            this.Controls.Add(this.groupInfo);
            this.Name = "ManageCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin khách hàng";
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.groupControl.ResumeLayout(false);
            this.groupList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableCustomers)).EndInit();
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.GroupBox groupControl;
        private System.Windows.Forms.Label lbCardID;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupList;
        private System.Windows.Forms.DataGridView tableCustomers;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.TextBox txtStudentIDFilter;
        private System.Windows.Forms.TextBox txtEmailFilter;
        private System.Windows.Forms.TextBox txtPhoneFilter;
        private System.Windows.Forms.TextBox txtFullnameFilter;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lbStudentIdFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbEmailFilter;
        private System.Windows.Forms.Label lbPhoneFilter;
        private System.Windows.Forms.Label lbFullnameFilter;
        private System.Windows.Forms.ComboBox cbPort;
    }
}