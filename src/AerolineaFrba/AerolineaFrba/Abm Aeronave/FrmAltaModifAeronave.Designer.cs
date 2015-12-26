namespace AerolineaFrba.Abm_Aeronave
{
    partial class FrmAltaModifAeronave
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxCantButVentan = new System.Windows.Forms.TextBox();
            this.txtBoxCantButPasillo = new System.Windows.Forms.TextBox();
            this.cmbBoxModelo = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblTipoServicio = new System.Windows.Forms.Label();
            this.lblFechaReinicioServ = new System.Windows.Forms.Label();
            this.lblFechaFueraServ = new System.Windows.Forms.Label();
            this.cmbBoxTipoServicio = new System.Windows.Forms.ComboBox();
            this.dateTimePckReinicioServicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePckFueraServicio = new System.Windows.Forms.DateTimePicker();
            this.lblKgDisponibles = new System.Windows.Forms.Label();
            this.txtBoxKgDisp = new System.Windows.Forms.TextBox();
            this.txtBoxMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblAerID = new System.Windows.Forms.Label();
            this.txtBoxAerID = new System.Windows.Forms.TextBox();
            this.grdCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdCampos
            // 
            this.grdCampos.Controls.Add(this.txtBoxAerID);
            this.grdCampos.Controls.Add(this.lblAerID);
            this.grdCampos.Controls.Add(this.label2);
            this.grdCampos.Controls.Add(this.label1);
            this.grdCampos.Controls.Add(this.txtBoxCantButVentan);
            this.grdCampos.Controls.Add(this.txtBoxCantButPasillo);
            this.grdCampos.Controls.Add(this.cmbBoxModelo);
            this.grdCampos.Controls.Add(this.lblModelo);
            this.grdCampos.Controls.Add(this.lblTipoServicio);
            this.grdCampos.Controls.Add(this.lblFechaReinicioServ);
            this.grdCampos.Controls.Add(this.lblFechaFueraServ);
            this.grdCampos.Controls.Add(this.cmbBoxTipoServicio);
            this.grdCampos.Controls.Add(this.dateTimePckReinicioServicio);
            this.grdCampos.Controls.Add(this.dateTimePckFueraServicio);
            this.grdCampos.Controls.Add(this.lblKgDisponibles);
            this.grdCampos.Controls.Add(this.txtBoxKgDisp);
            this.grdCampos.Controls.Add(this.txtBoxMatricula);
            this.grdCampos.Controls.Add(this.lblMatricula);
            this.grdCampos.Location = new System.Drawing.Point(12, 12);
            this.grdCampos.Name = "grdCampos";
            this.grdCampos.Size = new System.Drawing.Size(449, 287);
            this.grdCampos.TabIndex = 0;
            this.grdCampos.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Cantidad Butacas Ventanilla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Cantidad Butacas Pasillo";
            // 
            // txtBoxCantButVentan
            // 
            this.txtBoxCantButVentan.Location = new System.Drawing.Point(168, 151);
            this.txtBoxCantButVentan.Name = "txtBoxCantButVentan";
            this.txtBoxCantButVentan.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCantButVentan.TabIndex = 33;
            // 
            // txtBoxCantButPasillo
            // 
            this.txtBoxCantButPasillo.Location = new System.Drawing.Point(168, 125);
            this.txtBoxCantButPasillo.Name = "txtBoxCantButPasillo";
            this.txtBoxCantButPasillo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCantButPasillo.TabIndex = 32;
            // 
            // cmbBoxModelo
            // 
            this.cmbBoxModelo.FormattingEnabled = true;
            this.cmbBoxModelo.Location = new System.Drawing.Point(96, 90);
            this.cmbBoxModelo.Name = "cmbBoxModelo";
            this.cmbBoxModelo.Size = new System.Drawing.Size(100, 21);
            this.cmbBoxModelo.TabIndex = 31;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(23, 96);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 30;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblTipoServicio
            // 
            this.lblTipoServicio.AutoSize = true;
            this.lblTipoServicio.Location = new System.Drawing.Point(230, 58);
            this.lblTipoServicio.Name = "lblTipoServicio";
            this.lblTipoServicio.Size = new System.Drawing.Size(69, 13);
            this.lblTipoServicio.TabIndex = 29;
            this.lblTipoServicio.Text = "Tipo Servicio";
            // 
            // lblFechaReinicioServ
            // 
            this.lblFechaReinicioServ.AutoSize = true;
            this.lblFechaReinicioServ.Location = new System.Drawing.Point(38, 235);
            this.lblFechaReinicioServ.Name = "lblFechaReinicioServ";
            this.lblFechaReinicioServ.Size = new System.Drawing.Size(101, 26);
            this.lblFechaReinicioServ.TabIndex = 28;
            this.lblFechaReinicioServ.Text = "Fecha \r\nReinicio de Servicio";
            // 
            // lblFechaFueraServ
            // 
            this.lblFechaFueraServ.AutoSize = true;
            this.lblFechaFueraServ.Location = new System.Drawing.Point(38, 181);
            this.lblFechaFueraServ.Name = "lblFechaFueraServ";
            this.lblFechaFueraServ.Size = new System.Drawing.Size(90, 26);
            this.lblFechaFueraServ.TabIndex = 27;
            this.lblFechaFueraServ.Text = "Fecha \r\nFuera de Servicio";
            // 
            // cmbBoxTipoServicio
            // 
            this.cmbBoxTipoServicio.FormattingEnabled = true;
            this.cmbBoxTipoServicio.Location = new System.Drawing.Point(305, 54);
            this.cmbBoxTipoServicio.Name = "cmbBoxTipoServicio";
            this.cmbBoxTipoServicio.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxTipoServicio.TabIndex = 26;
            // 
            // dateTimePckReinicioServicio
            // 
            this.dateTimePckReinicioServicio.Location = new System.Drawing.Point(147, 241);
            this.dateTimePckReinicioServicio.Name = "dateTimePckReinicioServicio";
            this.dateTimePckReinicioServicio.Size = new System.Drawing.Size(200, 20);
            this.dateTimePckReinicioServicio.TabIndex = 25;
            // 
            // dateTimePckFueraServicio
            // 
            this.dateTimePckFueraServicio.Location = new System.Drawing.Point(147, 187);
            this.dateTimePckFueraServicio.Name = "dateTimePckFueraServicio";
            this.dateTimePckFueraServicio.Size = new System.Drawing.Size(200, 20);
            this.dateTimePckFueraServicio.TabIndex = 24;
            // 
            // lblKgDisponibles
            // 
            this.lblKgDisponibles.AutoSize = true;
            this.lblKgDisponibles.Location = new System.Drawing.Point(230, 96);
            this.lblKgDisponibles.Name = "lblKgDisponibles";
            this.lblKgDisponibles.Size = new System.Drawing.Size(77, 13);
            this.lblKgDisponibles.TabIndex = 23;
            this.lblKgDisponibles.Text = "Kg Disponibles";
            // 
            // txtBoxKgDisp
            // 
            this.txtBoxKgDisp.Location = new System.Drawing.Point(326, 90);
            this.txtBoxKgDisp.Name = "txtBoxKgDisp";
            this.txtBoxKgDisp.Size = new System.Drawing.Size(100, 20);
            this.txtBoxKgDisp.TabIndex = 22;
            // 
            // txtBoxMatricula
            // 
            this.txtBoxMatricula.Location = new System.Drawing.Point(96, 55);
            this.txtBoxMatricula.Name = "txtBoxMatricula";
            this.txtBoxMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMatricula.TabIndex = 21;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(23, 62);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(50, 13);
            this.lblMatricula.TabIndex = 20;
            this.lblMatricula.Text = "Matricula";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(13, 313);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(386, 313);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblAerID
            // 
            this.lblAerID.AutoSize = true;
            this.lblAerID.Location = new System.Drawing.Point(23, 27);
            this.lblAerID.Name = "lblAerID";
            this.lblAerID.Size = new System.Drawing.Size(67, 13);
            this.lblAerID.TabIndex = 36;
            this.lblAerID.Text = "Aeronave ID";
            // 
            // txtBoxAerID
            // 
            this.txtBoxAerID.Enabled = false;
            this.txtBoxAerID.Location = new System.Drawing.Point(96, 20);
            this.txtBoxAerID.Name = "txtBoxAerID";
            this.txtBoxAerID.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAerID.TabIndex = 37;
            // 
            // FrmAltaModifAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 348);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grdCampos);
            this.Name = "FrmAltaModifAeronave";
            this.Text = "FrmAltaModifAeronave";
            this.grdCampos.ResumeLayout(false);
            this.grdCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grdCampos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxCantButVentan;
        private System.Windows.Forms.TextBox txtBoxCantButPasillo;
        private System.Windows.Forms.ComboBox cmbBoxModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblTipoServicio;
        private System.Windows.Forms.Label lblFechaReinicioServ;
        private System.Windows.Forms.Label lblFechaFueraServ;
        private System.Windows.Forms.ComboBox cmbBoxTipoServicio;
        private System.Windows.Forms.DateTimePicker dateTimePckReinicioServicio;
        private System.Windows.Forms.DateTimePicker dateTimePckFueraServicio;
        private System.Windows.Forms.Label lblKgDisponibles;
        private System.Windows.Forms.TextBox txtBoxKgDisp;
        private System.Windows.Forms.TextBox txtBoxMatricula;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtBoxAerID;
        private System.Windows.Forms.Label lblAerID;
    }
}