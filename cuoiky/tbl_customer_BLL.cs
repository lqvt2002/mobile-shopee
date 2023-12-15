using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky
{
    internal class tbl_customer_BLL
    {
        tbl_customer_DAL dalcustomer;
        public tbl_customer_BLL()
        {
            dalcustomer = new tbl_customer_DAL();
        }
        public DataTable getCustomerByIMEI(string IMEI)
        {
            return dalcustomer.getCustomerByIMEI(IMEI);
        }

        public bool AddCustomer(tbl_customer customer)
        {
            return dalcustomer.AddCustomer(customer);
        }
    }
}
