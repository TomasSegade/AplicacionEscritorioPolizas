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


    }
}
