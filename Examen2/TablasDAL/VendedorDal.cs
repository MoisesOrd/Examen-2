using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablasDAL
{
    public class VendedorDal
    {
        public DataTable Vendedor()
        {
            string consulta = " SELECT U.NOMBREUSER AS Vendedor, COUNT(DV.IDPRODUCTO) AS CantidadProductosVendidos\r\nFROM USUARIO U\r\nLEFT JOIN VENTA V ON U.IDUSUARIO = V.IDVENDEDOR\r\nLEFT JOIN DETALLEVENTA DV ON V.IDVENTA = DV.IDVENTA\r\nGROUP BY U.NOMBREUSER;\r\n";
            return conexion.EjecutarDataTabla(consulta, "papas");
        }
    }
}
