using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace AerolineaFrba
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd = new SqlCommand();
        String miConexion = AerolineaFrba.Properties.Settings.Default.GD2C2015ConnectionString;

        
        public Conexion()
        {
            cn = new SqlConnection(miConexion);
        }

        public SqlConnection Abrir()
        {
            try
            {
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return cn;
        }


        public Boolean Cerrar()
        {

            Boolean conexionOK = true;
            
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexionOK = false;
            }

            return conexionOK;
        }


        public SqlCommand ArmarProcedimiento(string nombreProceso)
        {
            cmd = new SqlCommand(nombreProceso, cn);
            cmd.CommandType = CommandType.StoredProcedure;

            return cmd;
        }


        public void ArmarFuncion(string nombreFuncion)
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SFX." + nombreFuncion + "(@userName,@password);";
        }

        public void AgregarParametro(string parametro, object valor)
        {
            cmd.Parameters.AddWithValue(parametro, valor);
        }


        public void AgregarParametroOut(string parametro, object valor)
        {
            cmd.Parameters.AddWithValue(parametro, valor).Direction = ParameterDirection.Output;

        }


        public void EjecutarProcedimiento()
        {
            cmd.ExecuteNonQuery();
        }

        
        public void EjecutarFuncion()
        {
            cmd.ExecuteScalar();
        }


        public DataTable CargarTabla(SqlCommand miCommand)
        {
            DataTable ds = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(ds);
            return ds;
        }

        
        public DataTable cargarCombo(SqlCommand cmd)
        {
            //this.Abrir();
            DataTable dt = new DataTable();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            adap.Fill(dt);
            //this.Cerrar();
            return dt;

        }

        public DataTable cargarTabla(SqlCommand miCommand)
        {
            DataTable ds = new DataTable();
            //this.Abrir();
            miCommand.Connection = cn;
            miCommand.CommandType = CommandType.Text;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(miCommand);
            dataAdapter.Fill(ds);
            //this.Cerrar();
            return ds;
        }

        public void LoadDataGridView(DataGridView dgv)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el DataGridView " + ex.ToString());
            }
        }

        public DataTable EjecutarConsulta(String query)
        {
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            DataSet _dataSet = new DataSet();

            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {

                adapter.Fill(_dataSet);
            }

            return _dataSet.Tables[0];
        }

        public SqlDataReader EjecutarDataReader(String query)
        {
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            MessageBox.Show("El query recibido es: " + query);
            SqlDataReader dataReader = cmd.ExecuteReader();//new SqlDataReader();
            if (dataReader.Read() == true)
            {
                return dataReader;
            }
            else
            {
                MessageBox.Show("No hay datos para traer ");
                return null;
            }

        }
    }
}