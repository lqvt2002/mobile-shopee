using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky
{
    internal class tbl_model_BLL
    {
        tbl_model_DAL dalmodel;
        public tbl_model_BLL()
        {
            dalmodel = new tbl_model_DAL();
        }
        public List<tbl_model> getAllModel()
        {
            return dalmodel.getAllModel();
        }
        public List<tbl_model> getModelByCompany(string CompId)
        {
            return dalmodel.getModelByCompany(CompId);
        }
        public bool AddModel(tbl_model model)
        {
            return dalmodel.AddModel(model);
        }
        public int ModelAvail(string ModelId)
        {
            return dalmodel.ModelAvail(ModelId);
        }
    }
}
