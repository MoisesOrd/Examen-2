using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablasDAL;

namespace TablasBss
{
    public class TipoProductBss
    {
        TipoProdDal dal = new TipoProdDal();
        public DataTable ProductsTipo()
        {
            return dal.ProductosTipo();
        }
    }
}
