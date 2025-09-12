using SV.Datos;
using SV.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV.Logica
{
    public class UsuarioLogica
    {
        private readonly UsuarioData usuarioData = new UsuarioData();

        //LOGIN
        public DataTable Login(string correo, string contrasena)
        {
            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasena))
                throw new Exception("Correo y contraseña son obligatorios");

            return usuarioData.Login(correo, contrasena);
        }

        public Usuario LoginUsuario(string correo, string contrasena)
        {
            DataTable dt = Login(correo, contrasena); // llama al método que ya tienes

            if (dt.Rows.Count == 0)
                return null;

            // Crear objeto Usuario a partir de la fila del DataTable
            Usuario usuario = new Usuario
            {
                IdUsuario = Convert.ToInt32(dt.Rows[0]["idUsuario"]),
                Nombres = dt.Rows[0]["nombres"].ToString(),
                Apellidos = dt.Rows[0]["apellidos"].ToString(),
                CorreoInstitucional = dt.Rows[0]["correoInstitucional"].ToString(),
                Rol = dt.Rows[0]["rol"].ToString()
            };

            return usuario;
        }

        //REGISTRAR USUARIO
        public int Registrar(string nombres, string apellidos, string correo, string contrasena, string rol)
        {
            if (string.IsNullOrEmpty(nombres) || string.IsNullOrEmpty(apellidos) ||
                string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasena) || string.IsNullOrEmpty(rol))
                throw new Exception("Todos los campos son obligatorios");

            //(Agregar otras validaciones: email válido, longitud de contraseña, etc)
            return usuarioData.Registrar(nombres, apellidos, correo, contrasena, rol);
        }

        //OBTENER USUARIOS POR ROL
        public DataTable ObtenerUsuariosPorRol(string rol)
        {
            if (string.IsNullOrEmpty(rol))
                throw new Exception("El rol es obligatorio");

            return usuarioData.ObtenerUsuariosPorRol(rol);
        }
    }
}
