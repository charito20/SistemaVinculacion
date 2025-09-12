using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV.Entidades
{
    public class Proyecto
    {
        public int IdProyecto { get; set; }
        public string NombreProyecto { get; set; }
        public string TipoProyecto { get; set; }
        public string Descripcion { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string EstadoProyecto { get; set; }
    }
}
