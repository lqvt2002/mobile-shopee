using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuoiky
{
    internal class tbl_customer_DAL
    {
        //lấy kết nối CSDL
        dataconnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public tbl_customer_DAL()
        {
            dc = new dataconnection();
        }
        public DataTable getCustomerByIMEI(string IMEINO)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = dc.getconnect())
            {
                string sqlQuery = "SELECT tbl_customer.Cust_Name, tbl_customer.MobileNumber, tbl_customer.EmailId, tbl_customer.Address FROM tbl_customer JOIN sales ON tbl_customer.CusId = sales.CusId WHERE sales.IMEINO = @IMEINO;";

                using (SqlCommand command = new SqlCommand(sqlQuery, con))
                {
                    // Thêm tham số vào câu truy vấn
                    command.Parameters.AddWithValue("@IMEINO", IMEINO);

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        con.Open();
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }


        public bool AddCustomer(tbl_customer customer)
        {
            // Taoj caau lenjeh sql laays toanf booj sinh viene ê
            string sql = "INSERT INTO tbl_customer(CusId, Cust_Name,MobileNumber,EmailId, Address) VALUES(@CusId, @Cust_Name, @MobileNumber,@EmailId, @Address)";
            //Tạo 1 kết nối đến sql
            SqlConnection con = dc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                //mở kết nối
                con.Open();
                cmd.Parameters.Add("CusId", SqlDbType.NVarChar).Value = customer.CusId;
                cmd.Parameters.Add("Cust_Name", SqlDbType.NVarChar).Value = customer.Cust_Name;
                cmd.Parameters.Add("MobileNumber", SqlDbType.NVarChar).Value = customer.MobileNumber;
                cmd.Parameters.Add("EmailId", SqlDbType.NVarChar).Value = customer.EmailId;
                cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = customer.Address;
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
