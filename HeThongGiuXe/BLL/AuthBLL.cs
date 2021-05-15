using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeThongGiuXe.DAL;

namespace HeThongGiuXe.BLL
{
    class AuthBLL
    {
        public Employee GetEmployeeByLogin(string username, string password)
        {
            // Early validate
            if (username == null || username == "") return null;
            if (password == null || password == "") return null;
            Employee result = null;
            using (DatabaseEntities db = new DatabaseEntities())
            {
           
                // Find by username
                result = db.Employees.Include("Role").Where(o => o.username == username).FirstOrDefault();
                // Return null if has no user  or wrong password
                if ((result == default(Employee)) || (!IsMatchingPassword(result.password, password)))
                {
                    result = null;
                }
            }
            return result;
        }
        public bool IsMatchingPassword(string pwd1, string pwd2)
        {
            return pwd1 == pwd2;
        }
        private AuthBLL() { }
        public static AuthBLL _Instance { get; set; }
        public static AuthBLL Instance 
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new AuthBLL();
                }
                return _Instance;
            }
        }
    }
}
