using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky
{
    internal class tbl_sales_BLL
    {
        tbl_sales_DAL dalsales;
        public tbl_sales_BLL()
        {
            dalsales = new tbl_sales_DAL();
        }
      
        public DataTable getSaleByDay(DateTime day)
        {
            return  dalsales.getSaleByDay(day);
        }
        public DataTable getSaleByDateToDate(DateTime Starting, DateTime Ending)
        {
            return dalsales.getSaleByDateToDate(Starting, Ending);
        }
        public bool AddSales(tbl_sales sales)
        {
            return dalsales.AddSales(sales);
        }
    }
}
