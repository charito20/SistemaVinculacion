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
    public partial class FrmProyectos : Form
    {
        private Usuario usuarioLogueado;
        public FrmProyectos(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
            tslblNombre.Text = $"{usuario.Nombres} {usuario.Apellidos}";
            this.Load += FrmProyectos_Load;
            this.btnVerProyecto.Click += btnVerProyecto_Click;

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

        private void FrmProyectos_Load(object sender, EventArgs e)
        {
            try
            {
                SV.Logica.ProyectoLogica proyectoLogica = new SV.Logica.ProyectoLogica();
                dgvProyectos.DataSource = proyectoLogica.ObtenerProyectos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proyectos: " + ex.Message);
            }
        }

        private void btnVerProyecto_Click(object sender, EventArgs e)
        {
            if (dgvProyectos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un proyecto.");
                return;
            }

            int idProyecto = Convert.ToInt32(dgvProyectos.SelectedRows[0].Cells["IdProyecto"].Value);

            SV.Logica.AvanceLogica avanceLogica = new SV.Logica.AvanceLogica();
            DataTable avances = avanceLogica.ObtenerAvances(idProyecto);

            if (avances.Rows.Count == 0)
            {
                MessageBox.Show("No hay avances/documentos para este proyecto.");
                return;
            }

            DataRow avanceFinal = avances.Rows[avances.Rows.Count - 1]; 
            string documentoUrl = avanceFinal["DocumentoUrl"].ToString();

            if (string.IsNullOrEmpty(documentoUrl))
            {
                MessageBox.Show("No hay documento final disponible.");
                return;
            }

            try
            {
                System.Diagnostics.Process.Start(documentoUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el documento: " + ex.Message);
            }
        }
    }
}
