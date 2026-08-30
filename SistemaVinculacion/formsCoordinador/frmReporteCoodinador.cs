using SV.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;


namespace SistemaVinculacion.formsCoordinador
{
    public partial class frmReporteCoodinador : Form
    {
        private Usuario usuarioLogueado;
        public frmReporteCoodinador(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
            tslblNombre.Text = $"{usuario.Nombres} {usuario.Apellidos}";
            this.cmbTiposReportes.SelectedIndexChanged += cmbTiposReportes_SelectedIndexChanged;
            this.btnGenerarPDF.Click += btnGenerarPDF_Click;
        }

        private void tsbVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuCoordinador MenuCoordinador = new frmMenuCoordinador(usuarioLogueado);
            MenuCoordinador.Show();
        }

        private void tsbtnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void cmbTiposReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string tipoReporte = cmbTiposReportes.SelectedItem.ToString();
                DataTable datos = null;

                if (tipoReporte == "Estudiantes")
                {
                    SV.Logica.UsuarioLogica usuarioLogica = new SV.Logica.UsuarioLogica();
                    datos = usuarioLogica.ObtenerUsuariosPorRol("Estudiante");
                }
                else if (tipoReporte == "Docentes")
                {
                    SV.Logica.UsuarioLogica usuarioLogica = new SV.Logica.UsuarioLogica();
                    datos = usuarioLogica.ObtenerUsuariosPorRol("Tutor");
                }
                else if (tipoReporte == "Proyectos")
                {
                    SV.Logica.ProyectoLogica proyectoLogica = new SV.Logica.ProyectoLogica();
                    datos = proyectoLogica.ObtenerProyectos();
                }

                dgvReportes.DataSource = datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte: " + ex.Message);
            }
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReportes.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para exportar.");
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar reporte como PDF";
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                string filePath = saveFileDialog.FileName;

                // Usando iTextSharp para crear el PDF
                using (System.IO.FileStream stream = new System.IO.FileStream(filePath, System.IO.FileMode.Create))
                {
                    iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document();
                    iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    // Crear tabla PDF con el mismo número de columnas que el DataGridView
                    iTextSharp.text.pdf.PdfPTable pdfTable = new iTextSharp.text.pdf.PdfPTable(dgvReportes.ColumnCount);

                    // Encabezados
                    foreach (DataGridViewColumn column in dgvReportes.Columns)
                    {
                        pdfTable.AddCell(new iTextSharp.text.Phrase(column.HeaderText));
                    }

                    // Filas
                    foreach (DataGridViewRow row in dgvReportes.Rows)
                    {
                        if (row.IsNewRow) continue;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value?.ToString() ?? "");
                        }
                    }

                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }

                MessageBox.Show("PDF generado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message);
            }
        }
    }
}
