
namespace HeThongGiuXe.View
{
    partial class PaymentManagementForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgv_payment = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtgv_package = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgv_search = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rb_student_id = new System.Windows.Forms.RadioButton();
            this.rb_name = new System.Windows.Forms.RadioButton();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_payment)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_package)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_search)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgv_payment);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1363, 626);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dtgv_payment
            // 
            this.dtgv_payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_payment.Location = new System.Drawing.Point(687, 42);
            this.dtgv_payment.Name = "dtgv_payment";
            this.dtgv_payment.RowHeadersWidth = 51;
            this.dtgv_payment.RowTemplate.Height = 24;
            this.dtgv_payment.Size = new System.Drawing.Size(652, 135);
            this.dtgv_payment.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtgv_package);
            this.groupBox5.Location = new System.Drawing.Point(675, 240);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(682, 386);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Các gói gửi xe";
            // 
            // dtgv_package
            // 
            this.dtgv_package.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_package.Location = new System.Drawing.Point(6, 21);
            this.dtgv_package.MultiSelect = false;
            this.dtgv_package.Name = "dtgv_package";
            this.dtgv_package.ReadOnly = true;
            this.dtgv_package.RowHeadersWidth = 51;
            this.dtgv_package.RowTemplate.Height = 24;
            this.dtgv_package.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_package.Size = new System.Drawing.Size(670, 347);
            this.dtgv_package.TabIndex = 1;
            this.dtgv_package.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtgv_package_MouseDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgv_search);
            this.groupBox4.Location = new System.Drawing.Point(16, 234);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(588, 386);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kết quả tìm kiếm";
            // 
            // dtgv_search
            // 
            this.dtgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_search.Location = new System.Drawing.Point(6, 33);
            this.dtgv_search.MultiSelect = false;
            this.dtgv_search.Name = "dtgv_search";
            this.dtgv_search.ReadOnly = true;
            this.dtgv_search.RowHeadersWidth = 51;
            this.dtgv_search.RowTemplate.Height = 24;
            this.dtgv_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_search.Size = new System.Drawing.Size(576, 347);
            this.dtgv_search.TabIndex = 0;
            this.dtgv_search.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtgv_search_MouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_purchase);
            this.groupBox3.Location = new System.Drawing.Point(675, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(670, 213);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thanh toán";
            // 
            // btn_purchase
            // 
            this.btn_purchase.Location = new System.Drawing.Point(306, 178);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(113, 29);
            this.btn_purchase.TabIndex = 0;
            this.btn_purchase.Text = "Xác nhận";
            this.btn_purchase.UseVisualStyleBackColor = true;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.Location = new System.Drawing.Point(16, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 213);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rb_student_id);
            this.groupBox6.Controls.Add(this.rb_name);
            this.groupBox6.Location = new System.Drawing.Point(37, 88);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 57);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            // 
            // rb_student_id
            // 
            this.rb_student_id.AutoSize = true;
            this.rb_student_id.Checked = true;
            this.rb_student_id.Location = new System.Drawing.Point(24, 21);
            this.rb_student_id.Name = "rb_student_id";
            this.rb_student_id.Size = new System.Drawing.Size(67, 21);
            this.rb_student_id.TabIndex = 2;
            this.rb_student_id.TabStop = true;
            this.rb_student_id.Text = "MSSV";
            this.rb_student_id.UseVisualStyleBackColor = true;
            // 
            // rb_name
            // 
            this.rb_name.AutoSize = true;
            this.rb_name.Location = new System.Drawing.Point(125, 21);
            this.rb_name.Name = "rb_name";
            this.rb_name.Size = new System.Drawing.Size(54, 21);
            this.rb_name.TabIndex = 3;
            this.rb_name.Text = "Tên";
            this.rb_name.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.rb_name.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(422, 46);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(37, 46);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(341, 22);
            this.txt_search.TabIndex = 0;
            // 
            // PaymentManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 650);
            this.Controls.Add(this.groupBox1);
            this.Name = "PaymentManagementForm";
            this.Text = "PaymentManagement";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_payment)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_package)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_search)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_name;
        private System.Windows.Forms.RadioButton rb_student_id;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtgv_search;
        private System.Windows.Forms.DataGridView dtgv_payment;
        private System.Windows.Forms.DataGridView dtgv_package;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}