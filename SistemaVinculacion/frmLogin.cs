using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SV.Logica;
using SV.Entidades;
using SistemaVinculacion.formsEstudiantes;
using SistemaVinculacion.formsTutor;
using SistemaVinculacion.formsDirector;
using SistemaVinculacion.formsCoordinador;


namespace SistemaVinculacion
{
    public partial class frmLogin : Form
    {
        private readonly UsuarioLogica usuarioLogica = new UsuarioLogica();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            string clave = txtContraseña.Text.Trim();

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Debe ingresar el correo y la contraseña.",
                                "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario usuario = usuarioLogica.LoginUsuario(correo, clave);

            if (usuario != null)
            {
                MessageBox.Show($"Bienvenido {usuario.Nombres} {usuario.Apellidos}",
                                "Ingreso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Ingresa según el rol
                switch (usuario.Rol)
                {
                    case "Estudiante":
                        frmMenuEstudiante menuE = new frmMenuEstudiante(usuario);
                        menuE.Show();
                        break;

                    case "Tutor":
                        frmMenuTutor menuT = new frmMenuTutor(usuario);
                        menuT.Show();
                        break;

                    case "Director":
                        frmMenuDirector menuD = new frmMenuDirector(usuario);
                        menuD.Show();
                        break;

                    case "Coordinador":
                        frmMenuCoordinador menuC = new frmMenuCoordinador(usuario);
                        menuC.Show();
                        break;

                    default:
                        MessageBox.Show("Rol no reconocido. Contacte al administrador.");
                        break;
                }

                this.Hide(); // ocultar login
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.",
                                "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
