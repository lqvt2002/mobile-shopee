using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky
{
    internal class tbl_transaction_BLL
    {
        tbl_transaction_DAL daltransaction;
        public tbl_transaction_BLL()
        {
            daltransaction = new tbl_transaction_DAL();
        }
        public List<tbl_transaction> getAllTransaction()
        {
            return daltransaction.getAllTransaction();
        }
        public bool UpdateTransaction(tbl_transaction transaction)
        {
            return daltransaction.AddTransaction(transaction);
        }
    }
}
