
namespace HeThongGiuXe.View
{
    partial class CheckinForm
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
            this.groupCamera = new System.Windows.Forms.GroupBox();
            this.imgCamera = new System.Windows.Forms.PictureBox();
            this.groupExtractInfo = new System.Windows.Forms.GroupBox();
            this.groupPlateInfo = new System.Windows.Forms.GroupBox();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.groupCardInfo = new System.Windows.Forms.GroupBox();
            this.groupControl = new System.Windows.Forms.GroupBox();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.groupControlSOS = new System.Windows.Forms.GroupBox();
            this.groupConfirmControl = new System.Windows.Forms.GroupBox();
            this.groupManageControll = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnFilterWithCard = new System.Windows.Forms.Button();
            this.btnFilterWithPlate = new System.Windows.Forms.Button();
            this.btlGetAllInPark = new System.Windows.Forms.Button();
            this.tableVehicleInPark = new System.Windows.Forms.DataGridView();
            this.groupCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).BeginInit();
            this.groupExtractInfo.SuspendLayout();
            this.groupPlateInfo.SuspendLayout();
            this.groupCardInfo.SuspendLayout();
            this.groupControl.SuspendLayout();
            this.groupControlSOS.SuspendLayout();
            this.groupConfirmControl.SuspendLayout();
            this.groupManageControll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableVehicleInPark)).BeginInit();
            this.SuspendLayout();
            // 
            // groupCamera
            // 
            this.groupCamera.Controls.Add(this.imgCamera);
            this.groupCamera.Location = new System.Drawing.Point(22, 13);
            this.groupCamera.Name = "groupCamera";
            this.groupCamera.Size = new System.Drawing.Size(706, 484);
            this.groupCamera.TabIndex = 0;
            this.groupCamera.TabStop = false;
            this.groupCamera.Text = "Camera";
            // 
            // imgCamera
            // 
            this.imgCamera.Location = new System.Drawing.Point(19, 22);
            this.imgCamera.Name = "imgCamera";
            this.imgCamera.Size = new System.Drawing.Size(661, 444);
            this.imgCamera.TabIndex = 0;
            this.imgCamera.TabStop = false;
            // 
            // groupExtractInfo
            // 
            this.groupExtractInfo.Controls.Add(this.groupPlateInfo);
            this.groupExtractInfo.Controls.Add(this.groupCardInfo);
            this.groupExtractInfo.Location = new System.Drawing.Point(22, 520);
            this.groupExtractInfo.Name = "groupExtractInfo";
            this.groupExtractInfo.Size = new System.Drawing.Size(706, 230);
            this.groupExtractInfo.TabIndex = 1;
            this.groupExtractInfo.TabStop = false;
            this.groupExtractInfo.Text = "Trích xuất thông tin";
            // 
            // groupPlateInfo
            // 
            this.groupPlateInfo.Controls.Add(this.txtPlate);
            this.groupPlateInfo.Location = new System.Drawing.Point(361, 31);
            this.groupPlateInfo.Name = "groupPlateInfo";
            this.groupPlateInfo.Size = new System.Drawing.Size(319, 183);
            this.groupPlateInfo.TabIndex = 1;
            this.groupPlateInfo.TabStop = false;
            this.groupPlateInfo.Text = "Thông tin biển số";
            // 
            // txtPlate
            // 
            this.txtPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlate.Location = new System.Drawing.Point(18, 63);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(286, 41);
            this.txtPlate.TabIndex = 0;
            this.txtPlate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupCardInfo
            // 
            this.groupCardInfo.Controls.Add(this.txtCard);
            this.groupCardInfo.Location = new System.Drawing.Point(19, 31);
            this.groupCardInfo.Name = "groupCardInfo";
            this.groupCardInfo.Size = new System.Drawing.Size(317, 183);
            this.groupCardInfo.TabIndex = 0;
            this.groupCardInfo.TabStop = false;
            this.groupCardInfo.Text = "Thông tin thẻ";
            // 
            // groupControl
            // 
            this.groupControl.Controls.Add(this.groupManageControll);
            this.groupControl.Controls.Add(this.groupConfirmControl);
            this.groupControl.Controls.Add(this.groupControlSOS);
            this.groupControl.Location = new System.Drawing.Point(759, 25);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(578, 725);
            this.groupControl.TabIndex = 2;
            this.groupControl.TabStop = false;
            this.groupControl.Text = "Điều khiển";
            // 
            // txtCard
            // 
            this.txtCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCard.Location = new System.Drawing.Point(15, 63);
            this.txtCard.Name = "txtCard";
            this.txtCard.ReadOnly = true;
            this.txtCard.Size = new System.Drawing.Size(286, 41);
            this.txtCard.TabIndex = 1;
            this.txtCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupControlSOS
            // 
            this.groupControlSOS.Controls.Add(this.btnClose);
            this.groupControlSOS.Controls.Add(this.btnOpen);
            this.groupControlSOS.Location = new System.Drawing.Point(30, 41);
            this.groupControlSOS.Name = "groupControlSOS";
            this.groupControlSOS.Size = new System.Drawing.Size(531, 112);
            this.groupControlSOS.TabIndex = 0;
            this.groupControlSOS.TabStop = false;
            this.groupControlSOS.Text = "Điều khiển gấp";
            // 
            // groupConfirmControl
            // 
            this.groupConfirmControl.Controls.Add(this.btnConfirm);
            this.groupConfirmControl.Location = new System.Drawing.Point(30, 183);
            this.groupConfirmControl.Name = "groupConfirmControl";
            this.groupConfirmControl.Size = new System.Drawing.Size(531, 152);
            this.groupConfirmControl.TabIndex = 1;
            this.groupConfirmControl.TabStop = false;
            this.groupConfirmControl.Text = "Xác nhận xe";
            // 
            // groupManageControll
            // 
            this.groupManageControll.Controls.Add(this.tableVehicleInPark);
            this.groupManageControll.Controls.Add(this.btlGetAllInPark);
            this.groupManageControll.Controls.Add(this.btnFilterWithPlate);
            this.groupManageControll.Controls.Add(this.btnFilterWithCard);
            this.groupManageControll.Location = new System.Drawing.Point(30, 369);
            this.groupManageControll.Name = "groupManageControll";
            this.groupManageControll.Size = new System.Drawing.Size(531, 340);
            this.groupManageControll.TabIndex = 2;
            this.groupManageControll.TabStop = false;
            this.groupManageControll.Text = "Quản lí";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(36, 32);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(202, 53);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Mở cổng";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(299, 32);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(202, 53);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Đóng cổng";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(36, 55);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(202, 53);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Xác nhận xe vào";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnFilterWithCard
            // 
            this.btnFilterWithCard.Location = new System.Drawing.Point(15, 43);
            this.btnFilterWithCard.Name = "btnFilterWithCard";
            this.btnFilterWithCard.Size = new System.Drawing.Size(149, 42);
            this.btnFilterWithCard.TabIndex = 0;
            this.btnFilterWithCard.Text = "Xem theo thẻ";
            this.btnFilterWithCard.UseVisualStyleBackColor = true;
            // 
            // btnFilterWithPlate
            // 
            this.btnFilterWithPlate.Location = new System.Drawing.Point(201, 43);
            this.btnFilterWithPlate.Name = "btnFilterWithPlate";
            this.btnFilterWithPlate.Size = new System.Drawing.Size(149, 42);
            this.btnFilterWithPlate.TabIndex = 1;
            this.btnFilterWithPlate.Text = "Xem theo biển số";
            this.btnFilterWithPlate.UseVisualStyleBackColor = true;
            // 
            // btlGetAllInPark
            // 
            this.btlGetAllInPark.Location = new System.Drawing.Point(376, 43);
            this.btlGetAllInPark.Name = "btlGetAllInPark";
            this.btlGetAllInPark.Size = new System.Drawing.Size(149, 42);
            this.btlGetAllInPark.TabIndex = 2;
            this.btlGetAllInPark.Text = "Xem xe tỏng bãi";
            this.btlGetAllInPark.UseVisualStyleBackColor = true;
            // 
            // tableVehicleInPark
            // 
            this.tableVehicleInPark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableVehicleInPark.Location = new System.Drawing.Point(15, 144);
            this.tableVehicleInPark.Name = "tableVehicleInPark";
            this.tableVehicleInPark.RowHeadersWidth = 51;
            this.tableVehicleInPark.RowTemplate.Height = 24;
            this.tableVehicleInPark.Size = new System.Drawing.Size(497, 177);
            this.tableVehicleInPark.TabIndex = 3;
            // 
            // CheckinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 772);
            this.Controls.Add(this.groupControl);
            this.Controls.Add(this.groupExtractInfo);
            this.Controls.Add(this.groupCamera);
            this.Name = "CheckinForm";
            this.Text = "Điều khiển xe vào";
            this.groupCamera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).EndInit();
            this.groupExtractInfo.ResumeLayout(false);
            this.groupPlateInfo.ResumeLayout(false);
            this.groupPlateInfo.PerformLayout();
            this.groupCardInfo.ResumeLayout(false);
            this.groupCardInfo.PerformLayout();
            this.groupControl.ResumeLayout(false);
            this.groupControlSOS.ResumeLayout(false);
            this.groupConfirmControl.ResumeLayout(false);
            this.groupManageControll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableVehicleInPark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupCamera;
        private System.Windows.Forms.PictureBox imgCamera;
        private System.Windows.Forms.GroupBox groupExtractInfo;
        private System.Windows.Forms.GroupBox groupPlateInfo;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.GroupBox groupCardInfo;
        private System.Windows.Forms.GroupBox groupControl;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.GroupBox groupManageControll;
        private System.Windows.Forms.DataGridView tableVehicleInPark;
        private System.Windows.Forms.Button btlGetAllInPark;
        private System.Windows.Forms.Button btnFilterWithPlate;
        private System.Windows.Forms.Button btnFilterWithCard;
        private System.Windows.Forms.GroupBox groupConfirmControl;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox groupControlSOS;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
    }
}