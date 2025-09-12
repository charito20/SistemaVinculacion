using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV.Datos
{
    public class ProyectoData
    {
        private readonly ConexionBD conexion = new ConexionBD();

        public int CrearProyecto(string nombre, string tipo, DateTime inicio, DateTime fin, string estado, string objetivo, string alcance)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_CrearProyecto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreProyecto", nombre);
                cmd.Parameters.AddWithValue("@tipoProyecto", tipo);
                cmd.Parameters.AddWithValue("@fechaInicioProyecto", inicio);
                cmd.Parameters.AddWithValue("@fechaFinalProyecto", fin);
                cmd.Parameters.AddWithValue("@estadoProyecto", estado);
                cmd.Parameters.AddWithValue("@objetivoGeneral", objetivo);
                cmd.Parameters.AddWithValue("@alcance", alcance);

                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void AsignarUsuarioProyecto(int idUsuario, int idProyecto)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_AsignarUsuarioProyecto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@idProyecto", idProyecto);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerProyectos()
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerProyectos", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
