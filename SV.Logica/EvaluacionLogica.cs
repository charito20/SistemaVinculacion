using SV.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV.Logica
{
    public class EvaluacionLogica
    {
        private readonly EvaluacionData evaluacionData = new EvaluacionData();

        public int RegistrarEvaluacion(int idProyecto, int evaluadoPor, DateTime fecha, string observaciones, decimal puntajeTotal)
        {
            if (idProyecto <= 0 || evaluadoPor <= 0)
                throw new Exception("Proyecto y evaluador inválidos");
            if (puntajeTotal < 0 || puntajeTotal > 10)
                throw new Exception("Puntaje total debe ser entre 0 y 10");

            return evaluacionData.RegistrarEvaluacion(idProyecto, evaluadoPor, fecha, observaciones, puntajeTotal);
        }

        public void RegistrarDetalleEvaluacion(int idEvaluacion, string criterio, decimal puntajeMax, decimal puntajeObtenido)
        {
            if (string.IsNullOrEmpty(criterio)) throw new Exception("Criterio obligatorio");
            evaluacionData.RegistrarDetalleEvaluacion(idEvaluacion, criterio, puntajeMax, puntajeObtenido);
        }

        public DataTable ObtenerEvaluaciones(int idProyecto)
        {
            return evaluacionData.ObtenerEvaluaciones(idProyecto);
        }
    }
}
