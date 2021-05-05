
namespace HeThongGiuXe.View.ManageVehicle
{
    partial class ManageVehicle
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
            this.gb_search = new System.Windows.Forms.GroupBox();
            this.gb_payment = new System.Windows.Forms.GroupBox();
            this.rb_isnt_payment = new System.Windows.Forms.RadioButton();
            this.rb_is_payment = new System.Windows.Forms.RadioButton();
            this.rb_all_payment = new System.Windows.Forms.RadioButton();
            this.btnAll = new System.Windows.Forms.Button();
            this.gb_date = new System.Windows.Forms.GroupBox();
            this.dtp_start_day = new System.Windows.Forms.DateTimePicker();
            this.dtp_end_day = new System.Windows.Forms.DateTimePicker();
            this.lb_endday = new System.Windows.Forms.Label();
            this.lb_startday = new System.Windows.Forms.Label();
            this.cb_date = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lb_licenseplates = new System.Windows.Forms.Label();
            this.txt_license_plates = new System.Windows.Forms.TextBox();
            this.gb_range = new System.Windows.Forms.GroupBox();
            this.rb_outpark = new System.Windows.Forms.RadioButton();
            this.rb_inpark = new System.Windows.Forms.RadioButton();
            this.rb_all_range = new System.Windows.Forms.RadioButton();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lb_ownername = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.gb_vehicleresult = new System.Windows.Forms.GroupBox();
            this.dtgv_list_vehicle = new System.Windows.Forms.DataGridView();
            this.gb_search.SuspendLayout();
            this.gb_payment.SuspendLayout();
            this.gb_date.SuspendLayout();
            this.gb_range.SuspendLayout();
            this.gb_vehicleresult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_list_vehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_search
            // 
            this.gb_search.Controls.Add(this.gb_payment);
            this.gb_search.Controls.Add(this.btnAll);
            this.gb_search.Controls.Add(this.gb_date);
            this.gb_search.Controls.Add(this.cb_date);
            this.gb_search.Controls.Add(this.btnClear);
            this.gb_search.Controls.Add(this.btnSearch);
            this.gb_search.Controls.Add(this.lb_licenseplates);
            this.gb_search.Controls.Add(this.txt_license_plates);
            this.gb_search.Controls.Add(this.gb_range);
            this.gb_search.Controls.Add(this.txt_fullname);
            this.gb_search.Controls.Add(this.txt_username);
            this.gb_search.Controls.Add(this.lb_ownername);
            this.gb_search.Controls.Add(this.lb_username);
            this.gb_search.Location = new System.Drawing.Point(12, 12);
            this.gb_search.Name = "gb_search";
            this.gb_search.Size = new System.Drawing.Size(1038, 174);
            this.gb_search.TabIndex = 0;
            this.gb_search.TabStop = false;
            this.gb_search.Text = "Tìm kiếm";
            // 
            // gb_payment
            // 
            this.gb_payment.Controls.Add(this.rb_isnt_payment);
            this.gb_payment.Controls.Add(this.rb_is_payment);
            this.gb_payment.Controls.Add(this.rb_all_payment);
            this.gb_payment.Location = new System.Drawing.Point(614, 19);
            this.gb_payment.Name = "gb_payment";
            this.gb_payment.Size = new System.Drawing.Size(313, 66);
            this.gb_payment.TabIndex = 14;
            this.gb_payment.TabStop = false;
            this.gb_payment.Text = "Thanh toán";
            // 
            // rb_isnt_payment
            // 
            this.rb_isnt_payment.AutoSize = true;
            this.rb_isnt_payment.Location = new System.Drawing.Point(202, 24);
            this.rb_isnt_payment.Name = "rb_isnt_payment";
            this.rb_isnt_payment.Size = new System.Drawing.Size(104, 17);
            this.rb_isnt_payment.TabIndex = 2;
            this.rb_isnt_payment.TabStop = true;
            this.rb_isnt_payment.Text = "Chưa thanh toán";
            this.rb_isnt_payment.UseVisualStyleBackColor = true;
            // 
            // rb_is_payment
            // 
            this.rb_is_payment.AutoSize = true;
            this.rb_is_payment.Location = new System.Drawing.Point(95, 24);
            this.rb_is_payment.Name = "rb_is_payment";
            this.rb_is_payment.Size = new System.Drawing.Size(101, 17);
            this.rb_is_payment.TabIndex = 1;
            this.rb_is_payment.TabStop = true;
            this.rb_is_payment.Text = "Đã Thanh Toán";
            this.rb_is_payment.UseVisualStyleBackColor = true;
            // 
            // rb_all_payment
            // 
            this.rb_all_payment.AutoSize = true;
            this.rb_all_payment.Location = new System.Drawing.Point(18, 24);
            this.rb_all_payment.Name = "rb_all_payment";
            this.rb_all_payment.Size = new System.Drawing.Size(56, 17);
            this.rb_all_payment.TabIndex = 0;
            this.rb_all_payment.TabStop = true;
            this.rb_all_payment.Text = "Tất cả";
            this.rb_all_payment.UseVisualStyleBackColor = true;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(944, 136);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 6;
            this.btnAll.Text = "Xem tất cả";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // gb_date
            // 
            this.gb_date.Controls.Add(this.dtp_start_day);
            this.gb_date.Controls.Add(this.dtp_end_day);
            this.gb_date.Controls.Add(this.lb_endday);
            this.gb_date.Controls.Add(this.lb_startday);
            this.gb_date.Enabled = false;
            this.gb_date.Location = new System.Drawing.Point(305, 53);
            this.gb_date.Name = "gb_date";
            this.gb_date.Size = new System.Drawing.Size(270, 106);
            this.gb_date.TabIndex = 13;
            this.gb_date.TabStop = false;
            this.gb_date.Text = "Tìm theo ngày gửi";
            // 
            // dtp_start_day
            // 
            this.dtp_start_day.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_start_day.Location = new System.Drawing.Point(79, 27);
            this.dtp_start_day.Name = "dtp_start_day";
            this.dtp_start_day.Size = new System.Drawing.Size(185, 20);
            this.dtp_start_day.TabIndex = 4;
            this.dtp_start_day.Value = new System.DateTime(2021, 5, 5, 0, 0, 0, 0);
            // 
            // dtp_end_day
            // 
            this.dtp_end_day.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end_day.Location = new System.Drawing.Point(79, 69);
            this.dtp_end_day.Name = "dtp_end_day";
            this.dtp_end_day.Size = new System.Drawing.Size(185, 20);
            this.dtp_end_day.TabIndex = 5;
            this.dtp_end_day.Value = new System.DateTime(2021, 5, 5, 23, 59, 0, 0);
            // 
            // lb_endday
            // 
            this.lb_endday.AutoSize = true;
            this.lb_endday.Location = new System.Drawing.Point(6, 74);
            this.lb_endday.Name = "lb_endday";
            this.lb_endday.Size = new System.Drawing.Size(53, 13);
            this.lb_endday.TabIndex = 0;
            this.lb_endday.Text = "Đến ngày";
            // 
            // lb_startday
            // 
            this.lb_startday.AutoSize = true;
            this.lb_startday.Location = new System.Drawing.Point(6, 33);
            this.lb_startday.Name = "lb_startday";
            this.lb_startday.Size = new System.Drawing.Size(46, 13);
            this.lb_startday.TabIndex = 0;
            this.lb_startday.Text = "Từ ngày";
            // 
            // cb_date
            // 
            this.cb_date.AutoSize = true;
            this.cb_date.Location = new System.Drawing.Point(305, 25);
            this.cb_date.Name = "cb_date";
            this.cb_date.Size = new System.Drawing.Size(110, 17);
            this.cb_date.TabIndex = 12;
            this.cb_date.Text = "Tìm theo ngày gửi";
            this.cb_date.UseVisualStyleBackColor = true;
            this.cb_date.CheckedChanged += new System.EventHandler(this.cb_date_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(944, 79);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Đặt lại";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(944, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lb_licenseplates
            // 
            this.lb_licenseplates.AutoSize = true;
            this.lb_licenseplates.Location = new System.Drawing.Point(24, 141);
            this.lb_licenseplates.Name = "lb_licenseplates";
            this.lb_licenseplates.Size = new System.Drawing.Size(56, 13);
            this.lb_licenseplates.TabIndex = 1;
            this.lb_licenseplates.Text = "Biển số xe";
            // 
            // txt_license_plates
            // 
            this.txt_license_plates.Location = new System.Drawing.Point(133, 138);
            this.txt_license_plates.Name = "txt_license_plates";
            this.txt_license_plates.Size = new System.Drawing.Size(148, 20);
            this.txt_license_plates.TabIndex = 3;
            // 
            // gb_range
            // 
            this.gb_range.Controls.Add(this.rb_outpark);
            this.gb_range.Controls.Add(this.rb_inpark);
            this.gb_range.Controls.Add(this.rb_all_range);
            this.gb_range.Location = new System.Drawing.Point(614, 91);
            this.gb_range.Name = "gb_range";
            this.gb_range.Size = new System.Drawing.Size(313, 68);
            this.gb_range.TabIndex = 5;
            this.gb_range.TabStop = false;
            this.gb_range.Text = "Phạm vi";
            // 
            // rb_outpark
            // 
            this.rb_outpark.AutoSize = true;
            this.rb_outpark.Location = new System.Drawing.Point(181, 36);
            this.rb_outpark.Name = "rb_outpark";
            this.rb_outpark.Size = new System.Drawing.Size(66, 17);
            this.rb_outpark.TabIndex = 8;
            this.rb_outpark.TabStop = true;
            this.rb_outpark.Text = "Xe đã ra";
            this.rb_outpark.UseVisualStyleBackColor = true;
            // 
            // rb_inpark
            // 
            this.rb_inpark.AutoSize = true;
            this.rb_inpark.Location = new System.Drawing.Point(93, 36);
            this.rb_inpark.Name = "rb_inpark";
            this.rb_inpark.Size = new System.Drawing.Size(82, 17);
            this.rb_inpark.TabIndex = 7;
            this.rb_inpark.TabStop = true;
            this.rb_inpark.Text = "Xe trong bãi";
            this.rb_inpark.UseVisualStyleBackColor = true;
            // 
            // rb_all_range
            // 
            this.rb_all_range.AutoSize = true;
            this.rb_all_range.Location = new System.Drawing.Point(18, 36);
            this.rb_all_range.Name = "rb_all_range";
            this.rb_all_range.Size = new System.Drawing.Size(56, 17);
            this.rb_all_range.TabIndex = 6;
            this.rb_all_range.TabStop = true;
            this.rb_all_range.Text = "Tất cả";
            this.rb_all_range.UseVisualStyleBackColor = true;
            // 
            // txt_fullname
            // 
            this.txt_fullname.Location = new System.Drawing.Point(133, 25);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(148, 20);
            this.txt_fullname.TabIndex = 1;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(133, 79);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(148, 20);
            this.txt_username.TabIndex = 2;
            // 
            // lb_ownername
            // 
            this.lb_ownername.AutoSize = true;
            this.lb_ownername.Location = new System.Drawing.Point(24, 87);
            this.lb_ownername.Name = "lb_ownername";
            this.lb_ownername.Size = new System.Drawing.Size(73, 13);
            this.lb_ownername.TabIndex = 1;
            this.lb_ownername.Text = "Tên tài khoản";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(24, 32);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(65, 13);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Tên chủ thẻ";
            // 
            // gb_vehicleresult
            // 
            this.gb_vehicleresult.Controls.Add(this.dtgv_list_vehicle);
            this.gb_vehicleresult.Location = new System.Drawing.Point(23, 202);
            this.gb_vehicleresult.Name = "gb_vehicleresult";
            this.gb_vehicleresult.Size = new System.Drawing.Size(1027, 298);
            this.gb_vehicleresult.TabIndex = 1;
            this.gb_vehicleresult.TabStop = false;
            this.gb_vehicleresult.Text = "Danh sách xe";
            // 
            // dtgv_list_vehicle
            // 
            this.dtgv_list_vehicle.AllowUserToAddRows = false;
            this.dtgv_list_vehicle.AllowUserToDeleteRows = false;
            this.dtgv_list_vehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_list_vehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_list_vehicle.Location = new System.Drawing.Point(3, 16);
            this.dtgv_list_vehicle.Name = "dtgv_list_vehicle";
            this.dtgv_list_vehicle.ReadOnly = true;
            this.dtgv_list_vehicle.Size = new System.Drawing.Size(1021, 279);
            this.dtgv_list_vehicle.TabIndex = 0;
            // 
            // ManageVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 542);
            this.Controls.Add(this.gb_vehicleresult);
            this.Controls.Add(this.gb_search);
            this.Name = "ManageVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageVehicle";
            this.gb_search.ResumeLayout(false);
            this.gb_search.PerformLayout();
            this.gb_payment.ResumeLayout(false);
            this.gb_payment.PerformLayout();
            this.gb_date.ResumeLayout(false);
            this.gb_date.PerformLayout();
            this.gb_range.ResumeLayout(false);
            this.gb_range.PerformLayout();
            this.gb_vehicleresult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_list_vehicle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_search;
        private System.Windows.Forms.DateTimePicker dtp_end_day;
        private System.Windows.Forms.DateTimePicker dtp_start_day;
        private System.Windows.Forms.TextBox txt_license_plates;
        private System.Windows.Forms.Label lb_licenseplates;
        private System.Windows.Forms.Label lb_startday;
        private System.Windows.Forms.Label lb_endday;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.Label lb_ownername;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.GroupBox gb_range;
        private System.Windows.Forms.RadioButton rb_outpark;
        private System.Windows.Forms.RadioButton rb_inpark;
        private System.Windows.Forms.RadioButton rb_all_range;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gb_vehicleresult;
        private System.Windows.Forms.DataGridView dtgv_list_vehicle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gb_date;
        private System.Windows.Forms.CheckBox cb_date;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.GroupBox gb_payment;
        private System.Windows.Forms.RadioButton rb_isnt_payment;
        private System.Windows.Forms.RadioButton rb_is_payment;
        private System.Windows.Forms.RadioButton rb_all_payment;
    }
}