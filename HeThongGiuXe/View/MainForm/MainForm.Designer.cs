
namespace HeThongGiuXe
{
    partial class MainForm
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
            this.btnCheckin = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnParkingManagement = new System.Windows.Forms.Button();
            this.btnGeneralManagement = new System.Windows.Forms.Button();
            this.imgDUT = new System.Windows.Forms.PictureBox();
            this.imgSgroup = new System.Windows.Forms.PictureBox();
            this.imgIT = new System.Windows.Forms.PictureBox();
            this.lbHeader1 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgDUT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSgroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckin
            // 
            this.btnCheckin.Location = new System.Drawing.Point(115, 237);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(235, 69);
            this.btnCheckin.TabIndex = 0;
            this.btnCheckin.Text = "Quản lí xe vào";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(422, 237);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(235, 69);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "Quản lí xe ra";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnParkingManagement
            // 
            this.btnParkingManagement.Location = new System.Drawing.Point(115, 332);
            this.btnParkingManagement.Name = "btnParkingManagement";
            this.btnParkingManagement.Size = new System.Drawing.Size(235, 69);
            this.btnParkingManagement.TabIndex = 2;
            this.btnParkingManagement.Text = "Quản lí xe trong bãi";
            this.btnParkingManagement.UseVisualStyleBackColor = true;
            this.btnParkingManagement.Click += new System.EventHandler(this.btnParkingManagement_Click);
            // 
            // btnGeneralManagement
            // 
            this.btnGeneralManagement.Location = new System.Drawing.Point(422, 332);
            this.btnGeneralManagement.Name = "btnGeneralManagement";
            this.btnGeneralManagement.Size = new System.Drawing.Size(235, 69);
            this.btnGeneralManagement.TabIndex = 3;
            this.btnGeneralManagement.Text = "Quản lí - thống kê";
            this.btnGeneralManagement.UseVisualStyleBackColor = true;
            this.btnGeneralManagement.Click += new System.EventHandler(this.btnGeneralManagement_Click);
            // 
            // imgDUT
            // 
            this.imgDUT.BackgroundImage = global::HeThongGiuXe.Properties.Resources.Logo_DUT;
            this.imgDUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgDUT.Location = new System.Drawing.Point(229, 12);
            this.imgDUT.Name = "imgDUT";
            this.imgDUT.Size = new System.Drawing.Size(73, 67);
            this.imgDUT.TabIndex = 4;
            this.imgDUT.TabStop = false;
            // 
            // imgSgroup
            // 
            this.imgSgroup.BackgroundImage = global::HeThongGiuXe.Properties.Resources.Logo_Sgroup;
            this.imgSgroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgSgroup.Location = new System.Drawing.Point(455, 12);
            this.imgSgroup.Name = "imgSgroup";
            this.imgSgroup.Size = new System.Drawing.Size(73, 67);
            this.imgSgroup.TabIndex = 5;
            this.imgSgroup.TabStop = false;
            // 
            // imgIT
            // 
            this.imgIT.BackgroundImage = global::HeThongGiuXe.Properties.Resources.Logo_IT;
            this.imgIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgIT.Location = new System.Drawing.Point(345, 12);
            this.imgIT.Name = "imgIT";
            this.imgIT.Size = new System.Drawing.Size(73, 67);
            this.imgIT.TabIndex = 6;
            this.imgIT.TabStop = false;
            // 
            // lbHeader1
            // 
            this.lbHeader1.AutoSize = true;
            this.lbHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbHeader1.Location = new System.Drawing.Point(340, 126);
            this.lbHeader1.Name = "lbHeader1";
            this.lbHeader1.Size = new System.Drawing.Size(91, 29);
            this.lbHeader1.TabIndex = 7;
            this.lbHeader1.Text = "DỰ ÁN";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Orange;
            this.lbName.Location = new System.Drawing.Point(103, 165);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(585, 29);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "HỆ THỐNG QUẢN LÍ BÃI ĐỖ XE MÁY SINH VIÊN";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 435);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbHeader1);
            this.Controls.Add(this.imgIT);
            this.Controls.Add(this.imgSgroup);
            this.Controls.Add(this.imgDUT);
            this.Controls.Add(this.btnGeneralManagement);
            this.Controls.Add(this.btnParkingManagement);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnCheckin);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lựa chọn tác vụ";
            ((System.ComponentModel.ISupportInitialize)(this.imgDUT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSgroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnParkingManagement;
        private System.Windows.Forms.Button btnGeneralManagement;
        private System.Windows.Forms.PictureBox imgDUT;
        private System.Windows.Forms.PictureBox imgSgroup;
        private System.Windows.Forms.PictureBox imgIT;
        private System.Windows.Forms.Label lbHeader1;
        private System.Windows.Forms.Label lbName;
    }
}

