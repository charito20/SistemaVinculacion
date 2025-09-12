namespace SistemaVinculacion.formsCoordinador
{
    partial class frmReporteCoodinador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteCoodinador));
            this.tsMenuCoordinador = new System.Windows.Forms.ToolStrip();
            this.tsbVolver = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslblNombre = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnCerrarSesion = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.btnGenerarPDF = new System.Windows.Forms.Button();
            this.cmbTiposReportes = new System.Windows.Forms.ComboBox();
            this.tsMenuCoordinador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenuCoordinador
            // 
            this.tsMenuCoordinador.BackColor = System.Drawing.Color.SeaGreen;
            this.tsMenuCoordinador.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMenuCoordinador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbVolver,
            this.toolStripSeparator1,
            this.tslblNombre,
            this.tsbtnCerrarSesion});
            this.tsMenuCoordinador.Location = new System.Drawing.Point(0, 0);
            this.tsMenuCoordinador.Name = "tsMenuCoordinador";
            this.tsMenuCoordinador.Size = new System.Drawing.Size(1067, 27);
            this.tsMenuCoordinador.TabIndex = 70;
            this.tsMenuCoordinador.Text = "toolStrip1";
            // 
            // tsbVolver
            // 
            this.tsbVolver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbVolver.Image = ((System.Drawing.Image)(resources.GetObject("tsbVolver.Image")));
            this.tsbVolver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVolver.Name = "tsbVolver";
            this.tsbVolver.Size = new System.Drawing.Size(29, 24);
            this.tsbVolver.Text = "toolStripButton1";
            this.tsbVolver.Click += new System.EventHandler(this.tsbVolver_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tslblNombre
            // 
            this.tslblNombre.Name = "tslblNombre";
            this.tslblNombre.Size = new System.Drawing.Size(64, 24);
            this.tslblNombre.Text = "Nombre";
            // 
            // tsbtnCerrarSesion
            // 
            this.tsbtnCerrarSesion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCerrarSesion.Image")));
            this.tsbtnCerrarSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCerrarSesion.Name = "tsbtnCerrarSesion";
            this.tsbtnCerrarSesion.Size = new System.Drawing.Size(29, 24);
            this.tsbtnCerrarSesion.Text = "Cerrar Sesión";
            this.tsbtnCerrarSesion.Click += new System.EventHandler(this.tsbtnCerrarSesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 72;
            this.label1.Text = "Reportes";
            // 
            // dgvReportes
            // 
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Location = new System.Drawing.Point(22, 98);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.RowHeadersWidth = 51;
            this.dgvReportes.RowTemplate.Height = 24;
            this.dgvReportes.Size = new System.Drawing.Size(1027, 410);
            this.dgvReportes.TabIndex = 73;
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGenerarPDF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerarPDF.Location = new System.Drawing.Point(934, 68);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(115, 28);
            this.btnGenerarPDF.TabIndex = 74;
            this.btnGenerarPDF.Text = "GenerarPDF";
            this.btnGenerarPDF.UseVisualStyleBackColor = false;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // cmbTiposReportes
            // 
            this.cmbTiposReportes.FormattingEnabled = true;
            this.cmbTiposReportes.Location = new System.Drawing.Point(22, 72);
            this.cmbTiposReportes.Name = "cmbTiposReportes";
            this.cmbTiposReportes.Size = new System.Drawing.Size(228, 24);
            this.cmbTiposReportes.TabIndex = 76;
            this.cmbTiposReportes.SelectedIndexChanged += new System.EventHandler(this.cmbTiposReportes_SelectedIndexChanged);
            // 
            // frmReporteCoodinador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cmbTiposReportes);
            this.Controls.Add(this.btnGenerarPDF);
            this.Controls.Add(this.dgvReportes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsMenuCoordinador);
            this.Name = "frmReporteCoodinador";
            this.Text = "frmReporteCoordinador";
            this.tsMenuCoordinador.ResumeLayout(false);
            this.tsMenuCoordinador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenuCoordinador;
        private System.Windows.Forms.ToolStripButton tsbVolver;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslblNombre;
        private System.Windows.Forms.ToolStripButton tsbtnCerrarSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.Button btnGenerarPDF;
        private System.Windows.Forms.ComboBox cmbTiposReportes;
    }
}