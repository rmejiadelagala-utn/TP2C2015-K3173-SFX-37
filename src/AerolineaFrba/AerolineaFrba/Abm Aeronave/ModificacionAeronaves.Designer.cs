namespace AerolineaFrba.Abm_Aeronave
{
    partial class ModificacionAeronaves
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
            this.dgvModificacionAeronave = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grdFiltros = new System.Windows.Forms.GroupBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.cmbBoxModelo = new System.Windows.Forms.ComboBox();
            this.cmbBoxFabricante = new System.Windows.Forms.ComboBox();
            this.lblAeronaveMatricula = new System.Windows.Forms.Label();
            this.txtBoxMatricula = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificacionAeronave)).BeginInit();
            this.grdFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvModificacionAeronave
            // 
            this.dgvModificacionAeronave.AllowUserToAddRows = false;
            this.dgvModificacionAeronave.AllowUserToDeleteRows = false;
            this.dgvModificacionAeronave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificacionAeronave.Location = new System.Drawing.Point(23, 171);
            this.dgvModificacionAeronave.Name = "dgvModificacionAeronave";
            this.dgvModificacionAeronave.ReadOnly = true;
            this.dgvModificacionAeronave.Size = new System.Drawing.Size(695, 150);
            this.dgvModificacionAeronave.TabIndex = 7;
            this.dgvModificacionAeronave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModificacionAeronave_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(643, 137);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(501, 137);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // grdFiltros
            // 
            this.grdFiltros.Controls.Add(this.lblModelo);
            this.grdFiltros.Controls.Add(this.lblFabricante);
            this.grdFiltros.Controls.Add(this.cmbBoxModelo);
            this.grdFiltros.Controls.Add(this.cmbBoxFabricante);
            this.grdFiltros.Controls.Add(this.lblAeronaveMatricula);
            this.grdFiltros.Controls.Add(this.txtBoxMatricula);
            this.grdFiltros.Location = new System.Drawing.Point(23, 20);
            this.grdFiltros.Name = "grdFiltros";
            this.grdFiltros.Size = new System.Drawing.Size(695, 100);
            this.grdFiltros.TabIndex = 4;
            this.grdFiltros.TabStop = false;
            this.grdFiltros.Text = "Filtros de Busqueda";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(486, 44);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 11;
            this.lblModelo.Text = "Modelo";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(245, 45);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(57, 13);
            this.lblFabricante.TabIndex = 10;
            this.lblFabricante.Text = "Fabricante";
            // 
            // cmbBoxModelo
            // 
            this.cmbBoxModelo.FormattingEnabled = true;
            this.cmbBoxModelo.Location = new System.Drawing.Point(534, 41);
            this.cmbBoxModelo.Name = "cmbBoxModelo";
            this.cmbBoxModelo.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxModelo.TabIndex = 9;
            // 
            // cmbBoxFabricante
            // 
            this.cmbBoxFabricante.FormattingEnabled = true;
            this.cmbBoxFabricante.Location = new System.Drawing.Point(308, 41);
            this.cmbBoxFabricante.Name = "cmbBoxFabricante";
            this.cmbBoxFabricante.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxFabricante.TabIndex = 8;
            // 
            // lblAeronaveMatricula
            // 
            this.lblAeronaveMatricula.AutoSize = true;
            this.lblAeronaveMatricula.Location = new System.Drawing.Point(39, 41);
            this.lblAeronaveMatricula.Name = "lblAeronaveMatricula";
            this.lblAeronaveMatricula.Size = new System.Drawing.Size(50, 13);
            this.lblAeronaveMatricula.TabIndex = 7;
            this.lblAeronaveMatricula.Text = "Matricula";
            // 
            // txtBoxMatricula
            // 
            this.txtBoxMatricula.Location = new System.Drawing.Point(105, 38);
            this.txtBoxMatricula.Name = "txtBoxMatricula";
            this.txtBoxMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMatricula.TabIndex = 6;
            // 
            // ModificacionAeronaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 347);
            this.Controls.Add(this.dgvModificacionAeronave);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grdFiltros);
            this.Name = "ModificacionAeronaves";
            this.Text = "ModificacionAeronaves";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificacionAeronave)).EndInit();
            this.grdFiltros.ResumeLayout(false);
            this.grdFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvModificacionAeronave;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox grdFiltros;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.ComboBox cmbBoxModelo;
        private System.Windows.Forms.ComboBox cmbBoxFabricante;
        private System.Windows.Forms.Label lblAeronaveMatricula;
        private System.Windows.Forms.TextBox txtBoxMatricula;
    }
}