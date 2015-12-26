using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class Compra : Form
    {

        DataGridViewButtonColumn Boton = new DataGridViewButtonColumn();

        public Compra()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            Conexion cnn = new Conexion();
            cnn.Abrir();
            DataTable dt1 = cnn.EjecutarConsulta("select * from SFX.t_ciudades_aeropuertos order by cia_descripcion");
            cmbBoxCiudadOrigen.DataSource = dt1.DefaultView;
            cmbBoxCiudadOrigen.DisplayMember = "cia_descripcion";
            cmbBoxCiudadOrigen.ValueMember = "cia_id";
            cmbBoxCiudadOrigen.SelectedIndex = -1;

            DataTable dt2 = cnn.EjecutarConsulta("select * from SFX.t_ciudades_aeropuertos order by cia_descripcion");
            cmbBoxCiudadDestino.DataSource = dt2.DefaultView;
            cmbBoxCiudadDestino.DisplayMember = "cia_descripcion";
            cmbBoxCiudadDestino.ValueMember = "cia_id";
            cmbBoxCiudadDestino.SelectedIndex = -1;

            cnn.Cerrar();

            dateTimePicker1.ResetText();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitializeComboBox();
            dataGridViewViajes.DataSource = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Boton.Name = "Seleccionar";
            Object ciudadOirgenId = cmbBoxCiudadOrigen.SelectedValue;
            Object ciudadDestinoId = cmbBoxCiudadDestino.SelectedValue;
            DateTime fechaVuelo = new DateTime();
            DateTime fechaActual = new DateTime();
            fechaVuelo = dateTimePicker1.Value;
            fechaActual = DateTime.Now;
            int fechaValida = DateTime.Compare(fechaVuelo, fechaActual);
            if (fechaValida > 0)
            {
                try
                {
                    MessageBox.Show("El valor de cia_id origen seleccionado es: " + ciudadOirgenId.ToString() + "\n"
                    + "El valor de cia_id destino seleccionado es: " + ciudadDestinoId.ToString() + "\n"
                    + "La fecha seleccionada es: " + fechaVuelo.ToShortDateString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("excepcion: " + ex.ToString());
                }
                try
                {
                    if (dataGridViewViajes.Columns.Contains(Boton))
                    {
                        this.dataGridViewViajes.Columns.Remove(Boton);
                        this.CargarDataGrid(ciudadOirgenId.ToString(), ciudadDestinoId.ToString(), fechaVuelo.ToShortDateString());
                        this.dataGridViewViajes.Columns.Add(Boton);
                    }
                    else
                    {
                        this.CargarDataGrid(ciudadOirgenId.ToString(), ciudadDestinoId.ToString(), fechaVuelo.ToShortDateString());
                        this.dataGridViewViajes.Columns.Add(Boton);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("excepcion: " + ex.ToString());
                }


            }
            else
            {
                MessageBox.Show("Debe ingresar una fecha de vuelo valida, posterior a la fecha actual");
            }


        }

        private void CargarDataGrid(String ciudadOrigenId, String ciudadDestinoId, String fechaVuelo)
        {
            Conexion cnn = new Conexion();
            cnn.Abrir();
            cnn.ArmarProcedimiento("SFX.GetViajesDisponibles");
            cnn.AgregarParametro("CiudadOrigId", ciudadOrigenId);
            cnn.AgregarParametro("CiudadDestId", ciudadDestinoId);
            cnn.AgregarParametro("FechaVuelo", fechaVuelo);
            try
            {
                cnn.LoadDataGridView(dataGridViewViajes);
                cnn.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo hacer la consulta a la base de datos" + ex.ToString());
            }

        }
    }
}

