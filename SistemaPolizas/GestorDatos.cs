using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SistemaPolizas
{
    internal class GestorDatos
    {
        public string Ruta { get; set; }

        public GestorDatos(string ruta) 
        {
            Ruta = ruta;

            // Verificar si el archivo ya existe
            if (File.Exists(ruta))
            {
                // Si existe, sobrescribirlo y dejarlo en blanco
                File.WriteAllText(ruta, string.Empty);
            }
            else
            {
                // Si no existe, crear uno nuevo
                File.Create(ruta).Close();
            }

        }

        public List<Clase_Argos> ListarVehiculos()
        {

            List<Clase_Argos> vehiculos = new List<Clase_Argos>();

            FileStream fs = new FileStream(Ruta, FileMode.OpenOrCreate, FileAccess.Read);

            using (StreamReader reader = new StreamReader(fs))
            {
                // Leer la primera línea (encabezados) sin hacer nada con ella
                reader.ReadLine();

                // Leer las líneas restantes (datos de vehículos)
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Clase_Argos vehiculo = new Clase_Argos(linea);
                    vehiculos.Add(vehiculo);
                    linea = reader.ReadLine();
                }
            }
            fs.Close();
            return vehiculos;

        }

        public void AgregarVehiculo(Clase_Argos clase_Argos)
        {
            // Verificar si el archivo existe
            bool existeArchivo = File.Exists(Ruta);


            FileStream fs = new FileStream(Ruta, FileMode.Append, FileAccess.Write);

            using (StreamWriter writer = new StreamWriter(fs))
            {
                // Si el archivo no existe, agregar los encabezados
                if (!existeArchivo || new FileInfo(Ruta).Length == 0)
                {
                    writer.WriteLine("DNI,Patente,Endoso");
                }

                writer.WriteLine(clase_Argos.GenerarVehiculo());

            }
            fs.Close();
        }

        public void ModificarVehiculo(string patente, Clase_Argos nuevosDatos)
        {
            // Obtener la lista de vehículos
            List<Clase_Argos> vehiculos = ListarVehiculos();

            // Buscar el vehículo por su patente
            Clase_Argos vehiculo = vehiculos.FirstOrDefault(v => v.patente == patente);

            if (vehiculo != null)
            {
                // Actualizar los datos del vehículo
                vehiculo.DNI = nuevosDatos.DNI;
                vehiculo.patente = nuevosDatos.patente;
                vehiculo.endoso = nuevosDatos.endoso;

                // Sobrescribir el archivo con los datos actualizados
                EscribirListaEnArchivo(vehiculos);
            }
            else
            {
                throw new Exception("No se encontró un vehículo con la patente especificada.");
            }
        }

        private void EscribirListaEnArchivo(List<Clase_Argos> vehiculos)
        {
            // Sobrescribir el archivo con los datos actualizados
            using (StreamWriter writer = new StreamWriter(Ruta))
            {
                writer.WriteLine("DNI,Patente,Endoso"); // Escribir encabezados

                foreach (var vehiculo in vehiculos)
                {
                    writer.WriteLine(vehiculo.GenerarVehiculo());
                }
            }
        }

        public void EliminarVehiculo(string patente)
        {
            string output = string.Empty;

            FileStream fs = new FileStream(Ruta, FileMode.OpenOrCreate, FileAccess.Read);

            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Clase_Argos vehiculo = new Clase_Argos(linea);
                    if (vehiculo.patente != patente)
                    {
                        output += linea + Environment.NewLine;
                    }

                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            fs = new FileStream(Ruta, FileMode.Truncate, FileAccess.Write);

            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(output);
            }
        }


    }
}
