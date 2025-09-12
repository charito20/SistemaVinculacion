using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV.Datos
{
    public class AvanceData
    {
        private readonly ConexionBD conexion = new ConexionBD();

        public int RegistrarAvance(int idProyecto, string nombreAvance, DateTime fechaAvance, string observacion, int creadoPor, byte[] archivo)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_RegistrarAvance", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProyecto", idProyecto);
                cmd.Parameters.AddWithValue("@nombreAvance", nombreAvance);
                cmd.Parameters.AddWithValue("@fechaAvance", fechaAvance);
                cmd.Parameters.AddWithValue("@observacionAvance", observacion);
                cmd.Parameters.AddWithValue("@creadoPor", creadoPor);
                cmd.Parameters.AddWithValue("@archivoAdjunto", archivo ?? (object)DBNull.Value);

                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int RegistrarActividad(int idProyecto, string nombreActividad, string descripcion, DateTime inicio, DateTime fin)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_RegistrarActividad", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProyecto", idProyecto);
                cmd.Parameters.AddWithValue("@nombreActividad", nombreActividad);
                cmd.Parameters.AddWithValue("@descripcionActividad", descripcion);
                cmd.Parameters.AddWithValue("@fechaInicio", inicio);
                cmd.Parameters.AddWithValue("@fechaFin", fin);

                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public DataTable ObtenerAvances(int idProyecto)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerAvances", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProyecto", idProyecto);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
