namespace AerolineaFrba.Abm_Ciudad
{
    partial class ModificacionCiudades
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
            this.dataGridViewCiudadModif = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grdFiltros = new System.Windows.Forms.GroupBox();
            this.txtBoxCiudadModif = new System.Windows.Forms.TextBox();
            this.lblCiudadModificar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCiudadModif)).BeginInit();
            this.grdFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCiudadModif
            // 
            this.dataGridViewCiudadModif.AllowUserToAddRows = false;
            this.dataGridViewCiudadModif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCiudadModif.Location = new System.Drawing.Point(10, 167);
            this.dataGridViewCiudadModif.Name = "dataGridViewCiudadModif";
            this.dataGridViewCiudadModif.ReadOnly = true;
            this.dataGridViewCiudadModif.Size = new System.Drawing.Size(452, 193);
            this.dataGridViewCiudadModif.TabIndex = 7;
            this.dataGridViewCiudadModif.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(387, 138);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(10, 138);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // grdFiltros
            // 
            this.grdFiltros.Controls.Add(this.txtBoxCiudadModif);
            this.grdFiltros.Controls.Add(this.lblCiudadModificar);
            this.grdFiltros.Location = new System.Drawing.Point(10, 21);
            this.grdFiltros.Name = "grdFiltros";
            this.grdFiltros.Size = new System.Drawing.Size(452, 100);
            this.grdFiltros.TabIndex = 4;
            this.grdFiltros.TabStop = false;
            this.grdFiltros.Text = "Filtros de Busqueda";
            // 
            // txtBoxCiudadModif
            // 
            this.txtBoxCiudadModif.Location = new System.Drawing.Point(174, 40);
            this.txtBoxCiudadModif.Name = "txtBoxCiudadModif";
            this.txtBoxCiudadModif.Size = new System.Drawing.Size(134, 20);
            this.txtBoxCiudadModif.TabIndex = 1;
            // 
            // lblCiudadModificar
            // 
            this.lblCiudadModificar.AutoSize = true;
            this.lblCiudadModificar.Location = new System.Drawing.Point(59, 43);
            this.lblCiudadModificar.Name = "lblCiudadModificar";
            this.lblCiudadModificar.Size = new System.Drawing.Size(95, 13);
            this.lblCiudadModificar.TabIndex = 0;
            this.lblCiudadModificar.Text = "Ciudad a Modificar";
            // 
            // ModificacionCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 377);
            this.Controls.Add(this.dataGridViewCiudadModif);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grdFiltros);
            this.Name = "ModificacionCiudades";
            this.Text = "ModificacionCiudadcs";
            this.Load += new System.EventHandler(this.ModificacionCiudades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCiudadModif)).EndInit();
            this.grdFiltros.ResumeLayout(false);
            this.grdFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCiudadModif;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox grdFiltros;
        private System.Windows.Forms.TextBox txtBoxCiudadModif;
        private System.Windows.Forms.Label lblCiudadModificar;
    }
}