using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba
{
    public partial class Menu_principal : Form
    {
        MenuStrip menuPrincipal;

        public Menu_principal()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_principal_Load(object sender, EventArgs e)
        {
            /* Cargar el Menú Principal según la configuración del Usuario */
            using (SqlConnection cnx = new SqlConnection(AerolineaFrba.Properties.Settings.Default.GD2C2015ConnectionString))
            {
                menuPrincipal = new MenuStrip();
                menuPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
                this.splitter1.Controls.Add(menuPrincipal);
                GD2C2015DataSet.fn_menu_usuarioDataTable dtMenu = new GD2C2015DataSet.fn_menu_usuarioDataTable();
                GD2C2015DataSetTableAdapters.fn_menu_usuarioTableAdapter daMenu = new AerolineaFrba.GD2C2015DataSetTableAdapters.fn_menu_usuarioTableAdapter();
                daMenu.Fill(dtMenu, Global.id_rol);
                dtMenu.DefaultView.Sort = "men_id_padre DESC, descripcion ASC";

                int id_padre = 0;
                int last_id_padre = 0;
                string last_descripcion = "";
                ToolStripMenuItem subMenu = null;
                ToolStripMenuItem menuItem = null;

                foreach (DataRowView dr in dtMenu.DefaultView)
                {
                    id_padre = System.Convert.ToInt32((dr["men_id_padre"].ToString()));
                    menuItem = new ToolStripMenuItem(dr["descripcion"].ToString(), null, new EventHandler(ChildClick));
                    if (!(id_padre.Equals(0)))
                    {
                        if (!(id_padre.Equals(last_id_padre)))
                        {
                            subMenu = new ToolStripMenuItem(dr["desc_submenu"].ToString());
                            menuPrincipal.Items.Add(subMenu);
                        }
                        subMenu.DropDownItems.Add(menuItem);
                    }
                    else
                    {
                        if (last_descripcion != dr["descripcion"].ToString())
                        {
                            menuPrincipal.Items.Add(menuItem);
                        }
                    }
                    last_id_padre = id_padre;
                    last_descripcion = dr["descripcion"].ToString();
                }

            }
        }

        private void ChildClick(object sender, EventArgs e)
        {
            GD2C2015DataSet.vw_MenuDataTable dt = new GD2C2015DataSet.vw_MenuDataTable();
            GD2C2015DataSetTableAdapters.vw_MenuTableAdapter da = new AerolineaFrba.GD2C2015DataSetTableAdapters.vw_MenuTableAdapter();
            da.Fill(dt);
            DataRow[] dr_array = dt.Select("descripcion = '" + sender.ToString() + "'");

            Assembly frmAssembly = Assembly.LoadFile(Application.ExecutablePath);

            foreach (Type type in frmAssembly.GetTypes())
            {
                if (type.BaseType == typeof(Form))
                {

                    if (type.Name == dr_array[0]["men_formulario"].ToString())
                    {
                        Form frmShow = (Form)frmAssembly.CreateInstance(type.ToString());
                        frmShow.TopLevel = false;
                        this.panel1.Controls.Add(frmShow);
                        //this.splitter2.Controls.Add(frmShow);
                        frmShow.Show();// Show();
                        break;
                    }
                }
            }
        }

    }
}
