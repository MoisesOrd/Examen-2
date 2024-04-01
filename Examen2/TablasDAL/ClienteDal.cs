using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablasDAL
{
    public class ClienteDal
    {
        public DataTable ClientesDatos()
        {
            string consulta = "SELECT PERSONA.NOMBRE, PERSONA.APELLIDO\r\nFROM    CLIENTE INNER JOIN\r\n   PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA";
            return conexion.EjecutarDataTabla(consulta, "papas");
        }
    }
}
