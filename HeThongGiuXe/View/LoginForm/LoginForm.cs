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

namespace HeThongGiuXe
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EnableElement(false);
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;
            Employee user = null;
            try
            {
                user = AuthBLL.Instance.GetEmployeeByLogin(username, password);
            } catch (Exception err)
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu", "Lỗi hệ thống");
                EnableElement(true);
                Console.WriteLine(err.Message);
                return;
            }
            if (user == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mất khẩu không chính xác", "Lỗi thông tin");
                EnableElement(true);
                return;
            }
            Session.SetUser(user);
            this.Dispose();
        }
        private void EnableElement(bool dis)
        {
            this.txtUsername.Enabled = dis;
            this.txtPassword.Enabled = dis;
            this.btnLogin.Enabled = dis;
        }
    }
}
