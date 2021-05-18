
namespace HeThongGiuXe.View
{
    partial class PaymentForm
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
            this.lbPayment = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPayment
            // 
            this.lbPayment.AutoSize = true;
            this.lbPayment.Location = new System.Drawing.Point(102, 21);
            this.lbPayment.Name = "lbPayment";
            this.lbPayment.Size = new System.Drawing.Size(132, 17);
            this.lbPayment.TabIndex = 0;
            this.lbPayment.Text = "Bạn cần thanh toán";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Red;
            this.txtPrice.Location = new System.Drawing.Point(67, 55);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(195, 30);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(105, 112);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 28);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Đã thanh toán";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // PaymentForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 180);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lbPayment);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPayment;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnOK;
    }
}