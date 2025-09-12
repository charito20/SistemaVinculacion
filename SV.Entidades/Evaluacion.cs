using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV.Entidades
{
    public class Evaluacion
    {
        public int IdEvaluacion { get; set; }
        public int IdProyecto { get; set; }
        public int IdUsuario { get; set; } // Quien evalúa (Tutor o Coordinador)
        public DateTime FechaEvaluacion { get; set; }
        public decimal Calificacion { get; set; }
        public string Observaciones { get; set; }
    }
}
