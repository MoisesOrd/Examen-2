using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablasDAL;

namespace TablasBss
{
    public class ClienteBss
    {
        ClienteDal dal = new ClienteDal();
        public DataTable ClienteDatosBss()
        {
            return dal.ClientesDatos();
        }


    }
}
