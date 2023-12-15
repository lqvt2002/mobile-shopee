using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace cuoiky
{
    internal class tbl_transaction_DAL
    {
        //lấy kết nối CSDL
        dataconnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public tbl_transaction_DAL()
        {
            dc = new dataconnection();
        }
        public List<tbl_transaction> getAllTransaction()
        {
            // Taoj caau lenjeh sql laays toanf booj 
            string sql = "SELECT * FROM tbl_transaction";
            //Tạo 1 kết nối đến sql
            SqlConnection con = dc.getconnect();
            da = new SqlDataAdapter(sql, con);
            //mở kết nối
            con.Open();
            // đổ dữ liệu 
            DataTable transaction = new DataTable();
            da.Fill(transaction);
            List<tbl_transaction> transactionList = new List<tbl_transaction>();
            foreach (DataRow row in transaction.Rows)
            {
                tbl_transaction tbl_Transaction = new tbl_transaction 
                {
                  //chưa trả về kết quả
                };
                transactionList.Add(tbl_Transaction);
            }
            //đóng kết nối
            con.Close();
            return transactionList;
        }

        public bool AddTransaction(tbl_transaction transaction)
        {
            string insertSql = "INSERT INTO tbl_transaction(TransId, ModelId, Quantity, Amount, Date) VALUES(@TransId, @ModelId, @Quantity, @Amount, @Date);";
            string updateSql = "UPDATE tbl_model SET AvailableQty = @Quantity WHERE ModelId = @ModelId;";

            using (SqlConnection con = dc.getconnect())
            {
                con.Open();

                using (SqlCommand insertCmd = new SqlCommand(insertSql, con))
                {
                    insertCmd.Parameters.AddWithValue("@TransId", transaction.TransId);
                    insertCmd.Parameters.AddWithValue("@ModelId", transaction.ModelId);
                    insertCmd.Parameters.AddWithValue("@Quantity", transaction.Quantity);
                    insertCmd.Parameters.AddWithValue("@Amount", transaction.Amount);
                    insertCmd.Parameters.AddWithValue("@Date", DateTime.Now);

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

                using (SqlCommand updateCmd = new SqlCommand(updateSql, con))
                {
                    updateCmd.Parameters.AddWithValue("@ModelId", transaction.ModelId);
                    updateCmd.Parameters.AddWithValue("@Quantity", transaction.Quantity);

                    try
                    {
                        updateCmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi khi cập nhật số lượng: " + ex.Message);
                        return false;
                    }
                }
            }

            return true;
        }

    }
}
