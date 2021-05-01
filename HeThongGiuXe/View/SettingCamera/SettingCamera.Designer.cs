
namespace HeThongGiuXe
{
    partial class SettingCamera
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
            this.lbCameraSelect = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCacel = new System.Windows.Forms.Button();
            this.txtCamera = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbCameraSelect
            // 
            this.lbCameraSelect.AutoSize = true;
            this.lbCameraSelect.Location = new System.Drawing.Point(17, 24);
            this.lbCameraSelect.Name = "lbCameraSelect";
            this.lbCameraSelect.Size = new System.Drawing.Size(55, 17);
            this.lbCameraSelect.TabIndex = 0;
            this.lbCameraSelect.Text = "Thiết bị";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(63, 76);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCacel
            // 
            this.btnCacel.Location = new System.Drawing.Point(165, 76);
            this.btnCacel.Name = "btnCacel";
            this.btnCacel.Size = new System.Drawing.Size(75, 23);
            this.btnCacel.TabIndex = 3;
            this.btnCacel.Text = "Huỷ";
            this.btnCacel.UseVisualStyleBackColor = true;
            this.btnCacel.Click += new System.EventHandler(this.btnCacel_Click);
            // 
            // txtCamera
            // 
            this.txtCamera.Location = new System.Drawing.Point(94, 24);
            this.txtCamera.Name = "txtCamera";
            this.txtCamera.Size = new System.Drawing.Size(184, 22);
            this.txtCamera.TabIndex = 4;
            this.txtCamera.Text = "0";
            // 
            // SettingCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 126);
            this.Controls.Add(this.txtCamera);
            this.Controls.Add(this.btnCacel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbCameraSelect);
            this.Name = "SettingCamera";
            this.Text = "Cài đặt camera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCameraSelect;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCacel;
        private System.Windows.Forms.TextBox txtCamera;
    }
}