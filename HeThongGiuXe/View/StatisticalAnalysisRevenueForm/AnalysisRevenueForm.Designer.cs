
namespace HeThongGiuXe.View
{
    partial class AnalysisRevenueForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_export_pdf = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_analysis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpk_year = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgv_list_revenue = new System.Windows.Forms.DataGridView();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_list_revenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1332, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_export_pdf);
            this.groupBox3.Location = new System.Drawing.Point(686, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(607, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hành động";
            // 
            // btn_export_pdf
            // 
            this.btn_export_pdf.Location = new System.Drawing.Point(48, 35);
            this.btn_export_pdf.Name = "btn_export_pdf";
            this.btn_export_pdf.Size = new System.Drawing.Size(209, 35);
            this.btn_export_pdf.TabIndex = 1;
            this.btn_export_pdf.Text = "Xuất báo cáo";
            this.btn_export_pdf.UseVisualStyleBackColor = true;
            this.btn_export_pdf.Click += new System.EventHandler(this.btn_export_pdf_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_analysis);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpk_year);
            this.groupBox2.Location = new System.Drawing.Point(29, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phân tích";
            // 
            // btn_analysis
            // 
            this.btn_analysis.Location = new System.Drawing.Point(349, 42);
            this.btn_analysis.Name = "btn_analysis";
            this.btn_analysis.Size = new System.Drawing.Size(103, 23);
            this.btn_analysis.TabIndex = 2;
            this.btn_analysis.Text = "Phân tích";
            this.btn_analysis.UseVisualStyleBackColor = true;
            this.btn_analysis.Click += new System.EventHandler(this.btn_analysis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Năm";
            // 
            // dtpk_year
            // 
            this.dtpk_year.CustomFormat = "yyyy";
            this.dtpk_year.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_year.Location = new System.Drawing.Point(69, 44);
            this.dtpk_year.Name = "dtpk_year";
            this.dtpk_year.ShowUpDown = true;
            this.dtpk_year.Size = new System.Drawing.Size(200, 22);
            this.dtpk_year.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgv_list_revenue);
            this.groupBox4.Location = new System.Drawing.Point(12, 235);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(650, 546);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách";
            // 
            // dtgv_list_revenue
            // 
            this.dtgv_list_revenue.AllowUserToAddRows = false;
            this.dtgv_list_revenue.AllowUserToDeleteRows = false;
            this.dtgv_list_revenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_list_revenue.Location = new System.Drawing.Point(6, 56);
            this.dtgv_list_revenue.Name = "dtgv_list_revenue";
            this.dtgv_list_revenue.ReadOnly = true;
            this.dtgv_list_revenue.RowHeadersWidth = 51;
            this.dtgv_list_revenue.RowTemplate.Height = 24;
            this.dtgv_list_revenue.Size = new System.Drawing.Size(621, 461);
            this.dtgv_list_revenue.TabIndex = 0;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Revenue";
            legend2.Name = "NumberVehicles";
            this.chart.Legends.Add(legend1);
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(6, 89);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(657, 361);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chart);
            this.groupBox5.Location = new System.Drawing.Point(712, 235);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(669, 546);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Biểu đồ";
            // 
            // AnalysisRevenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 793);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnalysisRevenueForm";
            this.Text = "StatisticalAnalysisRevenueForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_list_revenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpk_year;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_export_pdf;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgv_list_revenue;
        private System.Windows.Forms.Button btn_analysis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}