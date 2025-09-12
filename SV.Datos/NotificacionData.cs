using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV.Datos
{
    public class NotificacionData
    {
        private readonly ConexionBD conexion = new ConexionBD();

        public int EnviarNotificacion(int idUsuario, string titulo, string mensaje)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EnviarNotificacion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@titulo", titulo);
                cmd.Parameters.AddWithValue("@mensaje", mensaje);

                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public DataTable ObtenerNotificaciones(int idUsuario)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerNotificaciones", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void MarcarNotificacionLeida(int idNotificacion)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_MarcarNotificacionLeida", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idNotificacion", idNotificacion);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
