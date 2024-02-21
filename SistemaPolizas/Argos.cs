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
            string rutaArgos = "C:\\Users\\Tomas\\Desktop\\script_python\\archivoCSV_ARGOS.csv";

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

        private void lst_lista_Leave(object sender, EventArgs e)
        {
            // Desmarcar la selección del ListBox
            lst_lista.ClearSelected();
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

                    gestorDatos.AgregarVehiculo(clase_Argos);
                    MostrarLista();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar");
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

        private void lst_lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un elemento en la lista
            if (lst_lista.SelectedIndex != -1)
            {
                // Si hay un elemento seleccionado, deshabilitar el botón de agregar
                btn_Agregar.Enabled = false;
            }
            else
            {
                // Si no hay un elemento seleccionado, habilitar el botón de agregar
                btn_Agregar.Enabled = true;
            }
        }

    }
}
