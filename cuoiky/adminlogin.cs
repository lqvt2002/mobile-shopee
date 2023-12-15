using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuoiky
{
    public partial class adminlogin : Form
    {
        tbl_user_BLL bllUser;
        public adminlogin()
        {
            InitializeComponent();
            bllUser = new tbl_user_BLL();
        }
        private void adminlogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbl_user user = new tbl_user();

          
            user.Username = Username.Text;
            user.Pwd = Pwd.Text;

            bool loginSuccess = bllUser.login(user.Username, user.Pwd);
            if ( user.Username !="admin")
            {
                MessageBox.Show("Truy cập sai trang đăng nhập!");
            }
            else
            {
                if (loginSuccess)
                {
                    adminhomepage adminhomepage = new adminhomepage();
                    adminhomepage.Show();
                    // Đóng Form1 nếu bạn muốn
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                }
            }
        
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Close();
        }
    }
}
