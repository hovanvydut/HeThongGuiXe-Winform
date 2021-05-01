using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongGiuXe
{
    class CheckInOutBLL
    {
        public bool HaveCheckout(Customer customer)
        {
            bool notCheckOut;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                notCheckOut = db.Parking_History.Any(o => o.customer_ID == customer.ID_customer
                                                            && o.check_out_at == null);
            }
            return !notCheckOut;
        }
        public void CheckIn(Customer customer, String plate)
        {
            Parking_History history = new Parking_History
            {
                customer_ID = customer.ID_customer,
                is_payment = false,
                check_in_at = DateTime.Now,
                check_out_at = null,
                license_plate = plate,
                price = 1000
            };
            using (DatabaseEntities db = new DatabaseEntities())
            {
                db.Parking_History.Add(history);
                db.SaveChanges();
            }
        }
        public List<Parking_History> GetParkingHistories(
            Nullable<int> customer_id = null,
            string plate = null,
            Nullable<DateTime> start = null,
            Nullable<DateTime> end = null,
            Nullable<bool> isPayment = null,
            Nullable<bool> hasCheckout = null)
        {
            List<Parking_History> results = null ;
            using (DatabaseEntities db = new DatabaseEntities())
            {            
                results = db.Parking_History.Where(o
                    => (((customer_id == null) ? true : (o.customer_ID == customer_id))
                    && ((plate == null) ? true : (o.license_plate == plate))
                    && ((start == null) ? true : (o.check_in_at >= start))
                    && ((end == null) ? true : (o.check_in_at <= end))
                    && ((isPayment == null) ? true : (o.is_payment == isPayment))
                    && ((hasCheckout == null) ? true :
                        ((hasCheckout == true && o.check_out_at != null)
                        || (hasCheckout == false && o.check_out_at == null))))
                ).ToList();
            }
            return results;
        }
        public DataTable GetDataTableParkingHistories(
            Nullable<int> customer_id = null,
            string plate = null,
            Nullable<DateTime> start = null,
            Nullable<DateTime> end = null,
            Nullable<bool> isPayment = null,
            Nullable<bool> hasCheckout = null)
        {
            // Prepare table
            List<Parking_History> results = null;
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID", typeof(int)),
                new DataColumn("Họ & tên", typeof(string)),
                new DataColumn("Biển số", typeof(string)),
                new DataColumn("Giờ vào", typeof(DateTime)),
            });
            // Get data
            using (DatabaseEntities db = new DatabaseEntities())
            {
                // Get data
                results = db.Parking_History.Where(o
                    => (((customer_id == null) ? true : (o.customer_ID == customer_id))
                    && ((plate == null) ? true : (o.license_plate.Contains(plate)))
                    && ((start == null) ? true : (o.check_in_at >= start))
                    && ((end == null) ? true : (o.check_in_at <= end))
                    && ((isPayment == null) ? true : (o.is_payment == isPayment))
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
                    newRow["Biển số"] = item.license_plate;
                    newRow["Giờ vào"] = item.check_in_at;
                    table.Rows.Add(newRow);
                }
            }
            return table;
        }
        // Singleton
        private CheckInOutBLL() { }
        public static CheckInOutBLL _Instance { get; set; }
        public static CheckInOutBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new CheckInOutBLL();
                return _Instance;
            }
        }
    }


}
