using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class AltaCiudades : Form
    {
        public AltaCiudades()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.grdCampos.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
            this.txtCiudad.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion cnn = new Conexion();

                cnn.ArmarProcedimiento("SFX.InsertarCiudad");

                cnn.AgregarParametro("CiudadNombre", txtCiudad.Text);

                cnn.Abrir();

                cnn.EjecutarProcedimiento();

                cnn.Cerrar();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //private void cmdGuardar_Click(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        Conexion cnn = new Conexion();

        //        cnn.ArmarProcedimiento("SFX.InsertarCiudad");

        //        cnn.AgregarParametro("CiudadNombre", txtCiudad.Text);

        //        cnn.Abrir();

        //        cnn.EjecutarProcedimiento();

        //        cnn.Cerrar();
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }

        //}
    }
}
