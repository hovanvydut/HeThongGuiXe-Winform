
namespace HeThongGiuXe.View
{
    partial class PurchaseRegisteredPaymentForm
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
            this.btn_purchase = new System.Windows.Forms.Button();
            this.dtgv_purchase = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_purchase)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_purchase);
            this.groupBox1.Controls.Add(this.dtgv_purchase);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 438);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_purchase
            // 
            this.btn_purchase.Location = new System.Drawing.Point(425, 369);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(151, 43);
            this.btn_purchase.TabIndex = 1;
            this.btn_purchase.Text = "Thanh toán ngay";
            this.btn_purchase.UseVisualStyleBackColor = true;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // dtgv_purchase
            // 
            this.dtgv_purchase.AllowUserToAddRows = false;
            this.dtgv_purchase.AllowUserToDeleteRows = false;
            this.dtgv_purchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_purchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_purchase.Location = new System.Drawing.Point(12, 21);
            this.dtgv_purchase.Name = "dtgv_purchase";
            this.dtgv_purchase.ReadOnly = true;
            this.dtgv_purchase.RowHeadersVisible = false;
            this.dtgv_purchase.RowHeadersWidth = 51;
            this.dtgv_purchase.RowTemplate.Height = 24;
            this.dtgv_purchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_purchase.Size = new System.Drawing.Size(974, 281);
            this.dtgv_purchase.TabIndex = 0;
            // 
            // PurchaseRegisteredPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "PurchaseRegisteredPaymentForm";
            this.Text = "Danh sách các gói chưa thanh toán";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_purchase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgv_purchase;
        private System.Windows.Forms.Button btn_purchase;
    }
}