using SV.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVinculacion.formsCoordinador
{
    public partial class frmEstudiantes : Form
    {
        private Usuario usuarioLogueado;
        public frmEstudiantes(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
            tslblNombre.Text = $"{usuario.Nombres} {usuario.Apellidos}";
            this.Load += frmEstudiantes_Load;
        }

        private void tsbtnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void tslblNombre_Click(object sender, EventArgs e)
        {
        }

        private void tsbVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuCoordinador MenuCoordinador = new frmMenuCoordinador(usuarioLogueado);
            MenuCoordinador.Show();
        }

        private void frmEstudiantes_Load(object sender, EventArgs e)
        {
            try
            {
                SV.Logica.UsuarioLogica usuarioLogica = new SV.Logica.UsuarioLogica();
                DataTable usuarios = usuarioLogica.ObtenerUsuariosPorRol("Estudiante"); 
                dgvEstudiantes.DataSource = usuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los estudiantes: " + ex.Message);
            }
        }
    }
}
