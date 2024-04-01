using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablasDAL;

namespace TablasBss
{
    public class ClienteIngresoBss
    {
        public class ClienteIngresoss
        {
            ClienteIngresoDal dal = new ClienteIngresoDal();
            public DataTable IngCliente()
            {
                return dal.ClienteIng();
            }
        }
    }
}
