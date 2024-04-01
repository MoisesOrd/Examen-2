using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablasDAL;

namespace TablasBss
{
    public class MarcaBss
    {
        MarcaDal dal = new MarcaDal();
        public DataTable MarcaDatosBss()
        {
            return dal.Marca();
        }
    }
}
