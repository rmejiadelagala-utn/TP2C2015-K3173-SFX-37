namespace AerolineaFrba.Abm_Aeronave
{
    partial class BajaAeronaves
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
            this.grdFiltros = new System.Windows.Forms.GroupBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.cmbBoxModelo = new System.Windows.Forms.ComboBox();
            this.cmbBoxFabricante = new System.Windows.Forms.ComboBox();
            this.lblAeronaveMatricula = new System.Windows.Forms.Label();
            this.txtBoxMatricula = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvBajaAeronave = new System.Windows.Forms.DataGridView();
            this.grdFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajaAeronave)).BeginInit();
            this.SuspendLayout();
            // 
            // grdFiltros
            // 
            this.grdFiltros.Controls.Add(this.lblModelo);
            this.grdFiltros.Controls.Add(this.lblFabricante);
            this.grdFiltros.Controls.Add(this.cmbBoxModelo);
            this.grdFiltros.Controls.Add(this.cmbBoxFabricante);
            this.grdFiltros.Controls.Add(this.lblAeronaveMatricula);
            this.grdFiltros.Controls.Add(this.txtBoxMatricula);
            this.grdFiltros.Location = new System.Drawing.Point(12, 12);
            this.grdFiltros.Name = "grdFiltros";
            this.grdFiltros.Size = new System.Drawing.Size(695, 100);
            this.grdFiltros.TabIndex = 0;
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
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 129);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(632, 129);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvBajaAeronave
            // 
            this.dgvBajaAeronave.AllowUserToAddRows = false;
            this.dgvBajaAeronave.AllowUserToDeleteRows = false;
            this.dgvBajaAeronave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBajaAeronave.Location = new System.Drawing.Point(12, 163);
            this.dgvBajaAeronave.Name = "dgvBajaAeronave";
            this.dgvBajaAeronave.ReadOnly = true;
            this.dgvBajaAeronave.Size = new System.Drawing.Size(695, 150);
            this.dgvBajaAeronave.TabIndex = 3;
            this.dgvBajaAeronave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBajaAeronave_CellContentClick);
            // 
            // BajaAeronaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 325);
            this.Controls.Add(this.dgvBajaAeronave);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grdFiltros);
            this.Name = "BajaAeronaves";
            this.Text = "BajaAeronaves";
            this.Load += new System.EventHandler(this.BajaAeronaves_Load);
            this.grdFiltros.ResumeLayout(false);
            this.grdFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajaAeronave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grdFiltros;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.ComboBox cmbBoxModelo;
        private System.Windows.Forms.ComboBox cmbBoxFabricante;
        private System.Windows.Forms.Label lblAeronaveMatricula;
        private System.Windows.Forms.TextBox txtBoxMatricula;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvBajaAeronave;
    }
}