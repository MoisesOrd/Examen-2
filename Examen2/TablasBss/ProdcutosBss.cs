using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablasDAL;

namespace TablasBss
{
    public class ProdcutosBss
    {
        ProductosTotalDal dal = new ProductosTotalDal();
        public DataTable ProductosDatosBss()
        {
            
            return dal.Productos();
        }
    }

}