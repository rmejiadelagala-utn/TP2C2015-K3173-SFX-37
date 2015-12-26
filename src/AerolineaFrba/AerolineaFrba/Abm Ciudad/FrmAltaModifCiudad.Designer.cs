namespace AerolineaFrba.Abm_Ciudad
{
    partial class FrmAltaModifCiudad
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
            this.grdCampos = new System.Windows.Forms.GroupBox();
            this.txtBoxNombreCiudad = new System.Windows.Forms.TextBox();
            this.lblNombreCiudad = new System.Windows.Forms.Label();
            this.txtBoxIDCiudad = new System.Windows.Forms.TextBox();
            this.lblIDCiudad = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grdCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdCampos
            // 
            this.grdCampos.Controls.Add(this.txtBoxNombreCiudad);
            this.grdCampos.Controls.Add(this.lblNombreCiudad);
            this.grdCampos.Controls.Add(this.txtBoxIDCiudad);
            this.grdCampos.Controls.Add(this.lblIDCiudad);
            this.grdCampos.Location = new System.Drawing.Point(12, 12);
            this.grdCampos.Name = "grdCampos";
            this.grdCampos.Size = new System.Drawing.Size(271, 200);
            this.grdCampos.TabIndex = 0;
            this.grdCampos.TabStop = false;
            // 
            // txtBoxNombreCiudad
            // 
            this.txtBoxNombreCiudad.Location = new System.Drawing.Point(119, 130);
            this.txtBoxNombreCiudad.Name = "txtBoxNombreCiudad";
            this.txtBoxNombreCiudad.Size = new System.Drawing.Size(135, 20);
            this.txtBoxNombreCiudad.TabIndex = 3;
            // 
            // lblNombreCiudad
            // 
            this.lblNombreCiudad.AutoSize = true;
            this.lblNombreCiudad.Location = new System.Drawing.Point(18, 133);
            this.lblNombreCiudad.Name = "lblNombreCiudad";
            this.lblNombreCiudad.Size = new System.Drawing.Size(95, 13);
            this.lblNombreCiudad.TabIndex = 2;
            this.lblNombreCiudad.Text = "Nombre de Ciudad";
            // 
            // txtBoxIDCiudad
            // 
            this.txtBoxIDCiudad.Enabled = false;
            this.txtBoxIDCiudad.Location = new System.Drawing.Point(119, 69);
            this.txtBoxIDCiudad.Name = "txtBoxIDCiudad";
            this.txtBoxIDCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIDCiudad.TabIndex = 1;
            // 
            // lblIDCiudad
            // 
            this.lblIDCiudad.AutoSize = true;
            this.lblIDCiudad.Location = new System.Drawing.Point(18, 72);
            this.lblIDCiudad.Name = "lblIDCiudad";
            this.lblIDCiudad.Size = new System.Drawing.Size(54, 13);
            this.lblIDCiudad.TabIndex = 0;
            this.lblIDCiudad.Text = "Ciudad ID";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(13, 227);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(208, 227);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmAltaModifCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 262);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grdCampos);
            this.Name = "FrmAltaModifCiudad";
            this.Text = "FrmAltaModifCiudad";
            this.Load += new System.EventHandler(this.FrmAltaModifCiudad_Load);
            this.grdCampos.ResumeLayout(false);
            this.grdCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grdCampos;
        private System.Windows.Forms.TextBox txtBoxNombreCiudad;
        private System.Windows.Forms.Label lblNombreCiudad;
        private System.Windows.Forms.TextBox txtBoxIDCiudad;
        private System.Windows.Forms.Label lblIDCiudad;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;

    }
}