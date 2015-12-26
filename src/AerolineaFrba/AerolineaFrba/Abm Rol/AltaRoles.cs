using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Rol
{
    public partial class AltaRoles : Form
    {
        private int rol_id = 0;
        GD2C2015DataSet.vw_Rol_Func_ExistenciaDataTable dt_Funcionalidades;

        public AltaRoles()
        {
            InitializeComponent();
            this.btnAceptar.Enabled = false;
            Refrescar();
        }

        private void AltaRoles_Load(object sender, EventArgs e)
        {

        }


        private void Refrescar()
        {
            chkFuncionalidades.Items.Clear();
            this.txtRol.Text = String.Empty;
            dt_Funcionalidades = new GD2C2015DataSet.vw_Rol_Func_ExistenciaDataTable();
            GD2C2015DataSetTableAdapters.vw_Rol_Func_ExistenciaTableAdapter da = new AerolineaFrba.GD2C2015DataSetTableAdapters.vw_Rol_Func_ExistenciaTableAdapter();
            da.Fill(dt_Funcionalidades);
            int index = 0;
    
            foreach (DataRow dr in dt_Funcionalidades.Select("rol_id = " + rol_id))
            {
                chkFuncionalidades.Items.Insert(index, dr["fun_nombre"].ToString());

                if (dr["Existencia"].ToString() == "1")
                {
                    chkFuncionalidades.SetItemCheckState(index, CheckState.Checked);
                }
                else
                {
                    chkFuncionalidades.SetItemCheckState(index, CheckState.Unchecked);
                }
                index += 1;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtRol.Text = String.Empty;
            this.btnAceptar.Enabled = false;
            this.checkBox1.Checked = false;
            foreach (int i in chkFuncionalidades.CheckedIndices)
            {
                chkFuncionalidades.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void txtRol_TextChanged(object sender, EventArgs e)
        {
            if (this.btnAceptar.Enabled == false)
                this.btnAceptar.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                for (int i = 0; i <= (chkFuncionalidades.Items.Count - 1); i++)
                {
                    chkFuncionalidades.SetItemChecked(i, true);
                }
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e) 
        {
            
        }

        private void chkFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (this.txtRol.Text == "")
            {
                MessageBox.Show("Debe especificar un Nombre para el Rol.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.chkFuncionalidades.CheckedIndices.Count == 0)
            {
                MessageBox.Show("Debe selecionar al menos una funcionalidad", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection cnx = new SqlConnection(AerolineaFrba.Properties.Settings.Default.GD2C2015ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SFX.sp_ABM_Rol", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = rol_id;
                cmd.Parameters["@ID"].Direction = ParameterDirection.InputOutput;
                cmd.Parameters.Add("@Activo", SqlDbType.Bit).Value = true;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txtRol.Text;
                DataTable tblFuncionalidades = new DataTable("FuncSeleccionadas");
                tblFuncionalidades.Columns.Add("ID", typeof(int));
                int i;
                for (i = 0; i <= (chkFuncionalidades.Items.Count - 1); i++)
                {
                    if (chkFuncionalidades.GetItemChecked(i))
                    {
                        tblFuncionalidades.Rows.Add(i + 1);
                    }
                }
                cmd.Parameters.AddWithValue("@Funcionalidades", tblFuncionalidades);
                try
                {
                    cmd.Connection.Open();
                    cmd.ExecuteScalar();
                    /* Modificación Rol */
                    MessageBox.Show("Los cambios se han guardado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Se ha producido un error al insertar el Rol.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



    }
}
