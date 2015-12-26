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
    public partial class ModificacionCiudades : Form
    {
        DataGridViewButtonColumn Boton = new DataGridViewButtonColumn();
        
        public ModificacionCiudades()
        {
            InitializeComponent();
            this.txtBoxCiudadModif.Focus();
            InicializarFiltrosBusqueda();
        }

        private void InicializarFiltrosBusqueda()
        {
            foreach (Control control in this.grdFiltros.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
            this.txtBoxCiudadModif.Focus();
        }

        private void ModificacionCiudades_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
            Boton.Name = "Modificar";
            this.dataGridViewCiudadModif.Columns.Add(Boton);
            this.txtBoxCiudadModif.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        private void CargarDataGrid()
        {
            Conexion cnn = new Conexion();
            cnn.Abrir();
            cnn.ArmarProcedimiento("SFX.BuscarCiudad");
            cnn.AgregarParametro("CiudadNombre", txtBoxCiudadModif.Text);
            try
            {
                cnn.LoadDataGridView(dataGridViewCiudadModif);
                cnn.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo hacer la consulta a la base de datos" + ex.ToString());
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.InicializarFiltrosBusqueda();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewCiudadModif.Columns[e.ColumnIndex].Name == "Modificar")
            {
                FrmAltaModifCiudad altamodif = new FrmAltaModifCiudad();
                altamodif.cargarTextBoxCiudad(dataGridViewCiudadModif.Rows[e.RowIndex].Cells["Cia_ID"].Value.ToString(),
                    dataGridViewCiudadModif.Rows[e.RowIndex].Cells["Cia_Descripcion"].Value.ToString());
                altamodif.Show();
                this.InicializarFiltrosBusqueda();
            }
        }



    }
}
