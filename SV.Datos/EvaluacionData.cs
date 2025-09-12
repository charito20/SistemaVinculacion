using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV.Datos
{
    public class EvaluacionData
    {
        private readonly ConexionBD conexion = new ConexionBD();

        public int RegistrarEvaluacion(int idProyecto, int evaluadoPor, DateTime fecha, string observaciones, decimal puntajeTotal)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_RegistrarEvaluacion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProyecto", idProyecto);
                cmd.Parameters.AddWithValue("@evaluadoPor", evaluadoPor);
                cmd.Parameters.AddWithValue("@fechaEvaluacion", fecha);
                cmd.Parameters.AddWithValue("@observaciones", observaciones);
                cmd.Parameters.AddWithValue("@puntajeTotal", puntajeTotal);

                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void RegistrarDetalleEvaluacion(int idEvaluacion, string criterio, decimal puntajeMax, decimal puntajeObtenido)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_RegistrarDetalleEvaluacion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEvaluacion", idEvaluacion);
                cmd.Parameters.AddWithValue("@criterio", criterio);
                cmd.Parameters.AddWithValue("@puntajeMax", puntajeMax);
                cmd.Parameters.AddWithValue("@puntajeObtenido", puntajeObtenido);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerEvaluaciones(int idProyecto)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerEvaluaciones", con);
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
