using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    // Definición de una clase pública llamada "Enfermero" que hereda de la clase "Empleado".
    // ¿Qué siginifica?
    // Significa que "Enfermero" tiene todas las propiedades y métodos de "Empleado".
    public class Enfermero : Empleado
    {
        // Se usa para almacenar el nombre del enfermero.
        // Nota: Esta propiedad sobrescribe la propiedad "nombre"
        // heredada de "Empleado".
        public string nombre { get; set; }
    }
}
