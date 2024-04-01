using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablasDAL
{
    public class ClienteIngresoDal
    {
        public DataTable ClienteIng()
        {
            string consulta = "SELECT C.IDCLIENTE, C.NOMBRE AS Cliente, SUM(V.TOTAL) AS TotalIngresos\r\nFROM CLIENTE C\r\nJOIN VENTA V ON C.IDCLIENTE = V.IDCLIENTE\r\nGROUP BY C.IDCLIENTE, C.NOMBRE;\r\n";
            return conexion.EjecutarDataTabla(consulta, "papas");
        }
    }
}
