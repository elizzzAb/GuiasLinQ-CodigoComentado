using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    // Definición de una clase pública llamada "Medico" que hereda de la clase "Empleado".
    // Esto significa que :
    // "Medico" tiene todas las propiedades y métodos de "Empleado".
    public class Medico : Empleado
    {
         // Se usa para almacenar el nombre del médico.
        // Nota: Esta propiedad sobrescribe la propiedad "nombre"
        // heredada de "Empleado".
        public string nombre { get; set; }
    }
}
