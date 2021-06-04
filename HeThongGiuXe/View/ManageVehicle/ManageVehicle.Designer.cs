
namespace HeThongGiuXe.View
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageVehicle));
            this.lbTotal = new System.Windows.Forms.Label();
            this.gb_Thongke = new System.Windows.Forms.GroupBox();
            this.lbTotalUnpaid = new System.Windows.Forms.Label();
            this.lbTotalPaid = new System.Windows.Forms.Label();
            this.lbTotalInPark = new System.Windows.Forms.Label();
            this.gb_payment = new System.Windows.Forms.GroupBox();
            this.rb_isnt_payment = new System.Windows.Forms.RadioButton();
            this.rb_is_payment = new System.Windows.Forms.RadioButton();
            this.rb_all_payment = new System.Windows.Forms.RadioButton();
            this.gb_vehicleresult = new System.Windows.Forms.GroupBox();
            this.dtgv_list_vehicle = new System.Windows.Forms.DataGridView();
            this.rb_inpark = new System.Windows.Forms.RadioButton();
            this.rb_all_range = new System.Windows.Forms.RadioButton();
            this.gb_date = new System.Windows.Forms.GroupBox();
            this.dtp_start_day = new System.Windows.Forms.DateTimePicker();
            this.dtp_end_day = new System.Windows.Forms.DateTimePicker();
            this.lb_endday = new System.Windows.Forms.Label();
            this.lb_startday = new System.Windows.Forms.Label();
            this.rb_outpark = new System.Windows.Forms.RadioButton();
            this.cb_date = new System.Windows.Forms.CheckBox();
            this.lb_licenseplates = new System.Windows.Forms.Label();
            this.txt_license_plates = new System.Windows.Forms.TextBox();
            this.gb_range = new System.Windows.Forms.GroupBox();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lb_ownername = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.gb_search = new System.Windows.Forms.GroupBox();
            this.btnAll = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnClear = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnSearch = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.gbTodayStatistics = new System.Windows.Forms.GroupBox();
            this.lbTodayCheckin = new System.Windows.Forms.Label();
            this.lbTodayCheckout = new System.Windows.Forms.Label();
            this.gb_Thongke.SuspendLayout();
            this.gb_payment.SuspendLayout();
            this.gb_vehicleresult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_list_vehicle)).BeginInit();
            this.gb_date.SuspendLayout();
            this.gb_range.SuspendLayout();
            this.gb_search.SuspendLayout();
            this.gbTodayStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(40, 154);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(249, 28);
            this.lbTotal.TabIndex = 15;
            this.lbTotal.Text = "Tổng số xe ( hệ thống ) : ";
            // 
            // gb_Thongke
            // 
            this.gb_Thongke.Controls.Add(this.lbTotalUnpaid);
            this.gb_Thongke.Controls.Add(this.lbTotalPaid);
            this.gb_Thongke.Controls.Add(this.lbTotalInPark);
            this.gb_Thongke.Controls.Add(this.lbTotal);
            this.gb_Thongke.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gb_Thongke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.gb_Thongke.Location = new System.Drawing.Point(5, 556);
            this.gb_Thongke.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Thongke.Name = "gb_Thongke";
            this.gb_Thongke.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Thongke.Size = new System.Drawing.Size(1056, 230);
            this.gb_Thongke.TabIndex = 8;
            this.gb_Thongke.TabStop = false;
            this.gb_Thongke.Text = "Thống kê";
            // 
            // lbTotalUnpaid
            // 
            this.lbTotalUnpaid.AutoSize = true;
            this.lbTotalUnpaid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalUnpaid.Location = new System.Drawing.Point(545, 150);
            this.lbTotalUnpaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalUnpaid.Name = "lbTotalUnpaid";
            this.lbTotalUnpaid.Size = new System.Drawing.Size(254, 28);
            this.lbTotalUnpaid.TabIndex = 15;
            this.lbTotalUnpaid.Text = "Số lượt chưa thanh toán :";
            // 
            // lbTotalPaid
            // 
            this.lbTotalPaid.AutoSize = true;
            this.lbTotalPaid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPaid.Location = new System.Drawing.Point(545, 71);
            this.lbTotalPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalPaid.Name = "lbTotalPaid";
            this.lbTotalPaid.Size = new System.Drawing.Size(232, 28);
            this.lbTotalPaid.TabIndex = 15;
            this.lbTotalPaid.Text = "Số lượt đã thanh toán :";
            // 
            // lbTotalInPark
            // 
            this.lbTotalInPark.AutoSize = true;
            this.lbTotalInPark.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalInPark.Location = new System.Drawing.Point(40, 71);
            this.lbTotalInPark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalInPark.Name = "lbTotalInPark";
            this.lbTotalInPark.Size = new System.Drawing.Size(265, 28);
            this.lbTotalInPark.TabIndex = 15;
            this.lbTotalInPark.Text = "Tổng số xe còn trong bãi  :";
            // 
            // gb_payment
            // 
            this.gb_payment.Controls.Add(this.rb_isnt_payment);
            this.gb_payment.Controls.Add(this.rb_is_payment);
            this.gb_payment.Controls.Add(this.rb_all_payment);
            this.gb_payment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_payment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.gb_payment.Location = new System.Drawing.Point(803, 23);
            this.gb_payment.Margin = new System.Windows.Forms.Padding(4);
            this.gb_payment.Name = "gb_payment";
            this.gb_payment.Padding = new System.Windows.Forms.Padding(4);
            this.gb_payment.Size = new System.Drawing.Size(463, 81);
            this.gb_payment.TabIndex = 14;
            this.gb_payment.TabStop = false;
            this.gb_payment.Text = "Thanh toán";
            // 
            // rb_isnt_payment
            // 
            this.rb_isnt_payment.AutoSize = true;
            this.rb_isnt_payment.Location = new System.Drawing.Point(284, 30);
            this.rb_isnt_payment.Margin = new System.Windows.Forms.Padding(4);
            this.rb_isnt_payment.Name = "rb_isnt_payment";
            this.rb_isnt_payment.Size = new System.Drawing.Size(164, 27);
            this.rb_isnt_payment.TabIndex = 2;
            this.rb_isnt_payment.TabStop = true;
            this.rb_isnt_payment.Text = "Chưa thanh toán";
            this.rb_isnt_payment.UseVisualStyleBackColor = true;
            // 
            // rb_is_payment
            // 
            this.rb_is_payment.AutoSize = true;
            this.rb_is_payment.Location = new System.Drawing.Point(116, 30);
            this.rb_is_payment.Margin = new System.Windows.Forms.Padding(4);
            this.rb_is_payment.Name = "rb_is_payment";
            this.rb_is_payment.Size = new System.Drawing.Size(149, 27);
            this.rb_is_payment.TabIndex = 1;
            this.rb_is_payment.TabStop = true;
            this.rb_is_payment.Text = "Đã Thanh Toán";
            this.rb_is_payment.UseVisualStyleBackColor = true;
            // 
            // rb_all_payment
            // 
            this.rb_all_payment.AutoSize = true;
            this.rb_all_payment.Location = new System.Drawing.Point(24, 30);
            this.rb_all_payment.Margin = new System.Windows.Forms.Padding(4);
            this.rb_all_payment.Name = "rb_all_payment";
            this.rb_all_payment.Size = new System.Drawing.Size(79, 27);
            this.rb_all_payment.TabIndex = 0;
            this.rb_all_payment.TabStop = true;
            this.rb_all_payment.Text = "Tất cả";
            this.rb_all_payment.UseVisualStyleBackColor = true;
            // 
            // gb_vehicleresult
            // 
            this.gb_vehicleresult.Controls.Add(this.dtgv_list_vehicle);
            this.gb_vehicleresult.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_vehicleresult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.gb_vehicleresult.Location = new System.Drawing.Point(5, 236);
            this.gb_vehicleresult.Margin = new System.Windows.Forms.Padding(4);
            this.gb_vehicleresult.Name = "gb_vehicleresult";
            this.gb_vehicleresult.Padding = new System.Windows.Forms.Padding(4);
            this.gb_vehicleresult.Size = new System.Drawing.Size(1461, 313);
            this.gb_vehicleresult.TabIndex = 7;
            this.gb_vehicleresult.TabStop = false;
            this.gb_vehicleresult.Text = "Danh sách xe";
            // 
            // dtgv_list_vehicle
            // 
            this.dtgv_list_vehicle.AllowUserToAddRows = false;
            this.dtgv_list_vehicle.AllowUserToDeleteRows = false;
            this.dtgv_list_vehicle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_list_vehicle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.dtgv_list_vehicle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_list_vehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_list_vehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_list_vehicle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.dtgv_list_vehicle.Location = new System.Drawing.Point(4, 29);
            this.dtgv_list_vehicle.Margin = new System.Windows.Forms.Padding(5);
            this.dtgv_list_vehicle.Name = "dtgv_list_vehicle";
            this.dtgv_list_vehicle.ReadOnly = true;
            this.dtgv_list_vehicle.RowHeadersWidth = 51;
            this.dtgv_list_vehicle.RowTemplate.Height = 24;
            this.dtgv_list_vehicle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_list_vehicle.Size = new System.Drawing.Size(1453, 280);
            this.dtgv_list_vehicle.TabIndex = 4;
            // 
            // rb_inpark
            // 
            this.rb_inpark.AutoSize = true;
            this.rb_inpark.Location = new System.Drawing.Point(116, 38);
            this.rb_inpark.Margin = new System.Windows.Forms.Padding(4);
            this.rb_inpark.Name = "rb_inpark";
            this.rb_inpark.Size = new System.Drawing.Size(131, 27);
            this.rb_inpark.TabIndex = 7;
            this.rb_inpark.TabStop = true;
            this.rb_inpark.Text = "Xe trong bãi";
            this.rb_inpark.UseVisualStyleBackColor = true;
            // 
            // rb_all_range
            // 
            this.rb_all_range.AutoSize = true;
            this.rb_all_range.Location = new System.Drawing.Point(24, 38);
            this.rb_all_range.Margin = new System.Windows.Forms.Padding(4);
            this.rb_all_range.Name = "rb_all_range";
            this.rb_all_range.Size = new System.Drawing.Size(79, 27);
            this.rb_all_range.TabIndex = 6;
            this.rb_all_range.TabStop = true;
            this.rb_all_range.Text = "Tất cả";
            this.rb_all_range.UseVisualStyleBackColor = true;
            // 
            // gb_date
            // 
            this.gb_date.Controls.Add(this.dtp_start_day);
            this.gb_date.Controls.Add(this.dtp_end_day);
            this.gb_date.Controls.Add(this.lb_endday);
            this.gb_date.Controls.Add(this.lb_startday);
            this.gb_date.Enabled = false;
            this.gb_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.gb_date.Location = new System.Drawing.Point(407, 65);
            this.gb_date.Margin = new System.Windows.Forms.Padding(4);
            this.gb_date.Name = "gb_date";
            this.gb_date.Padding = new System.Windows.Forms.Padding(4);
            this.gb_date.Size = new System.Drawing.Size(368, 130);
            this.gb_date.TabIndex = 13;
            this.gb_date.TabStop = false;
            this.gb_date.Text = "Tìm theo ngày gửi";
            // 
            // dtp_start_day
            // 
            this.dtp_start_day.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.dtp_start_day.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.dtp_start_day.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_start_day.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_start_day.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_start_day.Location = new System.Drawing.Point(105, 33);
            this.dtp_start_day.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_start_day.Name = "dtp_start_day";
            this.dtp_start_day.Size = new System.Drawing.Size(245, 32);
            this.dtp_start_day.TabIndex = 4;
            this.dtp_start_day.Value = new System.DateTime(2021, 5, 5, 0, 0, 0, 0);
            // 
            // dtp_end_day
            // 
            this.dtp_end_day.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end_day.Location = new System.Drawing.Point(105, 85);
            this.dtp_end_day.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_end_day.Name = "dtp_end_day";
            this.dtp_end_day.Size = new System.Drawing.Size(245, 30);
            this.dtp_end_day.TabIndex = 5;
            this.dtp_end_day.Value = new System.DateTime(2021, 5, 5, 23, 59, 0, 0);
            // 
            // lb_endday
            // 
            this.lb_endday.AutoSize = true;
            this.lb_endday.Location = new System.Drawing.Point(8, 91);
            this.lb_endday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_endday.Name = "lb_endday";
            this.lb_endday.Size = new System.Drawing.Size(93, 25);
            this.lb_endday.TabIndex = 0;
            this.lb_endday.Text = "Đến ngày";
            // 
            // lb_startday
            // 
            this.lb_startday.AutoSize = true;
            this.lb_startday.Location = new System.Drawing.Point(8, 41);
            this.lb_startday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_startday.Name = "lb_startday";
            this.lb_startday.Size = new System.Drawing.Size(82, 25);
            this.lb_startday.TabIndex = 0;
            this.lb_startday.Text = "Từ ngày";
            // 
            // rb_outpark
            // 
            this.rb_outpark.AutoSize = true;
            this.rb_outpark.Location = new System.Drawing.Point(284, 38);
            this.rb_outpark.Margin = new System.Windows.Forms.Padding(4);
            this.rb_outpark.Name = "rb_outpark";
            this.rb_outpark.Size = new System.Drawing.Size(97, 27);
            this.rb_outpark.TabIndex = 8;
            this.rb_outpark.TabStop = true;
            this.rb_outpark.Text = "Xe đã ra";
            this.rb_outpark.UseVisualStyleBackColor = true;
            // 
            // cb_date
            // 
            this.cb_date.AutoSize = true;
            this.cb_date.Location = new System.Drawing.Point(489, 32);
            this.cb_date.Margin = new System.Windows.Forms.Padding(4);
            this.cb_date.Name = "cb_date";
            this.cb_date.Size = new System.Drawing.Size(190, 29);
            this.cb_date.TabIndex = 12;
            this.cb_date.Text = "Tìm theo ngày gửi";
            this.cb_date.UseVisualStyleBackColor = true;
            this.cb_date.CheckedChanged += new System.EventHandler(this.cb_date_CheckedChanged);
            // 
            // lb_licenseplates
            // 
            this.lb_licenseplates.AutoSize = true;
            this.lb_licenseplates.Location = new System.Drawing.Point(60, 156);
            this.lb_licenseplates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_licenseplates.Name = "lb_licenseplates";
            this.lb_licenseplates.Size = new System.Drawing.Size(99, 25);
            this.lb_licenseplates.TabIndex = 1;
            this.lb_licenseplates.Text = "Biển số xe";
            // 
            // txt_license_plates
            // 
            this.txt_license_plates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txt_license_plates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_license_plates.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_license_plates.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_license_plates.Location = new System.Drawing.Point(177, 158);
            this.txt_license_plates.Margin = new System.Windows.Forms.Padding(4);
            this.txt_license_plates.Name = "txt_license_plates";
            this.txt_license_plates.Size = new System.Drawing.Size(197, 27);
            this.txt_license_plates.TabIndex = 3;
            // 
            // gb_range
            // 
            this.gb_range.Controls.Add(this.rb_outpark);
            this.gb_range.Controls.Add(this.rb_inpark);
            this.gb_range.Controls.Add(this.rb_all_range);
            this.gb_range.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_range.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.gb_range.Location = new System.Drawing.Point(803, 112);
            this.gb_range.Margin = new System.Windows.Forms.Padding(4);
            this.gb_range.Name = "gb_range";
            this.gb_range.Padding = new System.Windows.Forms.Padding(4);
            this.gb_range.Size = new System.Drawing.Size(463, 84);
            this.gb_range.TabIndex = 5;
            this.gb_range.TabStop = false;
            this.gb_range.Text = "Phạm vi";
            // 
            // txt_fullname
            // 
            this.txt_fullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txt_fullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_fullname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fullname.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_fullname.Location = new System.Drawing.Point(177, 39);
            this.txt_fullname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(197, 27);
            this.txt_fullname.TabIndex = 1;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_username.Location = new System.Drawing.Point(177, 94);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(197, 27);
            this.txt_username.TabIndex = 2;
            // 
            // lb_ownername
            // 
            this.lb_ownername.AutoSize = true;
            this.lb_ownername.Location = new System.Drawing.Point(32, 99);
            this.lb_ownername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ownername.Name = "lb_ownername";
            this.lb_ownername.Size = new System.Drawing.Size(127, 25);
            this.lb_ownername.TabIndex = 1;
            this.lb_ownername.Text = "Tên tài khoản";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(48, 40);
            this.lb_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(111, 25);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Tên chủ thẻ";
            // 
            // gb_search
            // 
            this.gb_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.gb_search.Controls.Add(this.btnAll);
            this.gb_search.Controls.Add(this.btnClear);
            this.gb_search.Controls.Add(this.btnSearch);
            this.gb_search.Controls.Add(this.gb_payment);
            this.gb_search.Controls.Add(this.gb_date);
            this.gb_search.Controls.Add(this.cb_date);
            this.gb_search.Controls.Add(this.lb_licenseplates);
            this.gb_search.Controls.Add(this.txt_license_plates);
            this.gb_search.Controls.Add(this.gb_range);
            this.gb_search.Controls.Add(this.txt_fullname);
            this.gb_search.Controls.Add(this.txt_username);
            this.gb_search.Controls.Add(this.lb_ownername);
            this.gb_search.Controls.Add(this.lb_username);
            this.gb_search.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.gb_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.gb_search.Location = new System.Drawing.Point(5, 15);
            this.gb_search.Margin = new System.Windows.Forms.Padding(4);
            this.gb_search.Name = "gb_search";
            this.gb_search.Padding = new System.Windows.Forms.Padding(4);
            this.gb_search.Size = new System.Drawing.Size(1461, 214);
            this.gb_search.TabIndex = 6;
            this.gb_search.TabStop = false;
            this.gb_search.Text = "Tìm kiếm";
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Transparent;
            this.btnAll.BackgroundImage = global::HeThongGiuXe.Properties.Resources.icons8_automatic_96;
            this.btnAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnAll.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnAll.Location = new System.Drawing.Point(1275, 150);
            this.btnAll.Margin = new System.Windows.Forms.Padding(5);
            this.btnAll.Name = "btnAll";
            this.btnAll.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnAll.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnAll.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAll.Size = new System.Drawing.Size(169, 49);
            this.btnAll.TabIndex = 5;
            this.btnAll.Text = "Xem tất cả";
            this.btnAll.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = global::HeThongGiuXe.Properties.Resources.icons8_automatic_96;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnClear.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnClear.Location = new System.Drawing.Point(1275, 91);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnClear.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnClear.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClear.Size = new System.Drawing.Size(169, 49);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Đặt lại";
            this.btnClear.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnSearch.Location = new System.Drawing.Point(1275, 26);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.Size = new System.Drawing.Size(169, 49);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbTodayStatistics
            // 
            this.gbTodayStatistics.Controls.Add(this.lbTodayCheckin);
            this.gbTodayStatistics.Controls.Add(this.lbTodayCheckout);
            this.gbTodayStatistics.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gbTodayStatistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.gbTodayStatistics.Location = new System.Drawing.Point(1069, 557);
            this.gbTodayStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.gbTodayStatistics.Name = "gbTodayStatistics";
            this.gbTodayStatistics.Padding = new System.Windows.Forms.Padding(4);
            this.gbTodayStatistics.Size = new System.Drawing.Size(397, 230);
            this.gbTodayStatistics.TabIndex = 8;
            this.gbTodayStatistics.TabStop = false;
            this.gbTodayStatistics.Text = "Thống kê hôm nay";
            // 
            // lbTodayCheckin
            // 
            this.lbTodayCheckin.AutoSize = true;
            this.lbTodayCheckin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTodayCheckin.Location = new System.Drawing.Point(45, 71);
            this.lbTodayCheckin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTodayCheckin.Name = "lbTodayCheckin";
            this.lbTodayCheckin.Size = new System.Drawing.Size(93, 28);
            this.lbTodayCheckin.TabIndex = 15;
            this.lbTodayCheckin.Text = "Xe vào  :";
            // 
            // lbTodayCheckout
            // 
            this.lbTodayCheckout.AutoSize = true;
            this.lbTodayCheckout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTodayCheckout.Location = new System.Drawing.Point(45, 150);
            this.lbTodayCheckout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTodayCheckout.Name = "lbTodayCheckout";
            this.lbTodayCheckout.Size = new System.Drawing.Size(78, 28);
            this.lbTodayCheckout.TabIndex = 15;
            this.lbTodayCheckout.Text = "Xe ra : ";
            // 
            // ManageVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1483, 791);
            this.Controls.Add(this.gbTodayStatistics);
            this.Controls.Add(this.gb_Thongke);
            this.Controls.Add(this.gb_vehicleresult);
            this.Controls.Add(this.gb_search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageVehicle";
            this.gb_Thongke.ResumeLayout(false);
            this.gb_Thongke.PerformLayout();
            this.gb_payment.ResumeLayout(false);
            this.gb_payment.PerformLayout();
            this.gb_vehicleresult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_list_vehicle)).EndInit();
            this.gb_date.ResumeLayout(false);
            this.gb_date.PerformLayout();
            this.gb_range.ResumeLayout(false);
            this.gb_range.PerformLayout();
            this.gb_search.ResumeLayout(false);
            this.gb_search.PerformLayout();
            this.gbTodayStatistics.ResumeLayout(false);
            this.gbTodayStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.GroupBox gb_Thongke;
        private DTO.RoundedButton btnAll;
        private DTO.RoundedButton btnClear;
        private DTO.RoundedButton btnSearch;
        private System.Windows.Forms.GroupBox gb_payment;
        private System.Windows.Forms.RadioButton rb_isnt_payment;
        private System.Windows.Forms.RadioButton rb_is_payment;
        private System.Windows.Forms.RadioButton rb_all_payment;
        private System.Windows.Forms.GroupBox gb_vehicleresult;
        private System.Windows.Forms.DataGridView dtgv_list_vehicle;
        private System.Windows.Forms.RadioButton rb_inpark;
        private System.Windows.Forms.RadioButton rb_all_range;
        private System.Windows.Forms.GroupBox gb_date;
        private System.Windows.Forms.DateTimePicker dtp_start_day;
        private System.Windows.Forms.DateTimePicker dtp_end_day;
        private System.Windows.Forms.Label lb_endday;
        private System.Windows.Forms.Label lb_startday;
        private System.Windows.Forms.RadioButton rb_outpark;
        private System.Windows.Forms.CheckBox cb_date;
        private System.Windows.Forms.Label lb_licenseplates;
        private System.Windows.Forms.TextBox txt_license_plates;
        private System.Windows.Forms.GroupBox gb_range;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lb_ownername;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.GroupBox gb_search;
        private System.Windows.Forms.Label lbTotalInPark;
        private System.Windows.Forms.Label lbTotalUnpaid;
        private System.Windows.Forms.Label lbTotalPaid;
        private System.Windows.Forms.GroupBox gbTodayStatistics;
        private System.Windows.Forms.Label lbTodayCheckin;
        private System.Windows.Forms.Label lbTodayCheckout;
    }
}