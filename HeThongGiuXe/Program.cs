using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongGiuXe.View.ManageEmployeeForm;

namespace HeThongGiuXe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CheckinForm());
            //Application.Run(new CheckoutForm());
            // Application.Run(new ManageCustomer());
            Application.Run(new MainForm());
        }
    }
}
