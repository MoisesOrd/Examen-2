using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablasDAL
{
    public class ClienteMontoDal
    {
        public DataTable ClienteMonto()
        {
            string consulta = "DECLARE @monto_especificado MONEY;\r\nSET @monto_especificado = 100; \r\n\r\nSELECT C.IDCLIENTE, C.NOMBRE AS Cliente, SUM(V.TOTAL) AS TotalCompras\r\nFROM CLIENTE C\r\nJOIN VENTA V ON C.IDCLIENTE = V.IDCLIENTE\r\nGROUP BY C.IDCLIENTE, C.NOMBRE\r\nHAVING SUM(V.TOTAL) > @monto_especificado;\r\n";
            return conexion.EjecutarDataTabla(consulta, "papas");
        }
    }
}
