using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Abm_Ruta.Clases;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class AltaRutas : Form
    {
        public AltaRutas()
        {
            InitializeComponent();
            InitializeComboBox();
            this.txtCodigo.Focus();
            InicializarFiltrosBusqueda();
        }

        private void InicializarFiltrosBusqueda()
        {

            InitializeComboBox();

            foreach (Control control in this.grdCampos.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
            this.txtCodigo.Focus();
        }

        private void InitializeComboBox()
        {
            Conexion cnn = new Conexion();
            cnn.Abrir();
            DataTable dt1 = cnn.EjecutarConsulta("select * from SFX.t_ciudades_aeropuertos order by cia_descripcion");
            cmbBoxCiuOri.DataSource = dt1.DefaultView;
            cmbBoxCiuOri.DisplayMember = "cia_descripcion";
            cmbBoxCiuOri.ValueMember = "cia_id";
            cmbBoxCiuOri.SelectedIndex = -1;

            DataTable dt2 = cnn.EjecutarConsulta("select * from SFX.t_ciudades_aeropuertos order by cia_descripcion");
            cmbBoxCiuDes.DataSource = dt2.DefaultView;
            cmbBoxCiuDes.DisplayMember = "cia_descripcion";
            cmbBoxCiuDes.ValueMember = "cia_id";
            cmbBoxCiuDes.SelectedIndex = -1;

            DataTable dt3 = cnn.EjecutarConsulta("select * from SFX.t_servicios order by ser_descripcion");
            cmbBoxServicio.DataSource = dt3.DefaultView;
            cmbBoxServicio.DisplayMember = "ser_descripcion";
            cmbBoxServicio.ValueMember = "ser_id";
            cmbBoxServicio.SelectedIndex = -1;

            cnn.Cerrar();

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            Ruta vRuta = new Ruta();
            vRuta.Codigo = Convert.ToInt32(txtCodigo.Text);
            vRuta.PrecioBaseKG = txtBaseKG.Text;
            vRuta.PrecioBasePasaje = txtBasePas.Text;
            vRuta.Cia_ID_Origen = Convert.ToInt32(cmbBoxCiuOri.SelectedValue);
            vRuta.Cia_ID_Destino = Convert.ToInt32(cmbBoxCiuDes.SelectedValue);
            vRuta.Ser_ID = Convert.ToInt32(cmbBoxServicio.SelectedValue);

            Conexion cnn = new Conexion();

            cnn.ArmarProcedimiento("SFX.InsertarRuta");

            cnn.AgregarParametro("Rut_Codigo", vRuta.Codigo);
            cnn.AgregarParametro("Rut_Precio_BaseKG", vRuta.PrecioBaseKG);
            cnn.AgregarParametro("Rut_Precio_BasePasaje", vRuta.PrecioBasePasaje);
            cnn.AgregarParametro("Rut_Cia_ID_Origen", vRuta.Cia_ID_Origen);
            cnn.AgregarParametro("Rut_Cia_ID_Destino", vRuta.Cia_ID_Destino);
            cnn.AgregarParametro("Rut_Ser_ID", vRuta.Ser_ID);

            cnn.Abrir();

            cnn.EjecutarProcedimiento();

            cnn.Cerrar();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            this.InicializarFiltrosBusqueda();
        }
    }
}
