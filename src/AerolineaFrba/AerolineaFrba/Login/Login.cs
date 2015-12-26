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
    public partial class Login : Form
    {

        SqlCommand cmd;
        int id_usuario = 0;
        int cant_roles = 0;
        bool LoginOK = false;
        Conexion cnn = new Conexion();
        
        
        public Login()
        {
            InitializeComponent();
        }



        private void establecerRol()
        {

            if (cant_roles > 1)
            {
                Rol_login formLoginRol = new Rol_login();
                formLoginRol.ShowDialog(this);
                Global.id_rol = formLoginRol.ID_Rol_Seleccionado;
                if (Global.id_rol == 0) this.establecerRol();
            }
            else if (cant_roles == 0)
            {
                MessageBox.Show("El usuario ingresado no tiene rol asignado. Error de Inicio de Sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select r.Rol_Id, r.Rol_Nombre From SFX.t_rol_usuario u, SFX.t_Roles r Where u.Rxu_Usu_Id = " + Convert.ToString(Global.id_usuario) + " and r.Rol_Id  = u.Rxu_Rol_Id");
                DataTable dt = cnn.cargarTabla(cmd);
                Global.id_rol = Convert.ToInt32(dt.Rows[0]["rol_id"].ToString());
            }

        }


        
        private void CargarMenuPrincipal()
        {
            if (Global.id_rol != 0)
            {
                Menu_principal frmMenu = new Menu_principal();
                frmMenu.ShowDialog();
            }
            this.Close();

        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtUsuario.Text = "";
            this.txtContra.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            string ContraEncriptado = Global.encriptarSHA256(this.txtContra.Text);
            
            try
            {
                cmd = cnn.ArmarProcedimiento("SFX.IniciarSesion");

                cmd.Parameters.Add("@userName", SqlDbType.Char).Value = this.txtUsuario.Text;
                cmd.Parameters.Add("@password", SqlDbType.Char).Value = ContraEncriptado;//this.txtContra.Text;
                cmd.Parameters.Add("@existe", SqlDbType.Bit).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@usu_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@cant_roles", SqlDbType.Int).Direction = ParameterDirection.Output;


                try
                {
                    cnn.Abrir();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cnn.Cerrar();
                    LoginOK = cmd.Parameters["@existe"].Value.Equals(true);
                    id_usuario = System.Convert.ToInt32(cmd.Parameters["@usu_id"].Value);
                    cant_roles = System.Convert.ToInt32(cmd.Parameters["@cant_roles"].Value);

                }
                
                
                if (LoginOK)
                {
                    Global.id_usuario = id_usuario;

                    this.establecerRol();
                    this.Hide();
                    this.CargarMenuPrincipal();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
