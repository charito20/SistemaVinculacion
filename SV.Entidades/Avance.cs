using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV.Entidades
{
    public class Avance
    {
        public int IdAvance { get; set; }
        public int IdProyecto { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Descripcion { get; set; }
        public string DocumentoUrl { get; set; } // si sube archivo
        public string Estado { get; set; }
    }
}
