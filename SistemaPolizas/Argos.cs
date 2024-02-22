using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaPolizas
{
    public partial class form_Argos : Form
    {
        private GestorDatos gestorDatos;
        private string patenteSeleccionada = "";

        public form_Argos()
        {
            InitializeComponent();

            // Especifica la ruta del archivo CSV
            string rutaArgos = "D:\\Tomas\\Escritorio\\sistema_polizas\\sistema_polizas\\archivoCSV_ARGOS.csv";

            // Inicializa el gestor de datos con la ruta especificada
            gestorDatos = new GestorDatos(rutaArgos);

        }

        private void MostrarLista()
        {
            lst_lista.DataSource = null;
            lst_lista.DataSource = gestorDatos.ListarVehiculos();
        }

        private void LimpiarCampos()
        {
            txt_Dni.Clear();
            txt_Patente.Clear();
            txt_Endoso.Clear();
        }



        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado un elemento en la lista
                if (lst_lista.SelectedIndex != -1)
                {
                    // Obtener el vehículo seleccionado
                    Clase_Argos vehiculoSeleccionado = (Clase_Argos)lst_lista.SelectedItem;

                    // Obtener los nuevos datos del vehículo desde los campos de texto
                    int nuevoDNI = Convert.ToInt32(txt_Dni.Text);
                    string nuevaPatente = txt_Patente.Text;
                    int nuevoEndoso = Convert.ToInt32(txt_Endoso.Text);

                    // Crear un objeto Clase_Argos con los nuevos datos
                    Clase_Argos nuevosDatos = new Clase_Argos
                    {
                        DNI = nuevoDNI,
                        patente = nuevaPatente,
                        endoso = nuevoEndoso
                    };

                    // Modificar el vehículo en el gestor de datos
                    gestorDatos.ModificarVehiculo(vehiculoSeleccionado.patente, nuevosDatos);

                    // Actualizar la lista y los campos de texto
                    MostrarLista();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un vehículo de la lista para modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar: {ex.Message}");
            }
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

                    // Verificar si la patente ya existe
                    if (gestorDatos.ListarVehiculos().Any(v => v.patente == clase_Argos.patente))
                    {
                        throw new Exception("La patente ya ha sido ingresada anteriormente.");
                    }

                    gestorDatos.AgregarVehiculo(clase_Argos);
                    MostrarLista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar: {ex.Message}");
            }
        }

        private void txt_Dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y la tecla de retroceso (backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar el carácter
            }

            // Limitar la longitud total a 8 dígitos
            if (txt_Dni.Text.Length >= 8 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar el carácter
            }
        }

        private void txt_Patente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo caracteres alfanuméricos y la tecla de retroceso (backspace)
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar el carácter
            }

            // Limitar la longitud total a 7 caracteres
            if (txt_Patente.Text.Length >= 7 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar el carácter
            }
        }

        private void txt_Endoso_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y la tecla de retroceso (backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar el carácter
            }

            // Limitar la longitud total a 8 dígitos
            if (txt_Endoso.Text.Length >= 1 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar el carácter
            }
        }


        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay un elemento seleccionado en la lista
                if (lst_lista.SelectedItem != null)
                {
                    // Obtener el vehículo seleccionado
                    Clase_Argos vehiculoEliminar = (Clase_Argos)lst_lista.SelectedItem;

                    // Eliminar el vehículo seleccionado
                    gestorDatos.EliminarVehiculo(vehiculoEliminar.patente);

                    // Actualizar la lista
                    MostrarLista();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un vehículo de la lista para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}");
            }
        }
    }
}