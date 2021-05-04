
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
            this.dtp_endday = new System.Windows.Forms.DateTimePicker();
            this.dtp_startday = new System.Windows.Forms.DateTimePicker();
            this.txt_cardnumber = new System.Windows.Forms.TextBox();
            this.txt_ownername = new System.Windows.Forms.TextBox();
            this.txt_licenseplates = new System.Windows.Forms.TextBox();
            this.lb_ownername = new System.Windows.Forms.Label();
            this.lb_licenseplates = new System.Windows.Forms.Label();
            this.lb_startday = new System.Windows.Forms.Label();
            this.lb_endday = new System.Windows.Forms.Label();
            this.lb_cardnumber = new System.Windows.Forms.Label();
            this.gb_range = new System.Windows.Forms.GroupBox();
            this.rb_All = new System.Windows.Forms.RadioButton();
            this.rb_inpark = new System.Windows.Forms.RadioButton();
            this.rb_outpark = new System.Windows.Forms.RadioButton();
            this.btn_search = new System.Windows.Forms.Button();
            this.gb_info = new System.Windows.Forms.GroupBox();
            this.dtgv_infor = new System.Windows.Forms.DataGridView();
            this.gb_search.SuspendLayout();
            this.gb_range.SuspendLayout();
            this.gb_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_infor)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_search
            // 
            this.gb_search.Controls.Add(this.btn_search);
            this.gb_search.Controls.Add(this.gb_range);
            this.gb_search.Controls.Add(this.dtp_endday);
            this.gb_search.Controls.Add(this.dtp_startday);
            this.gb_search.Controls.Add(this.txt_cardnumber);
            this.gb_search.Controls.Add(this.txt_ownername);
            this.gb_search.Controls.Add(this.txt_licenseplates);
            this.gb_search.Controls.Add(this.lb_ownername);
            this.gb_search.Controls.Add(this.lb_licenseplates);
            this.gb_search.Controls.Add(this.lb_startday);
            this.gb_search.Controls.Add(this.lb_endday);
            this.gb_search.Controls.Add(this.lb_cardnumber);
            this.gb_search.Location = new System.Drawing.Point(12, 12);
            this.gb_search.Name = "gb_search";
            this.gb_search.Size = new System.Drawing.Size(818, 160);
            this.gb_search.TabIndex = 0;
            this.gb_search.TabStop = false;
            this.gb_search.Text = "Tìm kiếm";
            // 
            // dtp_endday
            // 
            this.dtp_endday.Location = new System.Drawing.Point(372, 61);
            this.dtp_endday.Name = "dtp_endday";
            this.dtp_endday.Size = new System.Drawing.Size(212, 20);
            this.dtp_endday.TabIndex = 4;
            // 
            // dtp_startday
            // 
            this.dtp_startday.Location = new System.Drawing.Point(372, 25);
            this.dtp_startday.Name = "dtp_startday";
            this.dtp_startday.Size = new System.Drawing.Size(212, 20);
            this.dtp_startday.TabIndex = 4;
            // 
            // txt_cardnumber
            // 
            this.txt_cardnumber.Location = new System.Drawing.Point(133, 25);
            this.txt_cardnumber.Name = "txt_cardnumber";
            this.txt_cardnumber.Size = new System.Drawing.Size(148, 20);
            this.txt_cardnumber.TabIndex = 3;
            this.txt_cardnumber.Text = "Nhập nội dung";
            // 
            // txt_ownername
            // 
            this.txt_ownername.Location = new System.Drawing.Point(133, 125);
            this.txt_ownername.Name = "txt_ownername";
            this.txt_ownername.Size = new System.Drawing.Size(148, 20);
            this.txt_ownername.TabIndex = 3;
            this.txt_ownername.Text = "Nhập nội dung";
            // 
            // txt_licenseplates
            // 
            this.txt_licenseplates.Location = new System.Drawing.Point(133, 74);
            this.txt_licenseplates.Name = "txt_licenseplates";
            this.txt_licenseplates.Size = new System.Drawing.Size(148, 20);
            this.txt_licenseplates.TabIndex = 3;
            this.txt_licenseplates.Text = "Nhập nội dung";
            // 
            // lb_ownername
            // 
            this.lb_ownername.AutoSize = true;
            this.lb_ownername.Location = new System.Drawing.Point(24, 132);
            this.lb_ownername.Name = "lb_ownername";
            this.lb_ownername.Size = new System.Drawing.Size(61, 13);
            this.lb_ownername.TabIndex = 1;
            this.lb_ownername.Text = "Tên chủ xe";
            // 
            // lb_licenseplates
            // 
            this.lb_licenseplates.AutoSize = true;
            this.lb_licenseplates.Location = new System.Drawing.Point(24, 77);
            this.lb_licenseplates.Name = "lb_licenseplates";
            this.lb_licenseplates.Size = new System.Drawing.Size(56, 13);
            this.lb_licenseplates.TabIndex = 1;
            this.lb_licenseplates.Text = "Biển số xe";
            // 
            // lb_startday
            // 
            this.lb_startday.AutoSize = true;
            this.lb_startday.Location = new System.Drawing.Point(313, 32);
            this.lb_startday.Name = "lb_startday";
            this.lb_startday.Size = new System.Drawing.Size(46, 13);
            this.lb_startday.TabIndex = 0;
            this.lb_startday.Text = "Từ ngày";
            // 
            // lb_endday
            // 
            this.lb_endday.AutoSize = true;
            this.lb_endday.Location = new System.Drawing.Point(313, 68);
            this.lb_endday.Name = "lb_endday";
            this.lb_endday.Size = new System.Drawing.Size(53, 13);
            this.lb_endday.TabIndex = 0;
            this.lb_endday.Text = "Đến ngày";
            // 
            // lb_cardnumber
            // 
            this.lb_cardnumber.AutoSize = true;
            this.lb_cardnumber.Location = new System.Drawing.Point(24, 32);
            this.lb_cardnumber.Name = "lb_cardnumber";
            this.lb_cardnumber.Size = new System.Drawing.Size(38, 13);
            this.lb_cardnumber.TabIndex = 0;
            this.lb_cardnumber.Text = "Số thẻ";
            // 
            // gb_range
            // 
            this.gb_range.Controls.Add(this.rb_outpark);
            this.gb_range.Controls.Add(this.rb_inpark);
            this.gb_range.Controls.Add(this.rb_All);
            this.gb_range.Location = new System.Drawing.Point(316, 100);
            this.gb_range.Name = "gb_range";
            this.gb_range.Size = new System.Drawing.Size(268, 54);
            this.gb_range.TabIndex = 5;
            this.gb_range.TabStop = false;
            this.gb_range.Text = "Phạm vi";
            // 
            // rb_All
            // 
            this.rb_All.AutoSize = true;
            this.rb_All.Location = new System.Drawing.Point(6, 19);
            this.rb_All.Name = "rb_All";
            this.rb_All.Size = new System.Drawing.Size(56, 17);
            this.rb_All.TabIndex = 0;
            this.rb_All.TabStop = true;
            this.rb_All.Text = "Tất cả";
            this.rb_All.UseVisualStyleBackColor = true;
            // 
            // rb_inpark
            // 
            this.rb_inpark.AutoSize = true;
            this.rb_inpark.Location = new System.Drawing.Point(81, 19);
            this.rb_inpark.Name = "rb_inpark";
            this.rb_inpark.Size = new System.Drawing.Size(82, 17);
            this.rb_inpark.TabIndex = 0;
            this.rb_inpark.TabStop = true;
            this.rb_inpark.Text = "Xe trong bãi";
            this.rb_inpark.UseVisualStyleBackColor = true;
            // 
            // rb_outpark
            // 
            this.rb_outpark.AutoSize = true;
            this.rb_outpark.Location = new System.Drawing.Point(169, 19);
            this.rb_outpark.Name = "rb_outpark";
            this.rb_outpark.Size = new System.Drawing.Size(66, 17);
            this.rb_outpark.TabIndex = 0;
            this.rb_outpark.TabStop = true;
            this.rb_outpark.Text = "Xe đã ra";
            this.rb_outpark.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(652, 25);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // gb_info
            // 
            this.gb_info.Controls.Add(this.dtgv_infor);
            this.gb_info.Location = new System.Drawing.Point(13, 194);
            this.gb_info.Name = "gb_info";
            this.gb_info.Size = new System.Drawing.Size(817, 223);
            this.gb_info.TabIndex = 1;
            this.gb_info.TabStop = false;
            this.gb_info.Text = "Thông tin";
            // 
            // dtgv_infor
            // 
            this.dtgv_infor.AllowUserToAddRows = false;
            this.dtgv_infor.AllowUserToDeleteRows = false;
            this.dtgv_infor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_infor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_infor.Location = new System.Drawing.Point(3, 16);
            this.dtgv_infor.Name = "dtgv_infor";
            this.dtgv_infor.ReadOnly = true;
            this.dtgv_infor.Size = new System.Drawing.Size(811, 204);
            this.dtgv_infor.TabIndex = 0;
          
            // 
            // ManageVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.gb_info);
            this.Controls.Add(this.gb_search);
            this.Name = "ManageVehicle";
            this.Text = "ManageVehicle";
            this.gb_search.ResumeLayout(false);
            this.gb_search.PerformLayout();
            this.gb_range.ResumeLayout(false);
            this.gb_range.PerformLayout();
            this.gb_info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_infor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_search;
        private System.Windows.Forms.DateTimePicker dtp_endday;
        private System.Windows.Forms.DateTimePicker dtp_startday;
        private System.Windows.Forms.TextBox txt_licenseplates;
        private System.Windows.Forms.Label lb_licenseplates;
        private System.Windows.Forms.Label lb_startday;
        private System.Windows.Forms.Label lb_endday;
        private System.Windows.Forms.Label lb_cardnumber;
        private System.Windows.Forms.TextBox txt_cardnumber;
        private System.Windows.Forms.Label lb_ownername;
        private System.Windows.Forms.TextBox txt_ownername;
        private System.Windows.Forms.GroupBox gb_range;
        private System.Windows.Forms.RadioButton rb_outpark;
        private System.Windows.Forms.RadioButton rb_inpark;
        private System.Windows.Forms.RadioButton rb_All;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.GroupBox gb_info;
        private System.Windows.Forms.DataGridView dtgv_infor;
    }
}