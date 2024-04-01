using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablasDAL;

namespace TablasBss
{
    public class ProveedorBss
    {
        IngresoProveedorDal dal =new IngresoProveedorDal();
        public DataTable ProveedorDatos()
        {
            return dal.IngresoProveedor();
        }
    }
}
