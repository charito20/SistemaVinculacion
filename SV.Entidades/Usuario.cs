using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string CorreoInstitucional { get; set; }
        public string Clave { get; set; }
        public string Rol { get; set; }
    }
}
