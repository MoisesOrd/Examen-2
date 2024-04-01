using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablasDAL;

namespace TablasBss
{
    public class ProveedorSuminBss
    {
        ProveedorSuministroDal dal = new ProveedorSuministroDal();
        public DataTable ProveedorSuministrosTop()
        {
            return dal.ProveedorSum();
        }
    }
}
