using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky
{
    internal class tbl_mobile_BLL
    {
        tbl_mobile_DAL dalmobile;
        public tbl_mobile_BLL()
        {
            dalmobile = new tbl_mobile_DAL();
        }
        public List<tbl_mobile> getMobileByModel(string modelId)
        {
            return dalmobile.getMobileByModel(modelId);
        }
        public bool AddMobile(tbl_mobile mobile)
        {
            return dalmobile.AddMobile(mobile);
        }
       
    }
}
