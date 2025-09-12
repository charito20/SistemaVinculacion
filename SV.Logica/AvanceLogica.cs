using SV.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV.Logica
{
    public class AvanceLogica
    {
        private readonly AvanceData avanceData = new AvanceData();

        public int RegistrarAvance(int idProyecto, string nombreAvance, DateTime fechaAvance, string observacion, int creadoPor, byte[] archivo)
        {
            if (string.IsNullOrEmpty(nombreAvance) || idProyecto <= 0 || creadoPor <= 0)
                throw new Exception("Campos obligatorios incompletos");

            return avanceData.RegistrarAvance(idProyecto, nombreAvance, fechaAvance, observacion, creadoPor, archivo);
        }

        public int RegistrarActividad(int idProyecto, string nombreActividad, string descripcion, DateTime inicio, DateTime fin)
        {
            if (string.IsNullOrEmpty(nombreActividad) || idProyecto <= 0)
                throw new Exception("Campos obligatorios incompletos");

            return avanceData.RegistrarActividad(idProyecto, nombreActividad, descripcion, inicio, fin);
        }

        public DataTable ObtenerAvances(int idProyecto)
        {
            if (idProyecto <= 0) throw new Exception("Proyecto inválido");
            return avanceData.ObtenerAvances(idProyecto);
        }
    }
}
