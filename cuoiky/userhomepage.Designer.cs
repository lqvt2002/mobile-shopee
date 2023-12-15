namespace cuoiky
{
    partial class userhomepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Sales = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.IMEINONumber = new System.Windows.Forms.ComboBox();
            this.MobileNumber = new System.Windows.Forms.TextBox();
            this.Cust_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ModelName = new System.Windows.Forms.ComboBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CompanyName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.EmailSale = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ggggg = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SubmitSale = new System.Windows.Forms.Button();
            this.ViewStock = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.ModelStock = new System.Windows.Forms.ComboBox();
            this.StockAvail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CompanyStock = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SearchCustomerByIMEINO = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.IMEINumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CusstomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNumberS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Sales.SuspendLayout();
            this.ViewStock.SuspendLayout();
            this.SearchCustomerByIMEINO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Sales);
            this.tabControl1.Controls.Add(this.ViewStock);
            this.tabControl1.Controls.Add(this.SearchCustomerByIMEINO);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(25, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 484);
            this.tabControl1.TabIndex = 0;
            // 
            // Sales
            // 
            this.Sales.Controls.Add(this.label6);
            this.Sales.Controls.Add(this.IMEINONumber);
            this.Sales.Controls.Add(this.MobileNumber);
            this.Sales.Controls.Add(this.Cust_name);
            this.Sales.Controls.Add(this.label1);
            this.Sales.Controls.Add(this.ModelName);
            this.Sales.Controls.Add(this.Price);
            this.Sales.Controls.Add(this.label2);
            this.Sales.Controls.Add(this.CompanyName);
            this.Sales.Controls.Add(this.label3);
            this.Sales.Controls.Add(this.label4);
            this.Sales.Controls.Add(this.label5);
            this.Sales.Controls.Add(this.Address);
            this.Sales.Controls.Add(this.label15);
            this.Sales.Controls.Add(this.EmailSale);
            this.Sales.Controls.Add(this.label13);
            this.Sales.Controls.Add(this.label16);
            this.Sales.Controls.Add(this.ggggg);
            this.Sales.Controls.Add(this.label18);
            this.Sales.Controls.Add(this.SubmitSale);
            this.Sales.Location = new System.Drawing.Point(4, 27);
            this.Sales.Name = "Sales";
            this.Sales.Padding = new System.Windows.Forms.Padding(3);
            this.Sales.Size = new System.Drawing.Size(780, 453);
            this.Sales.TabIndex = 0;
            this.Sales.Text = "Sales";
            this.Sales.UseVisualStyleBackColor = true;
            this.Sales.Click += new System.EventHandler(this.Sales_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 32);
            this.label6.TabIndex = 72;
            this.label6.Text = "Sales";
            // 
            // IMEINONumber
            // 
            this.IMEINONumber.FormattingEnabled = true;
            this.IMEINONumber.Location = new System.Drawing.Point(359, 288);
            this.IMEINONumber.Name = "IMEINONumber";
            this.IMEINONumber.Size = new System.Drawing.Size(250, 26);
            this.IMEINONumber.TabIndex = 71;
            this.IMEINONumber.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // MobileNumber
            // 
            this.MobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileNumber.Location = new System.Drawing.Point(368, 71);
            this.MobileNumber.Name = "MobileNumber";
            this.MobileNumber.Size = new System.Drawing.Size(241, 24);
            this.MobileNumber.TabIndex = 70;
            // 
            // Cust_name
            // 
            this.Cust_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cust_name.Location = new System.Drawing.Point(368, 26);
            this.Cust_name.Name = "Cust_name";
            this.Cust_name.Size = new System.Drawing.Size(241, 24);
            this.Cust_name.TabIndex = 69;
            this.Cust_name.TextChanged += new System.EventHandler(this.Cust_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 63;
            this.label1.Text = "IMEINO Number:";
            // 
            // ModelName
            // 
            this.ModelName.FormattingEnabled = true;
            this.ModelName.Location = new System.Drawing.Point(346, 242);
            this.ModelName.Name = "ModelName";
            this.ModelName.Size = new System.Drawing.Size(263, 26);
            this.ModelName.TabIndex = 68;
            this.ModelName.SelectedIndexChanged += new System.EventHandler(this.ModelName_SelectedIndexChanged);
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(281, 335);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(328, 24);
            this.Price.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 66;
            this.label2.Text = "Price:";
            // 
            // CompanyName
            // 
            this.CompanyName.DisplayMember = "Cname";
            this.CompanyName.FormattingEnabled = true;
            this.CompanyName.Location = new System.Drawing.Point(359, 197);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(250, 26);
            this.CompanyName.TabIndex = 65;
            this.CompanyName.ValueMember = "CompId";
            this.CompanyName.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 62;
            this.label3.Text = "Model Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 61;
            this.label4.Text = "Company Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(207, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 60;
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(290, 118);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(319, 24);
            this.Address.TabIndex = 54;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(210, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 18);
            this.label15.TabIndex = 53;
            this.label15.Text = "Address:";
            // 
            // EmailSale
            // 
            this.EmailSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailSale.Location = new System.Drawing.Point(304, 162);
            this.EmailSale.Name = "EmailSale";
            this.EmailSale.Size = new System.Drawing.Size(305, 24);
            this.EmailSale.TabIndex = 58;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(210, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 18);
            this.label13.TabIndex = 57;
            this.label13.Text = "Email ID:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(210, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 18);
            this.label16.TabIndex = 52;
            this.label16.Text = "Mobile Number:";
            // 
            // ggggg
            // 
            this.ggggg.AutoSize = true;
            this.ggggg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggggg.Location = new System.Drawing.Point(207, 32);
            this.ggggg.Name = "ggggg";
            this.ggggg.Size = new System.Drawing.Size(136, 18);
            this.ggggg.TabIndex = 51;
            this.ggggg.Text = "Customer Name:";
            this.ggggg.Click += new System.EventHandler(this.ggggg_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(207, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 18);
            this.label18.TabIndex = 50;
            // 
            // SubmitSale
            // 
            this.SubmitSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitSale.Location = new System.Drawing.Point(290, 398);
            this.SubmitSale.Name = "SubmitSale";
            this.SubmitSale.Size = new System.Drawing.Size(213, 34);
            this.SubmitSale.TabIndex = 49;
            this.SubmitSale.Text = "SUBMIT";
            this.SubmitSale.UseVisualStyleBackColor = true;
            this.SubmitSale.Click += new System.EventHandler(this.SubmitSale_Click);
            // 
            // ViewStock
            // 
            this.ViewStock.Controls.Add(this.label7);
            this.ViewStock.Controls.Add(this.ModelStock);
            this.ViewStock.Controls.Add(this.StockAvail);
            this.ViewStock.Controls.Add(this.label9);
            this.ViewStock.Controls.Add(this.CompanyStock);
            this.ViewStock.Controls.Add(this.label10);
            this.ViewStock.Controls.Add(this.label11);
            this.ViewStock.Location = new System.Drawing.Point(4, 27);
            this.ViewStock.Name = "ViewStock";
            this.ViewStock.Padding = new System.Windows.Forms.Padding(3);
            this.ViewStock.Size = new System.Drawing.Size(780, 453);
            this.ViewStock.TabIndex = 1;
            this.ViewStock.Text = "View Stock";
            this.ViewStock.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(277, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 32);
            this.label7.TabIndex = 92;
            this.label7.Text = "View Stock";
            // 
            // ModelStock
            // 
            this.ModelStock.FormattingEnabled = true;
            this.ModelStock.Location = new System.Drawing.Point(355, 193);
            this.ModelStock.Name = "ModelStock";
            this.ModelStock.Size = new System.Drawing.Size(220, 26);
            this.ModelStock.TabIndex = 88;
            this.ModelStock.SelectedIndexChanged += new System.EventHandler(this.ModelStock_SelectedIndexChanged);
            // 
            // StockAvail
            // 
            this.StockAvail.Enabled = false;
            this.StockAvail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockAvail.Location = new System.Drawing.Point(337, 250);
            this.StockAvail.Name = "StockAvail";
            this.StockAvail.Size = new System.Drawing.Size(238, 24);
            this.StockAvail.TabIndex = 87;
            this.StockAvail.TextChanged += new System.EventHandler(this.StockAvail_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(157, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 18);
            this.label9.TabIndex = 86;
            this.label9.Text = "Stock Availabale: ";
            // 
            // CompanyStock
            // 
            this.CompanyStock.DisplayMember = "Cname";
            this.CompanyStock.FormattingEnabled = true;
            this.CompanyStock.Location = new System.Drawing.Point(368, 148);
            this.CompanyStock.Name = "CompanyStock";
            this.CompanyStock.Size = new System.Drawing.Size(207, 26);
            this.CompanyStock.TabIndex = 85;
            this.CompanyStock.ValueMember = "CompId";
            this.CompanyStock.SelectedIndexChanged += new System.EventHandler(this.CompanyStock_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(157, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 18);
            this.label10.TabIndex = 83;
            this.label10.Text = "Select Model Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(154, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 18);
            this.label11.TabIndex = 82;
            this.label11.Text = "Select Company Name:";
            // 
            // SearchCustomerByIMEINO
            // 
            this.SearchCustomerByIMEINO.Controls.Add(this.dataGridView1);
            this.SearchCustomerByIMEINO.Controls.Add(this.linkLabel1);
            this.SearchCustomerByIMEINO.Controls.Add(this.IMEINumber);
            this.SearchCustomerByIMEINO.Controls.Add(this.label8);
            this.SearchCustomerByIMEINO.Location = new System.Drawing.Point(4, 27);
            this.SearchCustomerByIMEINO.Name = "SearchCustomerByIMEINO";
            this.SearchCustomerByIMEINO.Padding = new System.Windows.Forms.Padding(3);
            this.SearchCustomerByIMEINO.Size = new System.Drawing.Size(780, 453);
            this.SearchCustomerByIMEINO.TabIndex = 2;
            this.SearchCustomerByIMEINO.Text = "Search Customer By IMEINO";
            this.SearchCustomerByIMEINO.UseVisualStyleBackColor = true;
            this.SearchCustomerByIMEINO.Click += new System.EventHandler(this.SearchCustomerByIMEINO_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CusstomerName,
            this.MobileNumberS,
            this.EmailId,
            this.AddressS});
            this.dataGridView1.Location = new System.Drawing.Point(31, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(718, 150);
            this.dataGridView1.TabIndex = 73;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Salmon;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Green;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(318, 111);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 23);
            this.linkLabel1.TabIndex = 72;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Search";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // IMEINumber
            // 
            this.IMEINumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMEINumber.Location = new System.Drawing.Point(321, 54);
            this.IMEINumber.Name = "IMEINumber";
            this.IMEINumber.Size = new System.Drawing.Size(241, 24);
            this.IMEINumber.TabIndex = 71;
            this.IMEINumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 18);
            this.label8.TabIndex = 70;
            this.label8.Text = "Enter IMEI Number:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(650, 498);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(156, 34);
            this.Logout.TabIndex = 2;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click_1);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Red;
            this.label33.Location = new System.Drawing.Point(162, 253);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(132, 25);
            this.label33.TabIndex = 8;
            this.label33.Text = "2051120196";
            this.label33.Click += new System.EventHandler(this.label33_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Red;
            this.label32.Location = new System.Drawing.Point(114, 197);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(227, 25);
            this.label32.TabIndex = 7;
            this.label32.Text = "Lê Quang Vân Trường";
            this.label32.Click += new System.EventHandler(this.label32_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label31.Location = new System.Drawing.Point(92, 127);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(258, 32);
            this.label31.TabIndex = 6;
            this.label31.Text = "SHOPPE MOBILE";
            this.label31.Click += new System.EventHandler(this.label31_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(868, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 498);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "About me!";
            // 
            // CusstomerName
            // 
            this.CusstomerName.DataPropertyName = "cust_name";
            this.CusstomerName.HeaderText = "CusstomerName";
            this.CusstomerName.MinimumWidth = 6;
            this.CusstomerName.Name = "CusstomerName";
            this.CusstomerName.Width = 125;
            // 
            // MobileNumberS
            // 
            this.MobileNumberS.DataPropertyName = "MobileNumber";
            this.MobileNumberS.HeaderText = "MobileNumber";
            this.MobileNumberS.MinimumWidth = 6;
            this.MobileNumberS.Name = "MobileNumberS";
            this.MobileNumberS.Width = 125;
            // 
            // EmailId
            // 
            this.EmailId.DataPropertyName = "EmailId";
            this.EmailId.HeaderText = "EmailId";
            this.EmailId.MinimumWidth = 6;
            this.EmailId.Name = "EmailId";
            this.EmailId.Width = 125;
            // 
            // AddressS
            // 
            this.AddressS.DataPropertyName = "Address";
            this.AddressS.HeaderText = "Address";
            this.AddressS.MinimumWidth = 6;
            this.AddressS.Name = "AddressS";
            this.AddressS.Width = 125;
            // 
            // userhomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 535);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.tabControl1);
            this.Name = "userhomepage";
            this.Text = "User Home Page";
            this.Load += new System.EventHandler(this.userhomepage_Load);
            this.tabControl1.ResumeLayout(false);
            this.Sales.ResumeLayout(false);
            this.Sales.PerformLayout();
            this.ViewStock.ResumeLayout(false);
            this.ViewStock.PerformLayout();
            this.SearchCustomerByIMEINO.ResumeLayout(false);
            this.SearchCustomerByIMEINO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ViewStock;
        private System.Windows.Forms.TabPage SearchCustomerByIMEINO;
        private System.Windows.Forms.TabPage Sales;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox EmailSale;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label ggggg;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button SubmitSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ModelName;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CompanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Cust_name;
        private System.Windows.Forms.TextBox MobileNumber;
        private System.Windows.Forms.ComboBox IMEINONumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ModelStock;
        private System.Windows.Forms.TextBox StockAvail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CompanyStock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox IMEINumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusstomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNumberS;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressS;
    }
}