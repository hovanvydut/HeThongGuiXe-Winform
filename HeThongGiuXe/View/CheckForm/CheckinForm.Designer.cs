
namespace HeThongGiuXe
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
            this.components = new System.ComponentModel.Container();
            this.groupCamera = new System.Windows.Forms.GroupBox();
            this.imgCamera = new Emgu.CV.UI.ImageBox();
            this.groupExtractInfo = new System.Windows.Forms.GroupBox();
            this.groupPlateInfo = new System.Windows.Forms.GroupBox();
            this.btnTryGetPlate = new System.Windows.Forms.Button();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.groupCardInfo = new System.Windows.Forms.GroupBox();
            this.btnSetingSerial = new System.Windows.Forms.Button();
            this.lbStatusCard = new System.Windows.Forms.Label();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.groupControl = new System.Windows.Forms.GroupBox();
            this.groupManageControll = new System.Windows.Forms.GroupBox();
            this.tableVehicleInPark = new System.Windows.Forms.DataGridView();
            this.btlGetAllInPark = new System.Windows.Forms.Button();
            this.btnFilterWithPlate = new System.Windows.Forms.Button();
            this.btnFilterWithCard = new System.Windows.Forms.Button();
            this.groupConfirmControl = new System.Windows.Forms.GroupBox();
            this.checkAutoCheckin = new System.Windows.Forms.CheckBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupControlSOS = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).BeginInit();
            this.groupExtractInfo.SuspendLayout();
            this.groupPlateInfo.SuspendLayout();
            this.groupCardInfo.SuspendLayout();
            this.groupControl.SuspendLayout();
            this.groupManageControll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableVehicleInPark)).BeginInit();
            this.groupConfirmControl.SuspendLayout();
            this.groupControlSOS.SuspendLayout();
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
            this.imgCamera.Location = new System.Drawing.Point(30, 40);
            this.imgCamera.Name = "imgCamera";
            this.imgCamera.Size = new System.Drawing.Size(650, 400);
            this.imgCamera.TabIndex = 2;
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
            this.groupPlateInfo.Controls.Add(this.btnTryGetPlate);
            this.groupPlateInfo.Controls.Add(this.txtPlate);
            this.groupPlateInfo.Location = new System.Drawing.Point(361, 31);
            this.groupPlateInfo.Name = "groupPlateInfo";
            this.groupPlateInfo.Size = new System.Drawing.Size(319, 183);
            this.groupPlateInfo.TabIndex = 1;
            this.groupPlateInfo.TabStop = false;
            this.groupPlateInfo.Text = "Thông tin biển số";
            // 
            // btnTryGetPlate
            // 
            this.btnTryGetPlate.Location = new System.Drawing.Point(127, 126);
            this.btnTryGetPlate.Name = "btnTryGetPlate";
            this.btnTryGetPlate.Size = new System.Drawing.Size(75, 23);
            this.btnTryGetPlate.TabIndex = 1;
            this.btnTryGetPlate.Text = "Thử lại";
            this.btnTryGetPlate.UseVisualStyleBackColor = true;
            this.btnTryGetPlate.Click += new System.EventHandler(this.btnTryGetPlate_Click);
            // 
            // txtPlate
            // 
            this.txtPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlate.Location = new System.Drawing.Point(18, 63);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(286, 34);
            this.txtPlate.TabIndex = 0;
            this.txtPlate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPlate.TextChanged += new System.EventHandler(this.txtPlate_TextChanged);
            // 
            // groupCardInfo
            // 
            this.groupCardInfo.Controls.Add(this.btnSetingSerial);
            this.groupCardInfo.Controls.Add(this.lbStatusCard);
            this.groupCardInfo.Controls.Add(this.txtCard);
            this.groupCardInfo.Location = new System.Drawing.Point(19, 31);
            this.groupCardInfo.Name = "groupCardInfo";
            this.groupCardInfo.Size = new System.Drawing.Size(317, 183);
            this.groupCardInfo.TabIndex = 0;
            this.groupCardInfo.TabStop = false;
            this.groupCardInfo.Text = "Thông tin thẻ";
            // 
            // btnSetingSerial
            // 
            this.btnSetingSerial.BackgroundImage = global::HeThongGiuXe.Properties.Resources.settings_solid;
            this.btnSetingSerial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetingSerial.Location = new System.Drawing.Point(276, 63);
            this.btnSetingSerial.Name = "btnSetingSerial";
            this.btnSetingSerial.Size = new System.Drawing.Size(35, 34);
            this.btnSetingSerial.TabIndex = 2;
            this.btnSetingSerial.UseVisualStyleBackColor = true;
            this.btnSetingSerial.Click += new System.EventHandler(this.btnSetingSerial_Click);
            // 
            // lbStatusCard
            // 
            this.lbStatusCard.Location = new System.Drawing.Point(26, 132);
            this.lbStatusCard.Name = "lbStatusCard";
            this.lbStatusCard.Size = new System.Drawing.Size(263, 17);
            this.lbStatusCard.TabIndex = 1;
            this.lbStatusCard.Text = "...";
            this.lbStatusCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCard
            // 
            this.txtCard.Enabled = false;
            this.txtCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCard.Location = new System.Drawing.Point(12, 63);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(254, 34);
            this.txtCard.TabIndex = 1;
            this.txtCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // tableVehicleInPark
            // 
            this.tableVehicleInPark.AllowUserToAddRows = false;
            this.tableVehicleInPark.AllowUserToDeleteRows = false;
            this.tableVehicleInPark.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tableVehicleInPark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableVehicleInPark.Location = new System.Drawing.Point(15, 144);
            this.tableVehicleInPark.Name = "tableVehicleInPark";
            this.tableVehicleInPark.ReadOnly = true;
            this.tableVehicleInPark.RowHeadersWidth = 51;
            this.tableVehicleInPark.RowTemplate.Height = 24;
            this.tableVehicleInPark.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableVehicleInPark.Size = new System.Drawing.Size(510, 177);
            this.tableVehicleInPark.TabIndex = 3;
            // 
            // btlGetAllInPark
            // 
            this.btlGetAllInPark.Location = new System.Drawing.Point(376, 43);
            this.btlGetAllInPark.Name = "btlGetAllInPark";
            this.btlGetAllInPark.Size = new System.Drawing.Size(149, 42);
            this.btlGetAllInPark.TabIndex = 2;
            this.btlGetAllInPark.Text = "Xem xe trong bãi";
            this.btlGetAllInPark.UseVisualStyleBackColor = true;
            this.btlGetAllInPark.Click += new System.EventHandler(this.btlGetAllInPark_Click);
            // 
            // btnFilterWithPlate
            // 
            this.btnFilterWithPlate.Location = new System.Drawing.Point(194, 43);
            this.btnFilterWithPlate.Name = "btnFilterWithPlate";
            this.btnFilterWithPlate.Size = new System.Drawing.Size(149, 42);
            this.btnFilterWithPlate.TabIndex = 1;
            this.btnFilterWithPlate.Text = "Xem theo biển số";
            this.btnFilterWithPlate.UseVisualStyleBackColor = true;
            this.btnFilterWithPlate.Click += new System.EventHandler(this.btnFilterWithPlate_Click);
            // 
            // btnFilterWithCard
            // 
            this.btnFilterWithCard.Location = new System.Drawing.Point(13, 43);
            this.btnFilterWithCard.Name = "btnFilterWithCard";
            this.btnFilterWithCard.Size = new System.Drawing.Size(149, 42);
            this.btnFilterWithCard.TabIndex = 0;
            this.btnFilterWithCard.Text = "Xem theo thẻ";
            this.btnFilterWithCard.UseVisualStyleBackColor = true;
            this.btnFilterWithCard.Click += new System.EventHandler(this.btnFilterWithCard_Click);
            // 
            // groupConfirmControl
            // 
            this.groupConfirmControl.Controls.Add(this.checkAutoCheckin);
            this.groupConfirmControl.Controls.Add(this.btnConfirm);
            this.groupConfirmControl.Location = new System.Drawing.Point(30, 183);
            this.groupConfirmControl.Name = "groupConfirmControl";
            this.groupConfirmControl.Size = new System.Drawing.Size(531, 152);
            this.groupConfirmControl.TabIndex = 1;
            this.groupConfirmControl.TabStop = false;
            this.groupConfirmControl.Text = "Xác nhận xe";
            // 
            // checkAutoCheckin
            // 
            this.checkAutoCheckin.AutoSize = true;
            this.checkAutoCheckin.Location = new System.Drawing.Point(313, 74);
            this.checkAutoCheckin.Name = "checkAutoCheckin";
            this.checkAutoCheckin.Size = new System.Drawing.Size(83, 21);
            this.checkAutoCheckin.TabIndex = 3;
            this.checkAutoCheckin.Text = "Tự động";
            this.checkAutoCheckin.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(36, 55);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(202, 53);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Xác nhận xe vào";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(299, 32);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(202, 53);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Đóng cổng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(36, 32);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(202, 53);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Mở cổng";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
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
            this.groupManageControll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableVehicleInPark)).EndInit();
            this.groupConfirmControl.ResumeLayout(false);
            this.groupConfirmControl.PerformLayout();
            this.groupControlSOS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupCamera;
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
        private System.Windows.Forms.CheckBox checkAutoCheckin;
        private System.Windows.Forms.Label lbStatusCard;
        private Emgu.CV.UI.ImageBox imgCamera;
        private System.Windows.Forms.Button btnTryGetPlate;
        private System.Windows.Forms.Button btnSetingSerial;
    }
}