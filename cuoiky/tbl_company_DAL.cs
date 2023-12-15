using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky
{
    internal class tbl_company_DAL
    {
        //lấy kết nối CSDL
        dataconnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public tbl_company_DAL()
        {
            dc = new dataconnection();
        }
        public List<tbl_company> getAllCompany()
        {
            // Taoj caau lenjeh sql laays toanf booj 
            string sql = "SELECT * FROM tbl_company";
            //Tạo 1 kết nối đến sql
            SqlConnection con = dc.getconnect();
            da = new SqlDataAdapter(sql, con);
            //mở kết nối
            con.Open();
            // đổ dữ liệu 
            DataTable company = new DataTable();
            da.Fill(company);
            List<tbl_company> companyList = new List<tbl_company>();
            foreach (DataRow row in company.Rows)
            {
                tbl_company tbl_company = new tbl_company
                {
                    CompId = row["CompId"].ToString(),
                    Cname = row["Cname"].ToString()
                };
                companyList.Add(tbl_company);
            }
            //đóng kết nối
            con.Close();
            return companyList;
        }
        public bool AddCompany(tbl_company company)
        {
            // Taoj caau lenjeh sql laays toanf booj 
            string sql = "INSERT INTO tbl_company(CompId, Cname) VALUES(@CompId, @Cname)";
            //Tạo 1 kết nối đến sql
            SqlConnection con = dc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                //mở kết nối
                con.Open();
                cmd.Parameters.Add("CompId", SqlDbType.NVarChar).Value = company.CompId;
                cmd.Parameters.Add("Cname", SqlDbType.NVarChar).Value = company.Cname;
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
