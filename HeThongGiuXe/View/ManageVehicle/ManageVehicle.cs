using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongGiuXe
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
            this.txt_fullname.Text = null;
            this.txt_username.Text = null;
            this.txt_license_plates.Text = null;
            this.cb_date.Checked = false;
            this.rb_is_payment.Checked = false;
            this.rb_isnt_payment.Checked = false;
            this.rb_all_payment.Checked = true;
            this.rb_inpark.Checked = false;
            this.rb_outpark.Checked = false;
            this.rb_all_range.Checked = true;
        }
        private void InitializeHistoryList()
        {
            this.rb_all_range.Checked = true;
            this.rb_all_payment.Checked = true;
            this.dtgv_list_vehicle.DataSource = ParkingHistoryBLL.Instance.GetDataTableParkingHistories();
            this.lbNumberTotal.Text = this.dtgv_list_vehicle.Rows.Count.ToString();
            this.dtgv_list_vehicle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_list_vehicle.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void setStatusBtn()
        {
            this.btnAll.Enabled = !this.btnAll.Enabled;
            this.btnClear.Enabled = !this.btnClear.Enabled;
            this.btnSearch.Enabled = !this.btnSearch.Enabled;
        }
        private void search()
        {
            setStatusBtn();
            string username = this.txt_username.Text;
            string fullname = this.txt_fullname.Text;
            string licence_plate = this.txt_license_plates.Text;
            Nullable<DateTime> start = this.dtp_start_day.Value;
            Nullable<DateTime> end = this.dtp_end_day.Value;
            Nullable<Boolean> isPayment = this.rb_is_payment.Checked;
            Nullable<Boolean> hasCheckout = this.rb_outpark.Checked;

            // reset to search with all history
            if (this.rb_all_range.Checked) hasCheckout = null;
            // reset to search with all is payment and isnt payment
            if (this.rb_all_payment.Checked) isPayment = null;
            // check if don't have date limit 
            if ( this.cb_date.Checked == false)
            {
                start = null;
                end = null;
            }

            this.dtgv_list_vehicle.DataSource =
            ParkingHistoryBLL.Instance.GetDataTableParkingHistories(customer_name: fullname, username: username, plate: licence_plate, start: start, end: end, isPayment: isPayment, hasCheckout: hasCheckout);
            this.lbNumberTotal.Text = this.dtgv_list_vehicle.Rows.Count.ToString();
            setStatusBtn();
        }
        private void clear()
        {
            this.txt_fullname.Clear();
            this.txt_username.Clear();
            this.txt_license_plates.Clear();
            this.cb_date.Checked = false;
            this.rb_is_payment.Checked = false;
            this.rb_isnt_payment.Checked = false;
            this.rb_all_payment.Checked = true;
            this.rb_inpark.Checked = false;
            this.rb_outpark.Checked = false;
            this.rb_all_range.Checked = true;
        }
        private void cb_date_CheckedChanged(object sender, EventArgs e)
        {
            this.gb_date.Enabled = this.cb_date.Checked;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
            if (this.dtgv_list_vehicle.RowCount > 0)
            {
                this.dtgv_list_vehicle.FirstDisplayedScrollingRowIndex
                = this.dtgv_list_vehicle.RowCount - 1;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            search();
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            clear();
            search();
        }
    }
}
