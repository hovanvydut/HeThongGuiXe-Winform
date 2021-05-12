
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
            this.components = new System.ComponentModel.Container();
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
            this.btnCancel = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnOK = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnReset = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.groupList = new System.Windows.Forms.GroupBox();
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.txtStudentIDFilter = new System.Windows.Forms.TextBox();
            this.txtEmailFilter = new System.Windows.Forms.TextBox();
            this.txtPhoneFilter = new System.Windows.Forms.TextBox();
            this.txtFullnameFilter = new System.Windows.Forms.TextBox();
            this.lbStudentIdFilter = new System.Windows.Forms.Label();
            this.lbEmailFilter = new System.Windows.Forms.Label();
            this.lbPhoneFilter = new System.Windows.Forms.Label();
            this.lbFullnameFilter = new System.Windows.Forms.Label();
            this.tableCustomers = new System.Windows.Forms.DataGridView();
            this.btnShowAll = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnSearch = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.groupInfo.SuspendLayout();
            this.groupList.SuspendLayout();
            this.groupFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.btnCancel);
            this.groupInfo.Controls.Add(this.btnReset);
            this.groupInfo.Controls.Add(this.btnOK);
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
            this.groupInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupInfo.Location = new System.Drawing.Point(29, 22);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(646, 306);
            this.groupInfo.TabIndex = 0;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Thông tin";
            // 
            // cbPort
            // 
            this.cbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(433, 160);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(188, 28);
            this.cbPort.TabIndex = 17;
            this.cbPort.SelectedIndexChanged += new System.EventHandler(this.cbPort_SelectedIndexChanged);
            // 
            // txtCardID
            // 
            this.txtCardID.Location = new System.Drawing.Point(433, 122);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.PasswordChar = '*';
            this.txtCardID.ReadOnly = true;
            this.txtCardID.Size = new System.Drawing.Size(188, 27);
            this.txtCardID.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(116, 164);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(192, 27);
            this.txtPassword.TabIndex = 15;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(116, 122);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(192, 27);
            this.txtUsername.TabIndex = 14;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(433, 79);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(188, 27);
            this.txtStudentID.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(116, 78);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 27);
            this.txtEmail.TabIndex = 12;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(433, 37);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(188, 27);
            this.txtPhone.TabIndex = 11;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(116, 37);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(192, 27);
            this.txtFullname.TabIndex = 10;
            // 
            // lbCardID
            // 
            this.lbCardID.AutoSize = true;
            this.lbCardID.Location = new System.Drawing.Point(314, 122);
            this.lbCardID.Name = "lbCardID";
            this.lbCardID.Size = new System.Drawing.Size(78, 20);
            this.lbCardID.TabIndex = 9;
            this.lbCardID.Text = "Mã thẻ từ";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(11, 167);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(75, 20);
            this.lbPassword.TabIndex = 8;
            this.lbPassword.Text = "Mật khẩu";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(11, 125);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(103, 20);
            this.lbUsername.TabIndex = 7;
            this.lbUsername.Text = "Tên tài khoản";
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Location = new System.Drawing.Point(314, 81);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(117, 20);
            this.lbStudentID.TabIndex = 6;
            this.lbStudentID.Text = "Mã số sinh viên";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(11, 82);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(43, 20);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Emai";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(314, 44);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(100, 20);
            this.lbPhone.TabIndex = 3;
            this.lbPhone.Text = "Số điện thoại";
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.Location = new System.Drawing.Point(11, 43);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(99, 20);
            this.lbFullname.TabIndex = 2;
            this.lbFullname.Text = "Họ và tên (*)";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = global::HeThongGiuXe.Properties.Resources.icons8_automatic_96;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnCancel.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnCancel.Location = new System.Drawing.Point(456, 248);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.Size = new System.Drawing.Size(101, 36);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Xóa";
            this.btnCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BackgroundImage = global::HeThongGiuXe.Properties.Resources.icons8_automatic_96;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnOK.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnOK.Location = new System.Drawing.Point(116, 248);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnOK.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnOK.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOK.Size = new System.Drawing.Size(101, 36);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "Thêm";
            this.btnOK.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = global::HeThongGiuXe.Properties.Resources.icons8_automatic_96;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnReset.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnReset.Location = new System.Drawing.Point(291, 248);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnReset.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.Size = new System.Drawing.Size(101, 36);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Đặt lại";
            this.btnReset.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupList
            // 
            this.groupList.Controls.Add(this.tableCustomers);
            this.groupList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupList.Location = new System.Drawing.Point(29, 343);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(1031, 277);
            this.groupList.TabIndex = 2;
            this.groupList.TabStop = false;
            this.groupList.Text = "Danh sách";
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.btnSearch);
            this.groupFilter.Controls.Add(this.btnShowAll);
            this.groupFilter.Controls.Add(this.txtStudentIDFilter);
            this.groupFilter.Controls.Add(this.txtEmailFilter);
            this.groupFilter.Controls.Add(this.txtPhoneFilter);
            this.groupFilter.Controls.Add(this.txtFullnameFilter);
            this.groupFilter.Controls.Add(this.lbStudentIdFilter);
            this.groupFilter.Controls.Add(this.lbEmailFilter);
            this.groupFilter.Controls.Add(this.lbPhoneFilter);
            this.groupFilter.Controls.Add(this.lbFullnameFilter);
            this.groupFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupFilter.Location = new System.Drawing.Point(693, 22);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(367, 306);
            this.groupFilter.TabIndex = 3;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Tìm kiếm";
            // 
            // txtStudentIDFilter
            // 
            this.txtStudentIDFilter.Location = new System.Drawing.Point(135, 119);
            this.txtStudentIDFilter.Name = "txtStudentIDFilter";
            this.txtStudentIDFilter.Size = new System.Drawing.Size(201, 27);
            this.txtStudentIDFilter.TabIndex = 9;
            // 
            // txtEmailFilter
            // 
            this.txtEmailFilter.Location = new System.Drawing.Point(135, 78);
            this.txtEmailFilter.Name = "txtEmailFilter";
            this.txtEmailFilter.Size = new System.Drawing.Size(201, 27);
            this.txtEmailFilter.TabIndex = 8;
            // 
            // txtPhoneFilter
            // 
            this.txtPhoneFilter.Location = new System.Drawing.Point(135, 160);
            this.txtPhoneFilter.Name = "txtPhoneFilter";
            this.txtPhoneFilter.Size = new System.Drawing.Size(201, 27);
            this.txtPhoneFilter.TabIndex = 7;
            // 
            // txtFullnameFilter
            // 
            this.txtFullnameFilter.Location = new System.Drawing.Point(135, 41);
            this.txtFullnameFilter.Name = "txtFullnameFilter";
            this.txtFullnameFilter.Size = new System.Drawing.Size(201, 27);
            this.txtFullnameFilter.TabIndex = 6;
            // 
            // lbStudentIdFilter
            // 
            this.lbStudentIdFilter.AutoSize = true;
            this.lbStudentIdFilter.Location = new System.Drawing.Point(20, 125);
            this.lbStudentIdFilter.Name = "lbStudentIdFilter";
            this.lbStudentIdFilter.Size = new System.Drawing.Size(51, 20);
            this.lbStudentIdFilter.TabIndex = 4;
            this.lbStudentIdFilter.Text = "Mã số";
            // 
            // lbEmailFilter
            // 
            this.lbEmailFilter.AutoSize = true;
            this.lbEmailFilter.Location = new System.Drawing.Point(24, 82);
            this.lbEmailFilter.Name = "lbEmailFilter";
            this.lbEmailFilter.Size = new System.Drawing.Size(47, 20);
            this.lbEmailFilter.TabIndex = 2;
            this.lbEmailFilter.Text = "Email";
            // 
            // lbPhoneFilter
            // 
            this.lbPhoneFilter.AutoSize = true;
            this.lbPhoneFilter.Location = new System.Drawing.Point(18, 171);
            this.lbPhoneFilter.Name = "lbPhoneFilter";
            this.lbPhoneFilter.Size = new System.Drawing.Size(100, 20);
            this.lbPhoneFilter.TabIndex = 1;
            this.lbPhoneFilter.Text = "Số điện thoại";
            // 
            // lbFullnameFilter
            // 
            this.lbFullnameFilter.AutoSize = true;
            this.lbFullnameFilter.Location = new System.Drawing.Point(20, 43);
            this.lbFullnameFilter.Name = "lbFullnameFilter";
            this.lbFullnameFilter.Size = new System.Drawing.Size(76, 20);
            this.lbFullnameFilter.TabIndex = 0;
            this.lbFullnameFilter.Text = "Họ và tên";
            // 
            // tableCustomers
            // 
            this.tableCustomers.AllowUserToAddRows = false;
            this.tableCustomers.AllowUserToDeleteRows = false;
            this.tableCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.tableCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableCustomers.Location = new System.Drawing.Point(3, 23);
            this.tableCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.tableCustomers.Name = "tableCustomers";
            this.tableCustomers.ReadOnly = true;
            this.tableCustomers.RowHeadersWidth = 51;
            this.tableCustomers.RowTemplate.Height = 24;
            this.tableCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableCustomers.Size = new System.Drawing.Size(1025, 251);
            this.tableCustomers.TabIndex = 4;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAll.BackgroundImage = global::HeThongGiuXe.Properties.Resources.icons8_automatic_96;
            this.btnShowAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnShowAll.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShowAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnShowAll.Location = new System.Drawing.Point(59, 248);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnShowAll.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnShowAll.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShowAll.Size = new System.Drawing.Size(122, 36);
            this.btnShowAll.TabIndex = 23;
            this.btnShowAll.Text = "Xem tất cả";
            this.btnShowAll.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnShowAll.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::HeThongGiuXe.Properties.Resources.icons8_automatic_96;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnSearch.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnSearch.Location = new System.Drawing.Point(205, 248);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.Size = new System.Drawing.Size(120, 36);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // ManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1094, 633);
            this.Controls.Add(this.groupFilter);
            this.Controls.Add(this.groupList);
            this.Controls.Add(this.groupInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ManageCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin khách hàng";
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.groupList.ResumeLayout(false);
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbFullname;
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
        private System.Windows.Forms.GroupBox groupList;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.TextBox txtStudentIDFilter;
        private System.Windows.Forms.TextBox txtEmailFilter;
        private System.Windows.Forms.TextBox txtPhoneFilter;
        private System.Windows.Forms.TextBox txtFullnameFilter;
        private System.Windows.Forms.Label lbStudentIdFilter;
        private System.Windows.Forms.Label lbEmailFilter;
        private System.Windows.Forms.Label lbPhoneFilter;
        private System.Windows.Forms.Label lbFullnameFilter;
        private System.Windows.Forms.ComboBox cbPort;
        private DTO.RoundedButton btnOK;
        private DTO.RoundedButton btnReset;
        private DTO.RoundedButton btnCancel;
        private System.Windows.Forms.DataGridView tableCustomers;
        private DTO.RoundedButton btnSearch;
        private DTO.RoundedButton btnShowAll;
    }
}