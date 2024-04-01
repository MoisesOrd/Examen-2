using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablasDAL
{
    public class IngresoProveedorDal
    {
        public DataTable IngresoProveedor()
        {
            string consulta = "string consulta = \"SELECT PERSONA.NOMBRE, PERSONA.APELLIDO\\r\\nFROM    CLIENTE INNER JOIN\\r\\n   PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA\";\r\n            return conexion.EjecutarDataTabla(consulta, \"papas\");";
            return conexion.EjecutarDataTabla(consulta, "papas");
        }
    }
}
