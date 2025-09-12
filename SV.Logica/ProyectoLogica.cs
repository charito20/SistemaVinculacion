using SV.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV.Logica
{
    public class ProyectoLogica
    {
        private readonly ProyectoData proyectoData = new ProyectoData();

        public int CrearProyecto(string nombre, string tipo, DateTime inicio, DateTime fin, string estado, string objetivo, string alcance)
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(tipo) || string.IsNullOrEmpty(estado))
                throw new Exception("Nombre, tipo y estado son obligatorios");

            return proyectoData.CrearProyecto(nombre, tipo, inicio, fin, estado, objetivo, alcance);
        }

        public void AsignarUsuarioProyecto(int idUsuario, int idProyecto)
        {
            if (idUsuario <= 0 || idProyecto <= 0)
                throw new Exception("Usuario y proyecto inválidos");

            proyectoData.AsignarUsuarioProyecto(idUsuario, idProyecto);
        }

        public DataTable ObtenerProyectos()
        {
            return proyectoData.ObtenerProyectos();
        }
    }
}
