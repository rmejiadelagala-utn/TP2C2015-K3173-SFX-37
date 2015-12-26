using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class FrmAltaModifAeronave : Form
    {
        public FrmAltaModifAeronave()
        {
            InitializeComponent();
        }

        public void mostrarAeronaveSeleccionada(string id)
        {
            Conexion cnn = new Conexion();
            cnn.Abrir();
            SqlDataReader dr = cnn.EjecutarDataReader(
                "SELECT Aer_ID, Aer_Matricula,Mod_Nombre, Aer_KG_Disponibles, Ser_Descripcion,Aer_Fecha_Fuera_Servicio, Aer_Fecha_Reinicio_Servicio " +
                " FROM SFX.t_Aeronaves, SFX.t_modelos, SFX.t_servicios WHERE Aer_ID = " + id +
                " and Aer_Mod_ID=Mod_ID and Ser_ID=Aer_Ser_ID ");

            //Cargar textBoxes
            txtBoxAerID.Text = dr["Aer_ID"].ToString();
            txtBoxMatricula.Text = dr["Aer_Matricula"].ToString();
            txtBoxKgDisp.Text = dr["Aer_KG_Disponibles"].ToString();
            Object auxModelo = dr["Mod_Nombre"];
            Object auxServ = dr["Ser_Descripcion"];
            cnn.Cerrar();

            cnn.Abrir();
            DataTable dt1 = cnn.EjecutarConsulta("select Mod_ID, Mod_Nombre from SFX.t_modelos");
            cmbBoxModelo.DataSource = dt1.DefaultView;
            cmbBoxModelo.DisplayMember = "Mod_Nombre";
            cmbBoxModelo.Text = "elige un opcion"; //auxModelo.ToString();
            cmbBoxModelo.ValueMember = "Mod_id";
            int index = cmbBoxModelo.FindString(auxModelo.ToString());
            cmbBoxModelo.SelectedIndex = index;

           
            DataTable dt2 = cnn.EjecutarConsulta("select Ser_ID, Ser_Descripcion from SFX.t_servicios");
            cmbBoxTipoServicio.DataSource = dt2.DefaultView;
            cmbBoxTipoServicio.DisplayMember = "Ser_Descripcion";
            cmbBoxTipoServicio.ValueMember = "Ser_id";
            int index1 = cmbBoxTipoServicio.FindString(auxServ.ToString());
            cmbBoxTipoServicio.SelectedIndex = index1;
            cnn.Cerrar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            string id = txtBoxAerID.Text; //como el txtBoxAerID esta inhabilitado para la edición lo puedo tomar.
            this.mostrarAeronaveSeleccionada(id); //cargamos los datos originales de la aeronave.
            
            //foreach (Control control in this.grdCampos.Controls)
            //{
            //    if (control is TextBox)
            //    {
            //        control.Text = "";
            //    }
            //}
            //this.txtBoxMatricula.Focus();
            //dateTimePckFueraServicio.ResetText();
            //dateTimePckReinicioServicio.ResetText();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion cnn = new Conexion();

                cnn.ArmarProcedimiento("SFX.ActualizarAeronave");
                cnn.AgregarParametro("@AerID", txtBoxAerID.Text);
                cnn.AgregarParametro("@matricula", txtBoxMatricula.Text);
                cnn.AgregarParametro("@mod_id", cmbBoxModelo.SelectedValue);
                cnn.AgregarParametro("@kg_disponibles", txtBoxKgDisp.Text);
                cnn.AgregarParametro("@cantPasillo", txtBoxCantButPasillo.Text);
                cnn.AgregarParametro("@cantVentanilla", txtBoxCantButVentan.Text);
                cnn.AgregarParametro("@ser_id", cmbBoxTipoServicio.SelectedValue);
                cnn.AgregarParametro("@fechFueraServ", dateTimePckFueraServicio.Text);

                cnn.Abrir();

                cnn.EjecutarProcedimiento();

                cnn.Cerrar();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
