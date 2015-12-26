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

namespace AerolineaFrba.Login
{
    public partial class Rol_login : Form
    {

        public int ID_Rol_Seleccionado = 0;

        public Rol_login()
        {
            InitializeComponent();


            /* Cargar Roles del Usuario en la Lista Desplegable */
            Conexion cnx = new Conexion();
            DataTable dtRolesUsuario = cnx.cargarCombo(new SqlCommand("Select r.Rol_Id, r.Rol_Nombre From SFX.t_rol_usuario u, SFX.t_Roles r Where u.Rxu_Usu_Id = " + Global.id_usuario + " and r.Rol_Id  = u.Rxu_Rol_Id"));
            cmbRol.DataSource = dtRolesUsuario;
            cmbRol.DisplayMember = "rol_nombre";
            cmbRol.ValueMember = "rol_id";
            cmbRol.SelectedIndex = -1;
        
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Debe elegir un Rol.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ID_Rol_Seleccionado = Convert.ToInt32(this.cmbRol.SelectedValue.ToString());
                this.Close();
            }
        }

        private void Rol_login_Load(object sender, EventArgs e)
        {

        }

        
    }
}
