using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class BajaCiudades : Form
    {
        DataGridViewButtonColumn Boton = new DataGridViewButtonColumn();

        public BajaCiudades()
        {
            InitializeComponent();
        }

        private void BajaCiudades_Load(object sender, EventArgs e)
        {
            //Conexion cn = new Conexion();
            SqlCommand cmd; //SqlConnection cn;
            SqlConnection cn = new SqlConnection(@"Data Source=localhost\SQLSERVER2012;Initial Catalog=GD2C2015;User ID=gd;Password=gd2015");
            cn.Open();

            cmd = new SqlCommand("Select * from SFX.t_ciudades_aeropuertos where Cia_Fecha_Baja IS NULL AND Cia_Descripcion Like " + "'%" + this.txtCiudadEliminar.Text + "%';", cn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            this.dataGridView1.DataSource = dt;
            cn.Close();

            Boton.Name = "Eliminar";
            this.dataGridView1.Columns.Add(Boton);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.grdFiltros.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
            this.txtCiudadEliminar.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Conexion cn = new Conexion();
            SqlCommand cmd; //SqlConnection cn;
            SqlConnection cn = new SqlConnection(@"Data Source=localhost\SQLSERVER2012;Initial Catalog=GD2C2015;User ID=gd;Password=gd2015");
            cn.Open();

            cmd = new SqlCommand("Select * from SFX.t_ciudades_aeropuertos where Cia_Fecha_Baja IS NULL AND Cia_Descripcion Like " + "'%" + this.txtCiudadEliminar.Text + "%';", cn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //this.dataGridView1.Rows.Clear();

            this.dataGridView1.DataSource = dt;
            cn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                Conexion cnn = new Conexion();

                cnn.ArmarProcedimiento("SFX.BajaCiudad");

                cnn.AgregarParametro("@ID", dataGridView1.Rows[e.RowIndex].Cells["cia_id"].Value);

                cnn.Abrir();

                cnn.EjecutarProcedimiento();

                cnn.Cerrar();

            }
        }
    }
}
