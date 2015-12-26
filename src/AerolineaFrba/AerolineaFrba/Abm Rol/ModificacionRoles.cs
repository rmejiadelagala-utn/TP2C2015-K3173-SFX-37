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
    public partial class ModificacionRoles : Form
    {
        private int rol_id = 0;
        GD2C2015DataSet.vw_Rol_Func_ExistenciaDataTable dt_Funcionalidades;
        
        public ModificacionRoles()
        {
            InitializeComponent();
            this.btnAceptar.Enabled = false;
            
            Conexion cnx = new Conexion();
            DataTable dtRolesUsuario = cnx.cargarCombo(new SqlCommand("Select Rol_Id, Rol_Nombre From SFX.t_Roles"));
            cmbRoles.DataSource = dtRolesUsuario;
            cmbRoles.DisplayMember = "rol_nombre";
            cmbRoles.ValueMember = "rol_id";
            cmbRoles.SelectedIndex = -1;

        }

        private void ModificacionRoles_Load(object sender, EventArgs e)
        {

        }

        private void Refrescar()
        {
            chkFuncionalidades.Items.Clear();
           // rol_id = Convert.ToInt32(cmbRoles.SelectedValue);

            if (rol_id != 0)
            {
                GD2C2015DataSet.t_rolesDataTable dt_Rol = new GD2C2015DataSet.t_rolesDataTable();
                GD2C2015DataSetTableAdapters.t_rolesTableAdapter da_Rol = new AerolineaFrba.GD2C2015DataSetTableAdapters.t_rolesTableAdapter();
                da_Rol.Fill(dt_Rol);
                GD2C2015DataSet.t_rolesRow dr_Rol = dt_Rol.FindByRol_Id(rol_id);
                this.txtRol.Text = dr_Rol.Rol_Nombre;
                this.checkBoxActivo.Checked = dr_Rol.Rol_activo;



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
            else
            {
                this.txtRol.Text = String.Empty;
                this.checkBoxActivo.Checked = true;
            }
                        
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtRol.Text = String.Empty;
            this.cmbRoles.SelectedIndex = -1;
            this.btnAceptar.Enabled = false;
            foreach (int i in chkFuncionalidades.CheckedIndices)
            {
                chkFuncionalidades.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void chkFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.btnAceptar.Enabled = true;
            if (cmbRoles.ValueMember != "")
            {
                rol_id = Convert.ToInt32(cmbRoles.SelectedValue);
            }
            Refrescar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnx = new SqlConnection(AerolineaFrba.Properties.Settings.Default.GD2C2015ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SFX.sp_ABM_Rol", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = rol_id;
                cmd.Parameters["@ID"].Direction = ParameterDirection.InputOutput;
                cmd.Parameters.Add("@Activo", SqlDbType.Bit).Value = this.checkBoxActivo.Checked;
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
                    MessageBox.Show("Se ha producido un error al modificar el Rol.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
              
    }
}
