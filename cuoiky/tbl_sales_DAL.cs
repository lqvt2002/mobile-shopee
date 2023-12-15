using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky
{
    internal class tbl_sales_DAL
    {
        //lấy kết nối CSDL
        dataconnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public tbl_sales_DAL()
        {
            dc = new dataconnection();
        }
        public DataTable getSaleByDay(DateTime PurchageDate)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = dc.getconnect())
            {
                string sqlQuery = "SELECT sales.SlsId, tbl_company.CName, tbl_model.ModelNum, tbl_mobile.IMEINO, sales.Price FROM sales  JOIN tbl_mobile ON sales.IMEINO = tbl_mobile.IMEINO JOIN  tbl_model ON tbl_mobile.ModelId = tbl_model.ModelId JOIN tbl_company ON tbl_model.CompId = tbl_company.CompId WHERE CONVERT(DATE, sales.PurchageDate) = CONVERT(DATE, @PurchageDate)";

                using (SqlCommand command = new SqlCommand(sqlQuery, con))
                {
                    // Thêm tham số vào câu truy vấn
                    command.Parameters.AddWithValue("@PurchageDate", PurchageDate);

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        con.Open();
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public DataTable getSaleByDateToDate(DateTime Starting, DateTime Ending)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = dc.getconnect())
            {
                string sqlQuery = "SELECT sales.SlsId, tbl_company.CName, tbl_model.ModelNum, tbl_mobile.IMEINO, sales.Price FROM sales  JOIN tbl_mobile ON sales.IMEINO = tbl_mobile.IMEINO JOIN  tbl_model ON tbl_mobile.ModelId = tbl_model.ModelId JOIN tbl_company ON tbl_model.CompId = tbl_company.CompId WHERE CONVERT(DATE, sales.PurchageDate) >= CONVERT(DATE, @Starting) AND CONVERT(DATE, sales.PurchageDate) <= CONVERT(DATE, @Ending)";

                using (SqlCommand command = new SqlCommand(sqlQuery, con))
                {
                    // Thêm tham số vào câu truy vấn
                    command.Parameters.AddWithValue("@Starting", Starting);
                    command.Parameters.AddWithValue("@Ending", Ending);

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        con.Open();
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }
        public bool AddSales(tbl_sales sales)
        {
            string insertSql = "INSERT INTO sales(SlsId, IMEINO, CusId, Price, PurchageDate) VALUES(@SlsId, @IMEINO, @CusId, @Price, @PurchageDate);";
            
            string updateMobileSql = "UPDATE tbl_mobile SET Status = 'Sold' WHERE IMEINO = @IMEINO;";

            string updateQuantytiSql = "UPDATE tbl_model SET AvailableQty = AvailableQty - 1 FROM tbl_model JOIN tbl_mobile ON tbl_model.modelId = tbl_mobile.modelId WHERE tbl_mobile.IMEINO = @IMEINO;";
            using (SqlConnection con = dc.getconnect())
            {
                con.Open();

                using (SqlCommand insertCmd = new SqlCommand(insertSql, con))
                {
                    insertCmd.Parameters.AddWithValue("@SlsId", sales.SlsId);
                    insertCmd.Parameters.AddWithValue("@IMEINO", sales.IMEINO);
                    insertCmd.Parameters.AddWithValue("@CusId", sales.CusId);
                    insertCmd.Parameters.AddWithValue("@Price", sales.Price);
                    insertCmd.Parameters.AddWithValue("@PurchageDate", DateTime.Now);

                    try
                    {
                        insertCmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi khi thêm giao dịch: " + ex.Message);
                        return false;
                    }
                }

                

                using (SqlCommand updateMobileCmd = new SqlCommand(updateMobileSql, con))
                {
                    updateMobileCmd.Parameters.AddWithValue("@IMEINO", sales.IMEINO);

                    try
                    {
                        updateMobileCmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi khi cập nhật trạng thái di động: " + ex.Message);
                        return false;
                    }
                }

                using (SqlCommand updateQuantytiCmd = new SqlCommand(updateQuantytiSql, con))
                {
                    updateQuantytiCmd.Parameters.AddWithValue("@IMEINO", sales.IMEINO);

                    try
                    {
                        updateQuantytiCmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi khi cập nhật trạng thái di động: " + ex.Message);
                        return false;
                    }
                }
            }

            return true;
        }


    }
}
