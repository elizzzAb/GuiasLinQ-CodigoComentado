using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Este espacio organiza las clases y otros tipos, evitando colisiones de nombres.
namespace IntroduccionLinq
{
    // Definición de una clase pública llamada "Casa"
    public class Casa
    {
        // Las siguientes son propiedades públicas de tipo entero "Id", string "Direccion", string "Ciudad", entero "numeroHabitaciones".

        // Se usa para almacenar un identificador único para cada instancia de "Casa".
        public int Id {  get; set; }
        // Se usa para almacenar la dirección de la casa.
        public string Direccion { get; set;}
        // Se usa para almacenar la ciudad donde se encuentra la casa.
        public string Ciudad { get; set;}
        // Se usa para almacenar el número de habitaciones en la casa.
        public int numeroHabitaciones {  get; set;}

        // El siguiente es un método público que no recibe parámetros y devuelve un string.
        // Devuelve una cadena con la dirección, la ciudad y el número de habitaciones de la casa.
        public string dameDatosCasa () {

            // Se utiliza interpolación de cadenas para devolver una descripción de la casa.
            // La cadena contiene los valores de las propiedades "Direccion", "Ciudad" y "numeroHabitaciones".
          return $"Direcion es {Direccion} en la ciudad de {Ciudad} con numero de habitaciones {numeroHabitaciones}"; 
        }

    }
}
