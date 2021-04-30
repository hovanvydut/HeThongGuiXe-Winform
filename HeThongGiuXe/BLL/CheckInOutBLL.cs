using System;
using System.Collections.Generic;
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
        public List<Parking_History> GetParkingHistoriesNotCheckOut()
        {
            List<Parking_History> results;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                results = db.Parking_History.Where(o => o.check_out_at == null).ToList();
            }
            return results;
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
