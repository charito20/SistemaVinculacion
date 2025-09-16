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
            "Server=tcp:uteqvinculacion.database.windows.net,1433;Database=BDVinculacionUTEQ;Persist Security Info=False;User ID=advinculacion;Password=software2025!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
