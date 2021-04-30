using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongGiuXe
{
    class CustomerBLL
    {
        public void CreateCustomer(Customer customer)
        {
            Validator.ValidateCustomerBeforeInsert(customer);
            using (DatabaseEntities db = new DatabaseEntities())
            {
                db.Customers.Add(customer);
                db.SaveChanges();
            }
        }
        public Customer GetCustomerByCardID(string cardID)
        {
            Customer result;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                result = db.Customers.Where(o => o.card_id == cardID)
                    .FirstOrDefault();
            }
            return (result == default(Customer)) ? null : result;
        }
        // Singleton
        private CustomerBLL() { }
        public static CustomerBLL _Instance { get; set; }
        public static CustomerBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new CustomerBLL();
                return _Instance;
            }
        }
    }

    
}
