using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky
{
    internal class tbl_company_BLL
    {
        tbl_company_DAL dalCompany;
        public tbl_company_BLL()
        {
            dalCompany = new tbl_company_DAL();
        }
        public List<tbl_company> getAllCompany()
        {
            return dalCompany.getAllCompany();
        }
        public bool AddCompany(tbl_company company)
        {
            return dalCompany.AddCompany(company);
        }
    }
}
