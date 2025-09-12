namespace SistemaVinculacion.formsCoordinador
{
    partial class frmDocumentacionCoordinador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocumentacionCoordinador));
            this.tsMenuCoordinador = new System.Windows.Forms.ToolStrip();
            this.tsbVolver = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslblNombre = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnCerrarSesion = new System.Windows.Forms.ToolStripButton();
            this.dgvDocumentos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDocumento = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.tsMenuCoordinador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).BeginInit();
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
            this.tsMenuCoordinador.Size = new System.Drawing.Size(1067, 31);
            this.tsMenuCoordinador.TabIndex = 67;
            this.tsMenuCoordinador.Text = "toolStrip1";
            // 
            // tsbVolver
            // 
            this.tsbVolver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbVolver.Image = ((System.Drawing.Image)(resources.GetObject("tsbVolver.Image")));
            this.tsbVolver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVolver.Name = "tsbVolver";
            this.tsbVolver.Size = new System.Drawing.Size(29, 28);
            this.tsbVolver.Text = "toolStripButton1";
            this.tsbVolver.Click += new System.EventHandler(this.tsbVolver_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tslblNombre
            // 
            this.tslblNombre.Name = "tslblNombre";
            this.tslblNombre.Size = new System.Drawing.Size(64, 28);
            this.tslblNombre.Text = "Nombre";
            // 
            // tsbtnCerrarSesion
            // 
            this.tsbtnCerrarSesion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCerrarSesion.Image")));
            this.tsbtnCerrarSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCerrarSesion.Name = "tsbtnCerrarSesion";
            this.tsbtnCerrarSesion.Size = new System.Drawing.Size(29, 28);
            this.tsbtnCerrarSesion.Text = "Cerrar Sesión";
            this.tsbtnCerrarSesion.Click += new System.EventHandler(this.tsbtnCerrarSesion_Click);
            // 
            // dgvDocumentos
            // 
            this.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentos.Location = new System.Drawing.Point(41, 86);
            this.dgvDocumentos.Name = "dgvDocumentos";
            this.dgvDocumentos.RowHeadersWidth = 51;
            this.dgvDocumentos.RowTemplate.Height = 24;
            this.dgvDocumentos.Size = new System.Drawing.Size(983, 317);
            this.dgvDocumentos.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(37, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "Documentacion Inicial ";
            // 
            // btnDocumento
            // 
            this.btnDocumento.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDocumento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDocumento.Location = new System.Drawing.Point(532, 433);
            this.btnDocumento.Name = "btnDocumento";
            this.btnDocumento.Size = new System.Drawing.Size(149, 50);
            this.btnDocumento.TabIndex = 70;
            this.btnDocumento.Text = "Ver Documento";
            this.btnDocumento.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(697, 433);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(149, 50);
            this.btnAceptar.TabIndex = 71;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnRechazar
            // 
            this.btnRechazar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRechazar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRechazar.Location = new System.Drawing.Point(852, 433);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(149, 50);
            this.btnRechazar.TabIndex = 72;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.UseVisualStyleBackColor = false;
            // 
            // frmDocumentacionCoordinador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnDocumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDocumentos);
            this.Controls.Add(this.tsMenuCoordinador);
            this.Name = "frmDocumentacionCoordinador";
            this.Text = "frmDocumentacionCoordinador";
            this.tsMenuCoordinador.ResumeLayout(false);
            this.tsMenuCoordinador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenuCoordinador;
        private System.Windows.Forms.ToolStripLabel tslblNombre;
        private System.Windows.Forms.ToolStripButton tsbtnCerrarSesion;
        private System.Windows.Forms.DataGridView dgvDocumentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDocumento;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbVolver;
    }
}