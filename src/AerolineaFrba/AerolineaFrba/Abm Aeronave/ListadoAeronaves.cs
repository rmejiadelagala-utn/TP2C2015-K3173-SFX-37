using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();

            cmbListados.Items.Add("Top 5 de los destinos con más pasajes comprados.");
            cmbListados.Items.Add("Top 5 de los destinos con aeronaves más vacías.");
            cmbListados.Items.Add("Top 5 de los Clientes con más puntos acumulados a la fecha.");
            cmbListados.Items.Add("Top 5 de los destinos con pasajes cancelados.");
            cmbListados.Items.Add("Top 5 de las aeronaves con mayor cantidad de días fuera de servicio.");
            cmbListados.SelectedIndex = 0;
            cmbSemestre.Items.Add("Primero");
            cmbSemestre.Items.Add("Segundo");
            cmbSemestre.SelectedIndex = 0;

            numericUpDownAnio.Value = 2016;

        }

        private void ListadoAeronaves_Load(object sender, EventArgs e)
        {

        }
    }
}
