using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace cuoiky
{
    internal class tbl_model_DAL
    {
        //lấy kết nối CSDL
        dataconnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public tbl_model_DAL()
        {
            dc = new dataconnection();
        }
        public List<tbl_model> getAllModel()
        {
            // Taoj caau lenjeh sql laays toanf booj 
            string sql = "SELECT * FROM tbl_model";
            //Tạo 1 kết nối đến sql
            SqlConnection con = dc.getconnect();
            da = new SqlDataAdapter(sql, con);
            //mở kết nối
            con.Open();
            // đổ dữ liệu 
            DataTable model = new DataTable();
            da.Fill(model);
            List<tbl_model> modelList = new List<tbl_model>();
            foreach (DataRow row in model.Rows)
            {
                tbl_model tbl_Model = new tbl_model
                {
                    ModelId = row["ModelId"].ToString(),
                    ModelNum = row["ModelNum"].ToString(),
                };
                modelList.Add(tbl_Model);
            }
            //đóng kết nối
            con.Close();
            return modelList;
        }

        public int ModelAvail(string ModelId)
        {
            int avail = 0; // Khởi tạo giá trị mặc định

            try
            {
                using (SqlConnection con = dc.getconnect())
                {
                    con.Open();

                    string sql = "SELECT AvailableQty FROM tbl_model WHERE ModelId = @ModelId";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@ModelId", ModelId);

                        // Sử dụng ExecuteScalar để lấy giá trị duy nhất từ câu truy vấn
                        object result = cmd.ExecuteScalar();

                        // Kiểm tra nếu có giá trị trả về
                        if (result != null && result != DBNull.Value)
                        {
                            avail = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi theo nhu cầu của bạn
                Console.WriteLine("Lỗi: " + ex.Message);
            }

            return avail;
        }

        public List<tbl_model> getModelByCompany(string CompId)
        {
            List<tbl_model> modelList = new List<tbl_model>();

            try
            {
                using (SqlConnection con = dc.getconnect())
                {
                    con.Open();

                    string sql = "SELECT * FROM tbl_model WHERE CompId = @CompId";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@CompId", CompId);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable model = new DataTable();
                            da.Fill(model);

                            foreach (DataRow row in model.Rows)
                            {
                                tbl_model tbl_Model = new tbl_model
                                {
                                    ModelId = row["ModelId"].ToString(),
                                    ModelNum = row["ModelNum"].ToString(),
                                };
                                modelList.Add(tbl_Model);
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

            return modelList;
        }

        public bool AddModel(tbl_model model)
        {
            // Taoj caau lenjeh sql laays toanf booj sinh viene ê
            string sql = "INSERT INTO tbl_model(ModelId, CompId,ModelNum, AvailableQty) VALUES(@ModelId, @CompId,@ModelNum, 0)";
            //Tạo 1 kết nối đến sql
            SqlConnection con = dc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                //mở kết nối
                con.Open();
                cmd.Parameters.Add("ModelId", SqlDbType.NVarChar).Value = model.ModelId;
                cmd.Parameters.Add("CompId", SqlDbType.NVarChar).Value = model.CompId;
                cmd.Parameters.Add("ModelNum", SqlDbType.NVarChar).Value = model.ModelNum;
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
