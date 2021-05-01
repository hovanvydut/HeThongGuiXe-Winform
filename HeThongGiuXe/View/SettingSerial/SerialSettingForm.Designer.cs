
namespace HeThongGiuXe
{
    partial class SerialSettingForm
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
            this.lbPort = new System.Windows.Forms.Label();
            this.lbBaund = new System.Windows.Forms.Label();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.txtBaund = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(12, 46);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(99, 17);
            this.lbPort.TabIndex = 0;
            this.lbPort.Text = "Cổng giao tiếp";
            // 
            // lbBaund
            // 
            this.lbBaund.AutoSize = true;
            this.lbBaund.Location = new System.Drawing.Point(12, 81);
            this.lbBaund.Name = "lbBaund";
            this.lbBaund.Size = new System.Drawing.Size(49, 17);
            this.lbBaund.TabIndex = 1;
            this.lbBaund.Text = "Baund";
            // 
            // cbPorts
            // 
            this.cbPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(133, 46);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(121, 24);
            this.cbPorts.TabIndex = 2;
            // 
            // txtBaund
            // 
            this.txtBaund.Location = new System.Drawing.Point(133, 81);
            this.txtBaund.Name = "txtBaund";
            this.txtBaund.Size = new System.Drawing.Size(121, 22);
            this.txtBaund.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(51, 125);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(160, 125);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SerialSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 176);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtBaund);
            this.Controls.Add(this.cbPorts);
            this.Controls.Add(this.lbBaund);
            this.Controls.Add(this.lbPort);
            this.Name = "SerialSettingForm";
            this.Text = "Cài đặt giao tiếp serial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lbBaund;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.TextBox txtBaund;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}