using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablasDAL;

namespace TablasBss
{
    public class VencerBss
    {
        VencerProductoDal dal = new VencerProductoDal();
        public DataTable ProductsVencer()
        {
            return dal.ProductosVencer();
        }
    }
}
