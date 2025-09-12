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
    }
}
