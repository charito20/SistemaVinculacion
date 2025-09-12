using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV.Datos
{
    public class ConexionBD
    {
        private readonly string cadenaConexion =
            "Server=DESKTOP-9SMDLH8;Database=VinculacionBDD;Integrated Security=true;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
