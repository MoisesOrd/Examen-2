using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablasDAL;

namespace TablasBss
{
    public class ClienteMontBss
    {
        ClienteMontoDal dal = new ClienteMontoDal();
        public DataTable ClienteDatosMont()
        {
            return dal.ClienteMonto();
        }
    }
}
