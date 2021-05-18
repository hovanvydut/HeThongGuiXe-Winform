using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongGiuXe.BLL;

namespace HeThongGiuXe.View
{
    public partial class StatisticalAnalysisRevenueForm : Form
    {
        public StatisticalAnalysisRevenueForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dtgv_list_revenue.DataSource = AnalysisRevenueBLL.Instance().GetDataTableRevenue(2021);
        }
    }
}
