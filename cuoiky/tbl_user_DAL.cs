using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace cuoiky
{
    internal class tbl_user_DAL
    {
        //lấy kết nối CSDL
        dataconnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public tbl_user_DAL()
        {
            dc = new dataconnection();
        }
        public bool login(string Username, string Pwd)
        {
            // Taoj caau lenjeh sql laays toanf booj sinh viene ê
            string sql = "SELECT * FROM tbl_user";
            //Tạo 1 kết nối đến sql
            SqlConnection con = dc.getconnect();
            da = new SqlDataAdapter(sql, con);
            //mở kết nối
            con.Open();
            // thực hiện 
            string query = "SELECT COUNT(*) FROM tbl_user WHERE Username = @Username AND Pwd = @Pwd";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Pwd", Pwd);

                int result = (int)command.ExecuteScalar();

                return result > 0;
            }

        }
        public bool AddUser(tbl_user user)
        {
            // Taoj caau lenjeh sql laays toanf booj sinh viene ê
            string sql = "INSERT INTO tbl_user(Username, Pwd,EmployeeeName, Address, MobileNumber,Hint) VALUES(@Username, @Pwd,@EmployeeeName, @Address, @MobileNumber,@Hint)";
            //Tạo 1 kết nối đến sql
            SqlConnection con = dc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                //mở kết nối
                con.Open();
                cmd.Parameters.Add("Username", SqlDbType.NVarChar).Value = user.Username;
                cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = user.Pwd;
                cmd.Parameters.Add("EmployeeeName", SqlDbType.NVarChar).Value = user.EmployeeeName;
                cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = user.Address;
                cmd.Parameters.Add("MobileNumber", SqlDbType.NVarChar).Value = user.MobileNumber;
                cmd.Parameters.Add("Hint", SqlDbType.NVarChar).Value = user.Hint;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
    }
}
