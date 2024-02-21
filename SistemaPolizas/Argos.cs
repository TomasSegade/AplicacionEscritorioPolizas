using System;
using System.Windows.Forms;

namespace SistemaPolizas
{
    public partial class form_Argos : Form
    {
        private GestorDatos gestorDatos;

        public form_Argos()
        {
            InitializeComponent();

            // Especifica la ruta del archivo CSV
            string rutaArchivo = "D:\\Tomas\\Escritorio\\sistema_polizas\\sistema_polizas\\archivoCSV_ARGOS.csv";

            // Inicializa el gestor de datos con la ruta especificada
            gestorDatos = new GestorDatos(rutaArchivo);
        }

        private void MostrarLista()
        {
            lst_lista.DataSource = null;
            lst_lista.DataSource = gestorDatos.ListarVehiculos();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            // Aquí puedes implementar la lógica para modificar un vehículo
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Dni.Text.Length > 0 && txt_Endoso.Text.Length > 0 && txt_Patente.Text.Length > 0)
                {
                    Clase_Argos clase_Argos = new Clase_Argos();

                    clase_Argos.DNI = Convert.ToInt32(txt_Dni.Text);
                    clase_Argos.patente = txt_Patente.Text;
                    clase_Argos.endoso = Convert.ToInt32(txt_Endoso.Text);

                    gestorDatos.AgregarVehiculo(clase_Argos);
                    MostrarLista();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar");
            }
        }
    }
}
