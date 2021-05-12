
namespace HeThongGiuXe
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
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.tableDayPrice = new System.Windows.Forms.DataGridView();
            this.groupSpecicalTime = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateFilter = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbEnd = new System.Windows.Forms.Label();
            this.lbStart = new System.Windows.Forms.Label();
            this.lbStartFilter = new System.Windows.Forms.Label();
            this.tableSpecialPrice = new System.Windows.Forms.DataGridView();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.groupDayPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDayPrice)).BeginInit();
            this.groupSpecicalTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableSpecialPrice)).BeginInit();
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
            // btnSaveChange
            // 
            this.btnSaveChange.Enabled = false;
            this.btnSaveChange.Location = new System.Drawing.Point(193, 46);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(121, 24);
            this.btnSaveChange.TabIndex = 2;
            this.btnSaveChange.Text = "Lưu thay đổi";
            this.btnSaveChange.UseVisualStyleBackColor = true;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // cbDay
            // 
            this.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Items.AddRange(new object[] {
            "Chủ nhật",
            "Thứ 2",
            "Thứ 3",
            "Thứ 4",
            "Thứ 5",
            "Thứ 6",
            "Thứ 7"});
            this.cbDay.Location = new System.Drawing.Point(35, 46);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(137, 24);
            this.cbDay.TabIndex = 1;
            this.cbDay.SelectedIndexChanged += new System.EventHandler(this.cbDay_SelectedIndexChanged);
            // 
            // tableDayPrice
            // 
            this.tableDayPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableDayPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDayPrice.Location = new System.Drawing.Point(25, 90);
            this.tableDayPrice.Name = "tableDayPrice";
            this.tableDayPrice.RowHeadersVisible = false;
            this.tableDayPrice.RowHeadersWidth = 51;
            this.tableDayPrice.RowTemplate.Height = 24;
            this.tableDayPrice.Size = new System.Drawing.Size(289, 363);
            this.tableDayPrice.TabIndex = 0;
            // 
            // groupSpecicalTime
            // 
            this.groupSpecicalTime.Controls.Add(this.btnShowAll);
            this.groupSpecicalTime.Controls.Add(this.txtDescription);
            this.groupSpecicalTime.Controls.Add(this.lbDescription);
            this.groupSpecicalTime.Controls.Add(this.btnReset);
            this.groupSpecicalTime.Controls.Add(this.btnDelete);
            this.groupSpecicalTime.Controls.Add(this.btnOK);
            this.groupSpecicalTime.Controls.Add(this.btnSearch);
            this.groupSpecicalTime.Controls.Add(this.dateFilter);
            this.groupSpecicalTime.Controls.Add(this.dateStart);
            this.groupSpecicalTime.Controls.Add(this.dateEnd);
            this.groupSpecicalTime.Controls.Add(this.txtPrice);
            this.groupSpecicalTime.Controls.Add(this.lbPrice);
            this.groupSpecicalTime.Controls.Add(this.lbEnd);
            this.groupSpecicalTime.Controls.Add(this.lbStart);
            this.groupSpecicalTime.Controls.Add(this.lbStartFilter);
            this.groupSpecicalTime.Controls.Add(this.tableSpecialPrice);
            this.groupSpecicalTime.Location = new System.Drawing.Point(411, 33);
            this.groupSpecicalTime.Name = "groupSpecicalTime";
            this.groupSpecicalTime.Size = new System.Drawing.Size(338, 474);
            this.groupSpecicalTime.TabIndex = 1;
            this.groupSpecicalTime.TabStop = false;
            this.groupSpecicalTime.Text = "Giá thời gian đặt biệt";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(129, 98);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(192, 22);
            this.txtDescription.TabIndex = 16;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(23, 98);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(57, 17);
            this.lbDescription.TabIndex = 15;
            this.lbDescription.Text = "Ghi chú";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(127, 132);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 23);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(228, 132);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(29, 132);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "Thêm";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(21, 236);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(297, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dateFilter
            // 
            this.dateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFilter.Location = new System.Drawing.Point(126, 208);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(192, 22);
            this.dateFilter.TabIndex = 10;
            // 
            // dateStart
            // 
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(129, 32);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(192, 22);
            this.dateStart.TabIndex = 8;
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(129, 54);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(192, 22);
            this.dateEnd.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(129, 75);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(192, 22);
            this.txtPrice.TabIndex = 6;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(23, 75);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(57, 17);
            this.lbPrice.TabIndex = 5;
            this.lbPrice.Text = "Đơn giá";
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.Location = new System.Drawing.Point(23, 54);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(95, 17);
            this.lbEnd.TabIndex = 4;
            this.lbEnd.Text = "Ngày kết thúc";
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.Location = new System.Drawing.Point(23, 32);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(93, 17);
            this.lbStart.TabIndex = 3;
            this.lbStart.Text = "Ngày bắt đầu";
            // 
            // lbStartFilter
            // 
            this.lbStartFilter.AutoSize = true;
            this.lbStartFilter.Location = new System.Drawing.Point(18, 208);
            this.lbStartFilter.Name = "lbStartFilter";
            this.lbStartFilter.Size = new System.Drawing.Size(93, 17);
            this.lbStartFilter.TabIndex = 1;
            this.lbStartFilter.Text = "Ngày bắt đầu";
            // 
            // tableSpecialPrice
            // 
            this.tableSpecialPrice.AllowUserToAddRows = false;
            this.tableSpecialPrice.AllowUserToDeleteRows = false;
            this.tableSpecialPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tableSpecialPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableSpecialPrice.Location = new System.Drawing.Point(21, 299);
            this.tableSpecialPrice.Name = "tableSpecialPrice";
            this.tableSpecialPrice.ReadOnly = true;
            this.tableSpecialPrice.RowHeadersVisible = false;
            this.tableSpecialPrice.RowHeadersWidth = 51;
            this.tableSpecialPrice.RowTemplate.Height = 24;
            this.tableSpecialPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableSpecialPrice.Size = new System.Drawing.Size(300, 149);
            this.tableSpecialPrice.TabIndex = 0;
            this.tableSpecialPrice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableSpecialPrice_CellClick);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(21, 265);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(297, 23);
            this.btnShowAll.TabIndex = 17;
            this.btnShowAll.Text = "Xem tất cả";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.tableSpecialPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDayPrice;
        private System.Windows.Forms.DataGridView tableDayPrice;
        private System.Windows.Forms.GroupBox groupSpecicalTime;
        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateFilter;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.Label lbStartFilter;
        private System.Windows.Forms.DataGridView tableSpecialPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Button btnShowAll;
    }
}