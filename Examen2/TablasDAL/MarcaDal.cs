using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TablasDAL
{

    public class MarcaDal
    {
        public DataTable Marca() 
        { 
            string consulta = "SELECT M.NOMBRE AS Marca, SUM(DV.CANTIDAD) AS TotalVentas\r\nFROM MARCA M\r\nJOIN PRODUCTO P ON M.IDMARCA = P.IDMARCA\r\nJOIN DETALLEVENTA DV ON P.IDPRODUCTO = DV.IDPRODUCTO\r\nGROUP BY M.NOMBRE\r\nORDER BY TotalVentas DESC\r\nLIMIT 1;\r\n";

            return conexion.EjecutarDataTabla(consulta, "papas");
        }
    }
}
