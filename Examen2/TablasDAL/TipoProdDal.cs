using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablasDAL
{
    public class TipoProdDal
    {
        public DataTable ProductosTipo()
        {
            string consulta = "SELECT TP.NOMBRE AS TipoProducto, SUM(DV.CANTIDAD) AS CantidadTotalVendida\r\nFROM TIPOPROD TP\r\nJOIN PRODUCTO P ON TP.IDTIPOPROD = P.IDTIPOPROD\r\nJOIN DETALLEVENTA DV ON P.IDPRODUCTO = DV.IDPRODUCTO\r\nGROUP BY TP.NOMBRE;\r\n";

            return conexion.EjecutarDataTabla(consulta, "papas");
        }
    }
}
