using HeThongGiuXe.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongGiuXe.BLL
{
    class ParkingHistoryBLL
    {

        public DataTable GetDataTableParkingHistories(
            string customer_name = null,
            string username = null,
            string plate = null,
            Nullable<DateTime> start = null,
            Nullable<DateTime> end = null,
            Nullable<bool> isPayment = null,
            Nullable<bool> hasCheckout = null )
        {
            // Prepare table
            List<Parking_History> results = null;
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID", typeof(int)),
                new DataColumn("Họ & tên", typeof(string)),
                new DataColumn("Tên tài khoản", typeof(string)),
                new DataColumn("Biển số", typeof(string)),
                new DataColumn("Giờ vào", typeof(DateTime)),
                new DataColumn("Giờ ra", typeof(DateTime)),
                new DataColumn("Giá", typeof(string)),
                new DataColumn("Đã thanh toán", typeof(Boolean)),
            });
            // Get data
            using (DatabaseEntities db = new DatabaseEntities())
            {
                // Get data
                results = db.Parking_History.Where(o
                    => (
                    ((plate == null) ? true : (o.license_plate.Contains(plate)))
                    && ((customer_name == null) ? true : (o.Customer.fullname.Contains(customer_name)))
                    && ((username == null) ? true : (o.Customer.username.Contains(username)))
                    && ((start == null) ? true : (o.check_in_at >= start))
                    && ((end == null) ? true : (o.check_in_at <= end))
                    && ((isPayment == null) ? true : ( o.is_payment == isPayment))
                    && ((hasCheckout == null) ? true :
                        ((hasCheckout == true && o.check_out_at != null)
                        || (hasCheckout == false && o.check_out_at == null))))
                     
                ).ToList();
                // Parse to table
                foreach (Parking_History item in results)
                {
                    DataRow newRow = table.NewRow();
                    newRow["ID"] = item.ID_parking;
                    newRow["Họ & tên"] = item.Customer.fullname;
                    newRow["Tên tài khoản"] = item.Customer.username;
                    newRow["Biển số"] = item.license_plate;
                    newRow["Giờ vào"] = item.check_in_at;
                    // set value checkout if not checkout 
                    if( item.check_out_at != null)
                    {
                        newRow["Giờ ra"] = item.check_out_at;
                    }
                    newRow["Giá"] = item.price;
                    newRow["Đã thanh toán"] = item.is_payment;
                    table.Rows.Add(newRow);
                }
            }
            return table;
        }
        // Singleton
        private ParkingHistoryBLL() { }
        public static ParkingHistoryBLL _Instance { get; set; }
        public static ParkingHistoryBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new ParkingHistoryBLL();
                return _Instance;
            }
          
        }
    }
}
  
