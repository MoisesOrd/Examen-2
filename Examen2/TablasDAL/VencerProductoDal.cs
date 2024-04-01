using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablasDAL
{
    public class VencerProductoDal
    {
        public DataTable ProductosVencer()
        {
            string consulta = "SELECT *\r\nFROM DETALLEING\r\nWHERE FECHAVENC >= GETDATE() AND FECHAVENC <= DATEADD(day, 30, GETDATE());\r\n";

            return conexion.EjecutarDataTabla(consulta, "papas");
        }
    }
}
