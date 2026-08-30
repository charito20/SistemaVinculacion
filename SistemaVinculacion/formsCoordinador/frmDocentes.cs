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
    public partial class frmDocentes : Form
    {
        private Usuario usuarioLogueado;
        public frmDocentes(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
            tslblNombre.Text = $"{usuario.Nombres} {usuario.Apellidos}";
            this.Load += frmDocentes_Load;
            this.btnAsignarTutor.Click += btnAsignarTutor_Click;
        }

        private void tsbtnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void tsbVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuCoordinador MenuCoordinador = new frmMenuCoordinador(usuarioLogueado);
            MenuCoordinador.Show();
        }

        private void frmDocentes_Load(object sender, EventArgs e)
        {
            try
            {
                SV.Logica.UsuarioLogica usuarioLogica = new SV.Logica.UsuarioLogica();
                DataTable usuarios = usuarioLogica.ObtenerUsuariosPorRol("Tutor");
                DataView dv = usuarios.DefaultView;
                dv.RowFilter = "Rol = 'Tutor'";
                dgvTutores.DataSource = dv;

                SV.Logica.ProyectoLogica proyectoLogica = new SV.Logica.ProyectoLogica();
                dgvProyectosAsignables.DataSource = proyectoLogica.ObtenerProyectos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btnAsignarTutor_Click(object sender, EventArgs e)
        {
            if (dgvTutores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un tutor.");
                return;
            }
            if (dgvProyectosAsignables.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un proyecto.");
                return;
            }

            int idTutor = Convert.ToInt32(dgvTutores.SelectedRows[0].Cells["IdUsuario"].Value);
            int idProyecto = Convert.ToInt32(dgvProyectosAsignables.SelectedRows[0].Cells["IdProyecto"].Value);

            try
            {
                SV.Logica.ProyectoLogica proyectoLogica = new SV.Logica.ProyectoLogica();
                proyectoLogica.AsignarUsuarioProyecto(idTutor, idProyecto);
                MessageBox.Show("Tutor asignado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar tutor: " + ex.Message);
            }
        }
    }
}
