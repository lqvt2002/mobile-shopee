using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky
{
    internal class tbl_transaction
    {
        public string TransId { get; set; }
        public string ModelId { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }

    }
}
