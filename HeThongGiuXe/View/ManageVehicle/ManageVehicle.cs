using HeThongGiuXe.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongGiuXe.View.ManageVehicle
{
    public partial class ManageVehicle : Form
    {
        public ManageVehicle()
        {
            InitializeComponent();
            InitializeSearchBox();
            InitializeHistoryList();
        }
        private void InitializeSearchBox()
        {
            txt_fullname.Text = null;
            txt_username.Text = null;
            txt_license_plates.Text = null;
            cb_date.Checked = false;
            cb_isPayment.Checked = false;
            rb_inpark.Checked = false;
            rb_outpark.Checked = false;
            rb_all.Checked = true;
        }
        private void InitializeHistoryList()
        {
            rb_all.Checked = true;
            this.dtgv_list_vehicle.DataSource = ParkingHistoryBLL.Instance.GetDataTableParkingHistories();
        }
        private void search()
        {
            string username = this.txt_username.Text;
            string fullname = this.txt_fullname.Text;
            string licence_plate = this.txt_license_plates.Text;
            DateTime start = this.dtp_start_day.Value;
            DateTime end = this.dtp_end_day.Value;
            Boolean isPayment = this.cb_isPayment.Checked;
            Nullable<Boolean> hasCheckout = this.rb_outpark.Checked;
            if (this.rb_all.Checked) hasCheckout = null;
            if (this.cb_date.Checked)
            {
                this.dtgv_list_vehicle.DataSource =
                ParkingHistoryBLL.Instance.GetDataTableParkingHistories(customer_name: fullname, username: username, plate: licence_plate, start: start, end: end, isPayment: isPayment, hasCheckout: hasCheckout);
            }
            else
            {
                this.dtgv_list_vehicle.DataSource =
                ParkingHistoryBLL.Instance.GetDataTableParkingHistories(customer_name: fullname, username: username,
                plate: licence_plate, hasCheckout: hasCheckout, isPayment: isPayment);
            }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            search();z
            if (this.dtgv_list_vehicle.RowCount > 0)
            {
                this.dtgv_list_vehicle.FirstDisplayedScrollingRowIndex
                = this.dtgv_list_vehicle.RowCount - 1;
            }
        }

        private void bnt_clear_Click(object sender, EventArgs e)
        {
            this.txt_fullname.Clear();
            this.txt_username.Clear();
            this.txt_license_plates.Clear();
            this.cb_date.Checked = false;
            this.cb_isPayment.Checked = false;
            this.rb_inpark.Checked = false;
            this.rb_outpark.Checked = false;
            this.rb_all.Checked = true;
            this.dtgv_list_vehicle.DataSource = ParkingHistoryBLL.Instance.GetDataTableParkingHistories(isPayment:false);
        }

        private void cb_date_CheckedChanged(object sender, EventArgs e)
        {
            this.gb_date.Enabled = this.cb_date.Checked;
        }
    }
}
