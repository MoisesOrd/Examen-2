using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablasDAL
{
    public class ProveedorSuministroDal
    {
        public DataTable ProveedorSum()
        {
            string consulta = "SELECT TOP 1 PR.NOMBRE AS Proveedor, COUNT(PV.IDPRODUCTO) AS CantidadProductosSuministrados\r\nFROM PROVEEDOR PR\r\nJOIN PROVEE PV ON PR.IDPROVEEDOR = PV.IDPROVEEDOR\r\nGROUP BY PR.NOMBRE\r\nORDER BY CantidadProductosSuministrados DESC;\r\n";
            return conexion.EjecutarDataTabla(consulta, "papas");
        }
    }
}
