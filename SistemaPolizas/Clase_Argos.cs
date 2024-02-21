using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolizas
{
    internal class Clase_Argos
    {
        public int DNI { get; set; }
        public string patente { get; set; }
        public int endoso { get; set; }

        public Clase_Argos()
        {

        }

        public Clase_Argos(string linea)
        {
            string[] datos;
            datos = linea.Split(',');

            DNI = Convert.ToInt32(datos[0]);
            patente = datos[1];
            endoso = Convert.ToInt32(datos[2]);


        }

        public string GenerarVehiculo()
        {
            return $"{DNI},{patente},{endoso}";
        }

        public override string ToString()
        {
            return string.Format($"Dni: {DNI} \tPatente: {patente} \tEndoso: {endoso}");
        }

    }
}
