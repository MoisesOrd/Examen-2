using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablasDAL;

namespace TablasBss
{
    public class VendedorBss
    {
        VendedorDal dal = new VendedorDal();
        public DataTable DatosVendedor()
        {
            return dal.Vendedor();
        }
    }
}
