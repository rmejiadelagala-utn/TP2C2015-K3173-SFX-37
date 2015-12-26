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
    public partial class FrmAltaModifCiudad : Form
    {
        public FrmAltaModifCiudad()
        {
            InitializeComponent();
        }

        private void FrmAltaModifCiudad_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Conexion cnn = new Conexion();
            cnn.Abrir();
            cnn.ArmarProcedimiento("SFX.ModificarCiudad");
            cnn.AgregarParametro("ID", txtBoxIDCiudad.Text);
            cnn.AgregarParametro("CiudadNombre", txtBoxNombreCiudad.Text);
            try
            {
                cnn.EjecutarProcedimiento();
                cnn.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar la base de datos" + ex.ToString());
            }
            Close();
        }

        public void cargarTextBoxCiudad(string id, string nombreCiudad)
        {
            this.txtBoxIDCiudad.Text = id;
            this.txtBoxNombreCiudad.Text = nombreCiudad;

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
            this.txtBoxNombreCiudad.Focus();
        }
    }
}
