using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace cuoiky
{
    public partial class Form1 : Form
    {
        tbl_user_BLL bllUser;
        public Form1()
        {
            InitializeComponent();
            bllUser = new tbl_user_BLL();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            // Mở Form2 khi liên kết được nhấp
            adminlogin adminlogin = new adminlogin();
            adminlogin.Show();
            // Đóng Form1 nếu bạn muốn
            //this.Close();

        }

        private void loginUser_Click(object sender, EventArgs e)
        {
            tbl_user user = new tbl_user();

            user.Username = Username.Text;
            user.Pwd = Pwd.Text;

            bool loginSuccess = bllUser.login(user.Username, user.Pwd);
            if (user.Username =="admin")
            {
                MessageBox.Show("Truy cập sai trang đăng nhập!");
            }
            else
            {
                if (loginSuccess)
                {
                    // Mở Form2 khi liên kết được nhấp
                    userhomepage userhomepage = new userhomepage();
                    userhomepage.Show();

                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
