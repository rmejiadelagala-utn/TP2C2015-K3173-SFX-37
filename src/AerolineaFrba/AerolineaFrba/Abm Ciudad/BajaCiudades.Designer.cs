namespace AerolineaFrba.Abm_Ciudad
{
    partial class BajaCiudades
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
            this.lblCiudadEliminar = new System.Windows.Forms.Label();
            this.txtCiudadEliminar = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grdFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdFiltros
            // 
            this.grdFiltros.Controls.Add(this.txtCiudadEliminar);
            this.grdFiltros.Controls.Add(this.lblCiudadEliminar);
            this.grdFiltros.Location = new System.Drawing.Point(12, 12);
            this.grdFiltros.Name = "grdFiltros";
            this.grdFiltros.Size = new System.Drawing.Size(452, 100);
            this.grdFiltros.TabIndex = 0;
            this.grdFiltros.TabStop = false;
            this.grdFiltros.Text = "Filtros de Busqueda";
            // 
            // lblCiudadEliminar
            // 
            this.lblCiudadEliminar.AutoSize = true;
            this.lblCiudadEliminar.Location = new System.Drawing.Point(59, 43);
            this.lblCiudadEliminar.Name = "lblCiudadEliminar";
            this.lblCiudadEliminar.Size = new System.Drawing.Size(88, 13);
            this.lblCiudadEliminar.TabIndex = 0;
            this.lblCiudadEliminar.Text = "Ciudad a Eliminar";
            // 
            // txtCiudadEliminar
            // 
            this.txtCiudadEliminar.Location = new System.Drawing.Point(174, 40);
            this.txtCiudadEliminar.Name = "txtCiudadEliminar";
            this.txtCiudadEliminar.Size = new System.Drawing.Size(134, 20);
            this.txtCiudadEliminar.TabIndex = 1;
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
            this.btnBuscar.Location = new System.Drawing.Point(389, 129);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(452, 193);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BajaCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 363);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grdFiltros);
            this.Name = "BajaCiudades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja de Ciudad";
            this.Load += new System.EventHandler(this.BajaCiudades_Load);
            this.grdFiltros.ResumeLayout(false);
            this.grdFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grdFiltros;
        private System.Windows.Forms.TextBox txtCiudadEliminar;
        private System.Windows.Forms.Label lblCiudadEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}