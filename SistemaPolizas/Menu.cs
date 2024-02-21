using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPolizas
{
    public partial class form_Menu : Form
    {

        public form_Menu()
        {
            InitializeComponent();
        }

        private void btn_Argos_Click(object sender, EventArgs e)
        {
            form_Argos form_argos = new form_Argos();
            form_argos.ShowDialog();
            btn_Finisterre.Enabled = false;

            // Especificar la ruta deseada para el archivo CSV de Argos
            string rutaArgos = "D:\\Tomas\\Escritorio\\sistema_polizas\\sistema_polizas\\archivoCSV_ARGOS.csv";

            GestorDatos gestorArgos = new GestorDatos(rutaArgos);

        }
    }
}
