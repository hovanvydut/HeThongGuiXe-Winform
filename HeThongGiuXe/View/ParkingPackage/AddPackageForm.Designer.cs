
namespace HeThongGiuXe.View
{
    partial class AddPackageForm
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
            this.lb_duration = new System.Windows.Forms.Label();
            this.lb_description = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.check_visible = new System.Windows.Forms.CheckBox();
            this.txt_duration = new System.Windows.Forms.TextBox();
            this.rtxt_description = new System.Windows.Forms.RichTextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_duration);
            this.groupBox1.Controls.Add(this.lb_description);
            this.groupBox1.Controls.Add(this.lb_price);
            this.groupBox1.Controls.Add(this.lb_name);
            this.groupBox1.Controls.Add(this.check_visible);
            this.groupBox1.Controls.Add(this.txt_duration);
            this.groupBox1.Controls.Add(this.rtxt_description);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lb_duration
            // 
            this.lb_duration.AutoSize = true;
            this.lb_duration.Location = new System.Drawing.Point(427, 41);
            this.lb_duration.Name = "lb_duration";
            this.lb_duration.Size = new System.Drawing.Size(75, 17);
            this.lb_duration.TabIndex = 9;
            this.lb_duration.Text = "Thời lượng";
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.Location = new System.Drawing.Point(42, 131);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(43, 17);
            this.lb_description.TabIndex = 8;
            this.lb_description.Text = "Mô tả";
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Location = new System.Drawing.Point(42, 287);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(30, 17);
            this.lb_price.TabIndex = 7;
            this.lb_price.Text = "Giá";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(42, 41);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(33, 17);
            this.lb_name.TabIndex = 6;
            this.lb_name.Text = "Tên";
            // 
            // check_visible
            // 
            this.check_visible.AutoSize = true;
            this.check_visible.Checked = true;
            this.check_visible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_visible.Location = new System.Drawing.Point(430, 127);
            this.check_visible.Name = "check_visible";
            this.check_visible.Size = new System.Drawing.Size(71, 21);
            this.check_visible.TabIndex = 5;
            this.check_visible.Text = "Visible";
            this.check_visible.UseVisualStyleBackColor = true;
            // 
            // txt_duration
            // 
            this.txt_duration.Location = new System.Drawing.Point(430, 61);
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.Size = new System.Drawing.Size(100, 22);
            this.txt_duration.TabIndex = 4;
            this.txt_duration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_duration_KeyPress);
            // 
            // rtxt_description
            // 
            this.rtxt_description.Location = new System.Drawing.Point(45, 156);
            this.rtxt_description.Name = "rtxt_description";
            this.rtxt_description.Size = new System.Drawing.Size(242, 96);
            this.rtxt_description.TabIndex = 3;
            this.rtxt_description.Text = "";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(45, 321);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(242, 22);
            this.txt_price.TabIndex = 2;
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(45, 61);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(242, 22);
            this.txt_name.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_cancel);
            this.groupBox2.Controls.Add(this.btn_clear);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Location = new System.Drawing.Point(12, 422);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 140);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hành động";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(338, 70);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(186, 70);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(45, 70);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // AddPackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 597);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddPackageForm";
            this.Text = "Thêm mới gói gửi xe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_duration;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.CheckBox check_visible;
        private System.Windows.Forms.TextBox txt_duration;
        private System.Windows.Forms.RichTextBox rtxt_description;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_add;
    }
}