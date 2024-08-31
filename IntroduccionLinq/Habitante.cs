using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    public class Habitante
    {
        // Propiedades públicas de tipo entero "IdHabitante", string "Nombre", entero "Edad", entero "IdCasa".
        
        // Se usa para almacenar un identificador único para cada habitante.
        public int IdHabitante {get;set;}
        // Se usa para almacenar el nombre del habitante.
        public string Nombre {get; set;}
        // Se usa para almacenar la edad del habitante.
        public int Edad {get; set;}
        // Se usa para almacenar el identificador de la casa donde vive el habitante.
        public int IdCasa { get; set;}

        // Este método devuelve una cadena con los datos del habitante,
        public string datosHabitante() {

            // Se utiliza interpolación de cadenas para devolver una descripción del habitante.
            // La cadena contiene los valores de las propiedades "Nombre", "Edad" e "IdCasa".
            return $"Soy {Nombre} con edad de {Edad} años vividos en {IdCasa}";
        }
    }
}
