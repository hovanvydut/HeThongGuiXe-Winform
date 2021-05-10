
namespace HeThongGiuXe.View.ManageUnitPriceForm
{
    partial class ManageUnitPrice
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
            this.groupDayPrice = new System.Windows.Forms.GroupBox();
            this.tableDayPrice = new System.Windows.Forms.DataGridView();
            this.groupSpecicalTime = new System.Windows.Forms.GroupBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupDayPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDayPrice)).BeginInit();
            this.groupSpecicalTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDayPrice
            // 
            this.groupDayPrice.Controls.Add(this.btnSaveChange);
            this.groupDayPrice.Controls.Add(this.cbDay);
            this.groupDayPrice.Controls.Add(this.tableDayPrice);
            this.groupDayPrice.Location = new System.Drawing.Point(25, 28);
            this.groupDayPrice.Name = "groupDayPrice";
            this.groupDayPrice.Size = new System.Drawing.Size(338, 479);
            this.groupDayPrice.TabIndex = 0;
            this.groupDayPrice.TabStop = false;
            this.groupDayPrice.Text = "Đơn giá hàng ngày";
            // 
            // tableDayPrice
            // 
            this.tableDayPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDayPrice.Location = new System.Drawing.Point(25, 90);
            this.tableDayPrice.Name = "tableDayPrice";
            this.tableDayPrice.RowHeadersWidth = 51;
            this.tableDayPrice.RowTemplate.Height = 24;
            this.tableDayPrice.Size = new System.Drawing.Size(289, 363);
            this.tableDayPrice.TabIndex = 0;
            // 
            // groupSpecicalTime
            // 
            this.groupSpecicalTime.Controls.Add(this.button4);
            this.groupSpecicalTime.Controls.Add(this.button3);
            this.groupSpecicalTime.Controls.Add(this.button2);
            this.groupSpecicalTime.Controls.Add(this.button1);
            this.groupSpecicalTime.Controls.Add(this.dateTimePicker3);
            this.groupSpecicalTime.Controls.Add(this.dateTimePicker4);
            this.groupSpecicalTime.Controls.Add(this.dateTimePicker2);
            this.groupSpecicalTime.Controls.Add(this.dateTimePicker1);
            this.groupSpecicalTime.Controls.Add(this.textBox1);
            this.groupSpecicalTime.Controls.Add(this.label5);
            this.groupSpecicalTime.Controls.Add(this.label3);
            this.groupSpecicalTime.Controls.Add(this.label4);
            this.groupSpecicalTime.Controls.Add(this.label2);
            this.groupSpecicalTime.Controls.Add(this.label1);
            this.groupSpecicalTime.Controls.Add(this.dataGridView1);
            this.groupSpecicalTime.Location = new System.Drawing.Point(411, 33);
            this.groupSpecicalTime.Name = "groupSpecicalTime";
            this.groupSpecicalTime.Size = new System.Drawing.Size(338, 474);
            this.groupSpecicalTime.TabIndex = 1;
            this.groupSpecicalTime.TabStop = false;
            this.groupSpecicalTime.Text = "Giá thời gian đặt biệt";
            // 
            // cbDay
            // 
            this.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Items.AddRange(new object[] {
            "Thứ 2",
            "Thứ 3",
            "Thứ 4",
            "Thứ 5",
            "Thứ 6",
            "Thứ 7",
            "Chủ nhật"});
            this.cbDay.Location = new System.Drawing.Point(35, 46);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(137, 24);
            this.cbDay.TabIndex = 1;
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.Location = new System.Drawing.Point(193, 46);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(121, 24);
            this.btnSaveChange.TabIndex = 2;
            this.btnSaveChange.Text = "Lưu thay đổi";
            this.btnSaveChange.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(300, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày bắt đầu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đơn giá";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 22);
            this.textBox1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(129, 32);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(192, 22);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(126, 168);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(192, 22);
            this.dateTimePicker3.TabIndex = 10;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(126, 190);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(192, 22);
            this.dateTimePicker4.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(225, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Xoá";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(124, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ManageUnitPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 519);
            this.Controls.Add(this.groupSpecicalTime);
            this.Controls.Add(this.groupDayPrice);
            this.Name = "ManageUnitPrice";
            this.Text = "Quản lí đơn giá";
            this.groupDayPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableDayPrice)).EndInit();
            this.groupSpecicalTime.ResumeLayout(false);
            this.groupSpecicalTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDayPrice;
        private System.Windows.Forms.DataGridView tableDayPrice;
        private System.Windows.Forms.GroupBox groupSpecicalTime;
        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}