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
    public partial class frmMenuCoordinador : Form
    {
        private Usuario usuarioLogueado;
        public frmMenuCoordinador(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
            tslblNombre.Text = $"{usuario.Nombres} {usuario.Apellidos}";
        }

        private void tsbtnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void frmMenuCoordinador_Load(object sender, EventArgs e)
        {

        }

        private void btnDocumentacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDocumentacionCoordinador DocumentacionCoordinador = new frmDocumentacionCoordinador(usuarioLogueado);
            DocumentacionCoordinador.Show();
        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProyectos ProyectosCoordinador = new FrmProyectos(usuarioLogueado);
            ProyectosCoordinador.Show();
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDocentes DocentesCoordinador = new frmDocentes(usuarioLogueado);
            DocentesCoordinador.Show();
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEstudiantes EstudiantesCoordinador = new frmEstudiantes(usuarioLogueado);
            EstudiantesCoordinador.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReporteCoodinador ReporteCoordinador = new frmReporteCoodinador(usuarioLogueado);
            ReporteCoordinador.Show();
        }
    }
}
