using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuoiky
{
    public partial class adminhomepage : Form
    {
        tbl_company_BLL BllCompany;
        tbl_model_BLL BllModel;
        tbl_transaction_BLL BllTransaction;
        tbl_mobile_BLL BllMobile;
        tbl_user_BLL BllUser;
        tbl_sales_BLL BllSales;
        tbl_customer_BLL BllCustomer;
        public adminhomepage()
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
            CompanyModel.DataSource = dt;
            // Thiết lập DisplayMember và ValueMember
            CompanyModel.DisplayMember = "Cname";
            CompanyModel.ValueMember = "CompId";
        }
        public void ShowCompanyUpdateStock()
        {
            List<tbl_company> dt = BllCompany.getAllCompany();
            CompanyUpdateStock.DataSource = dt;
            // Thiết lập DisplayMember và ValueMember
            CompanyUpdateStock.DisplayMember = "Cname";
            CompanyUpdateStock.ValueMember = "CompId";
        }
        public void ShowCompanyMobile()
        {
            List<tbl_company> dt = BllCompany.getAllCompany();
            CompanyMobile.DataSource = dt;
            // Thiết lập DisplayMember và ValueMember
            CompanyMobile.DisplayMember = "Cname";
            CompanyMobile.ValueMember = "CompId";
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCompany_Click(object sender, EventArgs e)
        {
            tbl_company company = new tbl_company();
            company.CompId = CompId.Text;
            company.Cname = Cname.Text;
            if (BllCompany.AddCompany(company))
            {
                MessageBox.Show("successfully!");
                ShowAllCompany();
            }
            else
            {
                MessageBox.Show("There was an error, please try again", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void AddModel_Click(object sender, EventArgs e)
        {

            tbl_model model = new tbl_model();
            model.ModelId = ModelID.Text;
            model.CompId = (string)CompanyModel.SelectedValue;
            model.ModelNum = ModelNumber.Text;
            if (BllModel.AddModel(model))
            {
                MessageBox.Show("successfully!");
            }
            else
            {
                MessageBox.Show("There was an error, please try again", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void CompanyModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CompId = CompanyModel.ValueMember.ToString();
        }

        private void adminhomepage_Load(object sender, EventArgs e)
        {
            ShowAllCompany();
            ShowCompanyUpdateStock();
            ShowCompanyMobile();
        }

        private void AddUpdateStock_Click(object sender, EventArgs e)
        {
            tbl_transaction transaction = new tbl_transaction();
            transaction.TransId = TransID.Text;
            transaction.ModelId = (string)ModelNumberUpdateStock.SelectedValue;
            transaction.Quantity = int.Parse(Quantity.Text);
            transaction.Amount = decimal.Parse(Amount.Text);
            if (BllTransaction.UpdateTransaction(transaction))
            {
                MessageBox.Show("successfully!");
            }
            else
            {
                MessageBox.Show("There was an error, please try again", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ModelNumberUpdateStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CompanyUpdateStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CompanyId = (string)CompanyUpdateStock.SelectedValue;
            List<tbl_model> dt = BllModel.getModelByCompany(CompanyId);
            ModelNumberUpdateStock.DataSource = dt;
            // Thiết lập DisplayMember và ValueMember
            ModelNumberUpdateStock.DisplayMember = "ModelNum";
            ModelNumberUpdateStock.ValueMember = "ModelId";
        }

        private void InsertMobile_Click(object sender, EventArgs e)
        {
            tbl_mobile mobile = new tbl_mobile();
            mobile.IMEINO = IMEINO.Text;
            mobile.ModelId = (string)ModelMobile.SelectedValue;
            mobile.Price = decimal.Parse(PriceMobile.Text);
            mobile.Warranty = Warranty.Value;
            if (BllMobile.AddMobile(mobile))
            {
                MessageBox.Show("successfully!");
            }
            else
            {
                MessageBox.Show("There was an error, please try again", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void CompanyMobile_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CompanyId = (string)CompanyMobile.SelectedValue;
            List<tbl_model> dt = BllModel.getModelByCompany(CompanyId);
            ModelMobile.DataSource = dt;
            // Thiết lập DisplayMember và ValueMember
            ModelMobile.DisplayMember = "ModelNum";
            ModelMobile.ValueMember = "ModelId";
        }

        private void Warranty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            tbl_user user = new tbl_user();
            user.Username = Username.Text;
            user.Pwd = Pwd.Text;
            user.EmployeeeName = EmployeeName.Text;
            user.Address = Address.Text;
            user.MobileNumber = MobileNumber.Text;
            user.Hint = Hint.Text;
            if (Pwd.Text != rePwd.Text)
            {
                MessageBox.Show("Password and re-entered password do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (BllUser.AddUser(user))
                {
                    MessageBox.Show("successfully!");
                }
                else
                {
                    MessageBox.Show("user already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            
        }

        private void IMEINO_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void ModelMobile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PriceMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DateTime PurchageDate = day.Value;
            DataTable dt = BllSales.getSaleByDay(PurchageDate);
            if (dt != null) { dataGridView1.DataSource = dt; }
            else
            {
                MessageBox.Show("Not result");
            }
            // Giả sử dataGridView1 là tên của DataGridView của bạn
            decimal total = dataGridView1.Rows.Cast<DataGridViewRow>()
                                    .Sum(row => Convert.ToDecimal(row.Cells["Price"].Value));
            // "ColumnName" là tên của cột bạn muốn tính tổng
            totalPriceDay.Text = total.ToString();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DateTime Starting = Start.Value;
            DateTime Ending = End.Value;
            DataTable dt = BllSales.getSaleByDateToDate(Starting, Ending);
            if (dt != null) { dataGridView2.DataSource = dt; }
            else
            {
                MessageBox.Show("Not result");
            }
            // Giả sử dataGridView1 là tên của DataGridView của bạn
            decimal total = dataGridView2.Rows.Cast<DataGridViewRow>()
                                    .Sum(row => Convert.ToDecimal(row.Cells["Price"].Value));
            // "ColumnName" là tên của cột bạn muốn tính tổng
            totalPriceDateToDate.Text = total.ToString();
        }
    }
}
