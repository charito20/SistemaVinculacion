using SV.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV.Logica
{
    public class NotificacionLogica
    {
        private readonly NotificacionData notiData = new NotificacionData();

        public int EnviarNotificacion(int idUsuario, string titulo, string mensaje)
        {
            if (idUsuario <= 0 || string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(mensaje))
                throw new Exception("Campos obligatorios incompletos");

            return notiData.EnviarNotificacion(idUsuario, titulo, mensaje);
        }

        public DataTable ObtenerNotificaciones(int idUsuario)
        {
            if (idUsuario <= 0) throw new Exception("Usuario inválido");
            return notiData.ObtenerNotificaciones(idUsuario);
        }

        public void MarcarNotificacionLeida(int idNotificacion)
        {
            if (idNotificacion <= 0) throw new Exception("Notificación inválida");
            notiData.MarcarNotificacionLeida(idNotificacion);
        }
    }
}
