namespace SistemaVinculacion.formsCoordinador
{
    partial class frmDocentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocentes));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTutores = new System.Windows.Forms.DataGridView();
            this.tsMenuCoordinador = new System.Windows.Forms.ToolStrip();
            this.tsbVolver = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslblNombre = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnCerrarSesion = new System.Windows.Forms.ToolStripButton();
            this.btnAsignarTutor = new System.Windows.Forms.Button();
            this.dgvProyectosAsignables = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutores)).BeginInit();
            this.tsMenuCoordinador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectosAsignables)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 72;
            this.label1.Text = "Docentes";
            // 
            // dgvTutores
            // 
            this.dgvTutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTutores.Location = new System.Drawing.Point(42, 67);
            this.dgvTutores.Name = "dgvTutores";
            this.dgvTutores.RowHeadersWidth = 51;
            this.dgvTutores.RowTemplate.Height = 24;
            this.dgvTutores.Size = new System.Drawing.Size(983, 199);
            this.dgvTutores.TabIndex = 71;
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
            // btnAsignarTutor
            // 
            this.btnAsignarTutor.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAsignarTutor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAsignarTutor.Location = new System.Drawing.Point(876, 471);
            this.btnAsignarTutor.Name = "btnAsignarTutor";
            this.btnAsignarTutor.Size = new System.Drawing.Size(149, 50);
            this.btnAsignarTutor.TabIndex = 73;
            this.btnAsignarTutor.Text = "Seleccionar Tutor";
            this.btnAsignarTutor.UseVisualStyleBackColor = false;
            this.btnAsignarTutor.Click += new System.EventHandler(this.btnAsignarTutor_Click);
            // 
            // dgvProyectosAsignables
            // 
            this.dgvProyectosAsignables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyectosAsignables.Location = new System.Drawing.Point(42, 317);
            this.dgvProyectosAsignables.Name = "dgvProyectosAsignables";
            this.dgvProyectosAsignables.RowHeadersWidth = 51;
            this.dgvProyectosAsignables.RowTemplate.Height = 24;
            this.dgvProyectosAsignables.Size = new System.Drawing.Size(983, 139);
            this.dgvProyectosAsignables.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(38, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 19);
            this.label2.TabIndex = 75;
            this.label2.Text = "Asignar Tutor a Proyecto ";
            // 
            // frmDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvProyectosAsignables);
            this.Controls.Add(this.btnAsignarTutor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTutores);
            this.Controls.Add(this.tsMenuCoordinador);
            this.Name = "frmDocentes";
            this.Text = "frmDocentes";
            this.Load += new System.EventHandler(this.frmDocentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutores)).EndInit();
            this.tsMenuCoordinador.ResumeLayout(false);
            this.tsMenuCoordinador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectosAsignables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTutores;
        private System.Windows.Forms.ToolStrip tsMenuCoordinador;
        private System.Windows.Forms.ToolStripButton tsbVolver;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslblNombre;
        private System.Windows.Forms.ToolStripButton tsbtnCerrarSesion;
        private System.Windows.Forms.Button btnAsignarTutor;
        private System.Windows.Forms.DataGridView dgvProyectosAsignables;
        private System.Windows.Forms.Label label2;
    }
}