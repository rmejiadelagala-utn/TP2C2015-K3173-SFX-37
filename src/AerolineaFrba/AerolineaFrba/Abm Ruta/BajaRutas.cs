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

namespace AerolineaFrba.Abm_Ruta
{
    public partial class BajaRutas : Form
    {
        DataGridViewButtonColumn Boton = new DataGridViewButtonColumn();
        
        public BajaRutas()
        {
            InitializeComponent(); 
            InitializeComboBox();
            this.txtCodigo.Focus();
            InicializarFiltrosBusqueda();

        }

        private void InicializarFiltrosBusqueda()
        {

            InitializeComboBox();

            foreach (Control control in this.grdFiltros.Controls)
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                Conexion cnn = new Conexion();

                cnn.ArmarProcedimiento("SFX.BajaRuta");

                cnn.AgregarParametro("@ID", dataGridView1.Rows[e.RowIndex].Cells["Rut_ID"].Value);

                cnn.Abrir();

                cnn.EjecutarProcedimiento();

                cnn.Cerrar();

            }
        }

        private void BajaRutas_Load(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlConnection cn = new SqlConnection(@"Data Source=localhost\SQLSERVER2012;Initial Catalog=GD2C2015;User ID=gd;Password=gd2015");
            cn.Open();

            cmd = new SqlCommand("Select Rut_ID, Rut_Codigo Codigo, Rut_Precio_BaseKG Precio_Base_KG, Rut_Precio_BasePasaje Precio_Base_Pasaje, Rut_Fecha_Baja Fecha_Baja, " +
                                 "(SELECT Cia_Descripcion FROM SFX.t_ciudades_aeropuertos WHERE Cia_ID = Rut_Cia_ID_Origen) Ciudad_Origen, " +
                                 "(SELECT Cia_Descripcion FROM SFX.t_ciudades_aeropuertos WHERE Cia_ID = Rut_Cia_ID_Destino) Ciudad_Destino, " +
                                 "(SELECT Ser_Descripcion FROM SFX.t_servicios WHERE Ser_ID = Rut_Ser_ID) Servicio " +
                                 "from SFX.t_rutas;", cn);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            this.dataGridView1.DataSource = dt;
            cn.Close();

            Boton.Name = "Eliminar";
            this.dataGridView1.Columns.Add(Boton);
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            String consulta = "Select Rut_ID, Rut_Codigo Codigo, Rut_Precio_BaseKG Precio_Base_KG, Rut_Precio_BasePasaje Precio_Base_Pasaje, Rut_Fecha_Baja Fecha_Baja, " +
                              "(SELECT Cia_Descripcion FROM SFX.t_ciudades_aeropuertos WHERE Cia_ID = Rut_Cia_ID_Origen) Ciudad_Origen, " +
                              "(SELECT Cia_Descripcion FROM SFX.t_ciudades_aeropuertos WHERE Cia_ID = Rut_Cia_ID_Destino) Ciudad_Destino, " +
                              "(SELECT Ser_Descripcion FROM SFX.t_servicios WHERE Ser_ID = Rut_Ser_ID) Servicio " +
                              "from SFX.t_rutas"; ;

            String filtros = null;

            SqlCommand cmd;
            SqlConnection cn = new SqlConnection(@"Data Source=localhost\SQLSERVER2012;Initial Catalog=GD2C2015;User ID=gd;Password=gd2015");
            cn.Open();

            //
            if (String.IsNullOrEmpty(filtros) && !(String.IsNullOrEmpty(this.txtCodigo.Text)))
                filtros = " where Rut_Codigo Like '%" + this.txtCodigo.Text + "%'";
            else
                if (!(String.IsNullOrEmpty(this.txtCodigo.Text)))
                    filtros = filtros + " and Rut_Codigo Like '%" + this.txtCodigo.Text + "%'";
            //
            if (String.IsNullOrEmpty(filtros) && !(String.IsNullOrEmpty(this.txtBaseKG.Text)))
                filtros = " where Rut_Precio_BaseKG = " + this.txtBaseKG.Text;
            else
                if (!(String.IsNullOrEmpty(this.txtBaseKG.Text)))
                    filtros = filtros + " and Rut_Precio_BaseKG = " + this.txtBaseKG.Text;
            //
            if (String.IsNullOrEmpty(filtros) && !(String.IsNullOrEmpty(this.txtBasePas.Text)))
                filtros = " where Rut_Precio_BasePasaje = " + this.txtBasePas.Text;
            else
                if (!(String.IsNullOrEmpty(this.txtBasePas.Text)))
                    filtros = filtros + " and Rut_Precio_BasePasaje = " + this.txtBasePas.Text;
            //
            if (String.IsNullOrEmpty(filtros) && this.cmbBoxCiuOri.SelectedIndex > -1)
                filtros = " where Rut_Cia_ID_Origen = (select Cia_ID from SFX.t_ciudades_aeropuertos where cia_descripcion like '%" + this.cmbBoxCiuOri.Text + "%')";
            else
                if (this.cmbBoxCiuOri.SelectedIndex > -1)
                    filtros = filtros + " and Rut_Cia_ID_Origen = (select Cia_ID from SFX.t_ciudades_aeropuertos where cia_descripcion like '%" + this.cmbBoxCiuOri.Text + "%')";
            // 
            if (String.IsNullOrEmpty(filtros) && this.cmbBoxCiuDes.SelectedIndex > -1)
                filtros = " where Rut_Cia_ID_Destino = (select Cia_ID from SFX.t_ciudades_aeropuertos where cia_descripcion like '%" + this.cmbBoxCiuDes.Text + "%')";
            else
                if (this.cmbBoxCiuDes.SelectedIndex > -1)
                    filtros = filtros + " and Rut_Cia_ID_Destino = (select Cia_ID from SFX.t_ciudades_aeropuertos where cia_descripcion like '%" + this.cmbBoxCiuDes.Text + "%')";
            //
            if (String.IsNullOrEmpty(filtros) && this.cmbBoxServicio.SelectedIndex > -1)
                filtros = " where Rut_Ser_ID = (select ser_id from SFX.t_servicios where ser_descripcion like '%" + this.cmbBoxServicio.Text + "%')";
            else
                if (this.cmbBoxServicio.SelectedIndex > -1)
                    filtros = filtros + " and Rut_Ser_ID = (select ser_id from SFX.t_servicios where ser_descripcion like '%" + this.cmbBoxServicio.Text + "%')";

            cmd = new SqlCommand(consulta + filtros + ";", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            this.InicializarFiltrosBusqueda();
        }
    }
}
