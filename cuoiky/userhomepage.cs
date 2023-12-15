using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuoiky
{
    public partial class userhomepage : Form
    {
        tbl_company_BLL BllCompany;
        tbl_model_BLL BllModel;
        tbl_transaction_BLL BllTransaction;
        tbl_mobile_BLL BllMobile;
        tbl_user_BLL BllUser;
        tbl_sales_BLL BllSales;
        tbl_customer_BLL BllCustomer;
        public userhomepage()
        {
            InitializeComponent();
            BllCompany = new tbl_company_BLL();
            BllModel = new tbl_model_BLL();
            BllTransaction = new tbl_transaction_BLL();
            BllMobile = new tbl_mobile_BLL();
            BllUser = new tbl_user_BLL();
            BllSales = new tbl_sales_BLL();
            BllCustomer = new tbl_customer_BLL();
        }
        public void ShowAllCompany()
        {
            List<tbl_company> dt = BllCompany.getAllCompany();
            CompanyName.DataSource = dt;
            // Thiết lập DisplayMember và ValueMember
            CompanyName.DisplayMember = "Cname";
            CompanyName.ValueMember = "CompId";

            CompanyStock.DataSource = dt;
            // Thiết lập DisplayMember và ValueMember
            CompanyStock.DisplayMember = "Cname";
            CompanyStock.ValueMember = "CompId";
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CompanyId = (string)CompanyName.SelectedValue;
            List<tbl_model> dt = BllModel.getModelByCompany(CompanyId);
            ModelName.DataSource = dt;
            // Thiết lập DisplayMember và ValueMember
            ModelName.DisplayMember = "ModelNum";
            ModelName.ValueMember = "ModelId";
        }

        private void userhomepage_Load(object sender, EventArgs e)
        {
            ShowAllCompany();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void ModelName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ModelId = (string)ModelName.SelectedValue;
            List<tbl_mobile> dt = BllMobile.getMobileByModel(ModelId);
            IMEINONumber.DataSource = dt;
            // Thiết lập DisplayMember và ValueMember
            IMEINONumber.DisplayMember = "IMEINO";
            IMEINONumber.ValueMember = "IMEINO";
        }

        private void SubmitSale_Click(object sender, EventArgs e)
        {
            tbl_sales sales = new tbl_sales();
            sales.SlsId = (string)IMEINONumber.SelectedValue;
            sales.IMEINO = (string)IMEINONumber.SelectedValue;
            sales.Price = decimal.Parse(Price.Text);
            sales.CusId = EmailSale.Text;
            tbl_customer customer = new tbl_customer();
            customer.CusId = EmailSale.Text;
            customer.Cust_Name = Cust_name.Text;
            customer.MobileNumber = MobileNumber.Text;
            customer.EmailId = EmailSale.Text;
            customer.Address = Address.Text;

            if ((BllCustomer.AddCustomer(customer)) && (BllSales.AddSales(sales)))
            {               
                    MessageBox.Show("successfully!");                      
            }
            else
            {
                MessageBox.Show("There was an error, please try again", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void StockAvail_TextChanged(object sender, EventArgs e)
        {

        }

        private void CompanyStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ComapnyId = (string)CompanyStock.SelectedValue;
            List<tbl_model> dt = BllModel.getModelByCompany(ComapnyId);
            ModelStock.DataSource = dt;
            // Thiết lập DisplayMember và ValueMember
            ModelStock.DisplayMember = "ModelNum";
            ModelStock.ValueMember = "ModelId";
        }

        private void ModelStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ModelId = (string)ModelStock.SelectedValue;
            int result = BllModel.ModelAvail(ModelId);
            StockAvail.Text = result.ToString(); ;
        }

        private void Sales_Click(object sender, EventArgs e)
        {

        }

        private void ggggg_Click(object sender, EventArgs e)
        {

        }

        private void Cust_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void SearchCustomerByIMEINO_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string SearchIMEINumber = IMEINumber.Text;

            DataTable dt = BllCustomer.getCustomerByIMEI( SearchIMEINumber);
            if (dt != null) { dataGridView1.DataSource = dt; }
            else
            {
                MessageBox.Show("Not result","Resutl ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
