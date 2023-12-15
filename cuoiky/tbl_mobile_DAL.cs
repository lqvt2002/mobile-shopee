using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky
{
    internal class tbl_mobile_DAL
    {
        //lấy kết nối CSDL
        dataconnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public tbl_mobile_DAL()
        {
            dc = new dataconnection();
        }
        public List<tbl_mobile> getMobileByModel(string ModelId)
        {
            List<tbl_mobile> mobileList = new List<tbl_mobile>();

            try
            {
                using (SqlConnection con = dc.getconnect())
                {
                    con.Open();

                    string sql = "SELECT * FROM tbl_mobile WHERE ModelId = @ModelId AND Status='Not Sold'";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@ModelId", ModelId);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable mobile = new DataTable();
                            da.Fill(mobile);

                            foreach (DataRow row in mobile.Rows)
                            {
                                tbl_mobile tbl_mobile = new tbl_mobile
                                {
                                    IMEINO = row["IMEINO"].ToString(),
                                };
                                mobileList.Add(tbl_mobile);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi theo nhu cầu của bạn
                Console.WriteLine("Lỗi: " + ex.Message);
            }

            return mobileList;
        }

        public bool AddMobile(tbl_mobile mobile)
        {
            string insertSql = "INSERT INTO tbl_mobile(IMEINO, ModelId, Status, Price, Warranty) VALUES(@IMEINO, @ModelId, 'Not Sold', @Price, @Warranty);";
            

            using (SqlConnection con = dc.getconnect())
            {
                con.Open();

                using (SqlCommand insertCmd = new SqlCommand(insertSql, con))
                {
                    insertCmd.Parameters.AddWithValue("@IMEINO", mobile.IMEINO);
                    insertCmd.Parameters.AddWithValue("@ModelId", mobile.ModelId);
                    insertCmd.Parameters.AddWithValue("@Price", mobile.Price);
                    insertCmd.Parameters.AddWithValue("@Warranty", mobile.Warranty);

                    try
                    {
                        insertCmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi khi thêm di động: " + ex.Message);
                        return false;
                    }
                }

                
            }

            return true;
        }
     
    }
}
