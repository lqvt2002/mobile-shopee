using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace cuoiky
{
    internal class tbl_user_BLL
    {
        tbl_user_DAL dalUser;
        public tbl_user_BLL()
        {
            dalUser = new tbl_user_DAL();
        }
        public bool login(string Username, string Pwd)
        {
            // Kiểm tra đăng nhập từ Data Access Layer
            return dalUser.login(Username, Pwd);
        }
        public bool AddUser(tbl_user tbl_user )
        {
            // Kiểm tra đăng nhập từ Data Access Layer
            return dalUser.AddUser(tbl_user);
        }
    }
}
