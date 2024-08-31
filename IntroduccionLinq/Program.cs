
// Se incluye el espacio de nombres "IntroduccionLinq"
// para poder utilizar las clases y métodos definidos en él.
using IntroduccionLinq;

#region Introduccion 
/*string[]palabras;
// Se define un arreglo de strings llamado "palabras" y se inicializa con una lista de palabras.
palabras = new string[] { "gato", "perro", "lagarto", "tortuga", "cocdrilo","serpiente", "123456789" };
// Se imprime un mensaje en la consola
Console.WriteLine("Mas de 5 letras");

// Se crea una lista vacía de strings llamada "resultado" que almacenará las palabras que cumplan la condición.
List<string> resultado = new List<string>();

// Se itera sobre cada palabra en el arreglo "palabras".
// Si la longitud de la palabra es mayor a 5 caracteres, se agrega a la lista "resultado".
foreach (string str in palabras) {
    if (str.Length >5) {
        resultado.Add(str);
    }
}

// Se itera sobre la lista "resultado" y se imprime 
cada palabra en la consola.
foreach (var r in resultado) 
    Console.WriteLine(r);
*/
#endregion
#region utilizando Linq
/*
// Se utiliza una consulta LINQ para seleccionar palabras del arreglo "palabras" que tengan más de 8 caracteres.
// El resultado es un IEnumerable<string> llamado "list". 
Console.WriteLine("-----------------------------------------------------");    
IEnumerable<string> list = from r in palabras where r.Length > 8 select r;

// Se itera sobre el IEnumerable "list" y se imprime cada palabra en la consola.
foreach(var listado in list)
    Console.WriteLine(listado);
Console.WriteLine("-----------------------------------------------------");
*/
#endregion
#region ListaModelos
// Se crean dos listas vacías, "ListaCasas" para almacenar objetos de tipo "Casa" y "ListaHabitantes"
// para almacenar objetos de tipo "Habitante".
List<Casa> ListaCasas = new List<Casa>();
List<Habitante> ListaHabitantes = new List<Habitante>();
#endregion
#region listaCasa
// Se añade un objeto "Casa" a la lista "ListaCasas" con propiedades específicas.
ListaCasas.Add(new Casa { 
    Id=1,
    Direccion= "3 av Norte ArcanCity",
    Ciudad= "Gothan City",
    numeroHabitaciones= 20,
});
// Se añade otro objeto "Casa" con diferentes valores.
ListaCasas.Add(new Casa
{
    Id = 2,
    Direccion = "6 av Sur SmollVille",
    Ciudad = "Metropolis",
    numeroHabitaciones = 5,
});
// Se añade un tercer objeto "Casa" con solo dos propiedades definidas.
ListaCasas.Add(new Casa{ 
    Id = 3,
    Direccion= "Forest Hills, Queens, NY 11375",
    Ciudad = "New York"
});
#endregion
#region ListaHabitante
// Se añade un objeto "Habitante" a la lista "ListaHabitantes" con propiedades específicas.
ListaHabitantes.Add(new Habitante { 
    IdHabitante= 1,
    Nombre = "Bruno Diaz",
    Edad= 36,
    IdCasa= 1
});
// Se añade otro objeto "Habitante" con diferentes valores.
ListaHabitantes.Add(new Habitante {
    IdHabitante = 2,
    Nombre = "Clark Kent.",
    Edad = 40,
    IdCasa = 2
});
// Se añade un tercer objeto "Habitante" con propiedades definidas.
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 3,
    Nombre = "Peter Parker",
    Edad = 25,
    IdCasa = 3
});
// Se añade otro habitante, "Tia Mey", a la lista, con el mismo IdCasa que "Peter Parker".
ListaHabitantes.Add(new Habitante {
    IdHabitante = 3,
    Nombre = "Tia Mey",
    Edad = 85,
    IdCasa = 3
});
// Se añade "Luise Lain" a la lista, asociada con la misma casa que "Clark Kent".
ListaHabitantes.Add(new Habitante{
    IdHabitante = 2,
    Nombre = "Luise Lain",
    Edad = 40,
    IdCasa = 2
});
// Se añade "Selina Kyle" a la lista, asociada con la casa de "Bruno Diaz".
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Selina Kyle",
    Edad = 30,
    IdCasa = 1
});
// Se añade "Alfred" a la lista, también asociado con la casa de "Bruno Diaz".
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Alfred",
    Edad = 65,
    IdCasa = 1
});
// Se añade "Nathan Drake" a la lista, otro habitante en la misma casa que "Bruno Diaz".
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Nathan Drake",
    Edad = 37,
    IdCasa = 1
});
#endregion
#region SentenciasLinQ
/*
// Se utiliza LINQ para seleccionar todos los habitantes cuya edad sea mayor a 40 años.
// El resultado es un IEnumerable<Habitante> llamado "ListaEdad".
IEnumerable<Habitante> ListaEdad = from ObjetoProvicional
                                   in ListaHabitantes
                                   where ObjetoProvicional.Edad > 40
                                   select ObjetoProvicional;

// Se itera sobre "ListaEdad" y se imprime la información de cada habitante en la consola.
foreach (Habitante objetoProcicional2 in ListaEdad)
{
    Console.WriteLine(objetoProcicional2.datosHabitante());
}

//Join

// Se realiza una consulta LINQ con un "join" para combinar la lista de habitantes con la lista de casas.
// El join se realiza en base al IdHabitante y el IdCasa, y se filtra para habitantes en "Gothan City".
IEnumerable<Habitante> listaCasaGothan = from objetoTemporalHabitante in ListaHabitantes
                                         join objetoTemporalCasa in ListaCasas
                                         on objetoTemporalHabitante.IdHabitante equals objetoTemporalCasa.Id
                                         where objetoTemporalCasa.Ciudad   == "Gothan City"
                                         select objetoTemporalHabitante;
Console.WriteLine("----------------------------------------------------------------------------------------------");

// Se imprime la información de los habitantes que viven en "Gothan City".
foreach (Habitante h in listaCasaGothan) {
    Console.WriteLine (h.datosHabitante());
}
*/
#endregion
#region FirsthAndFirsthOrDefault
/* Console.WriteLine("----------------------------------------------------------------------------------------------");

// Se obtiene la primera casa en la lista "ListaCasas" usando el método First().
var primeraCasa = ListaCasas.First(); //esto no es linQ es  una fucnin de los Ienumarable
Console.WriteLine(primeraCasa.dameDatosCasa());

//aplicando una restriccion sin restricion lambda
// Se utiliza LINQ para seleccionar el primer habitante cuya edad sea mayor a 25 años.
Habitante personaEdad = (from variableTemporalHabitante in ListaHabitantes where variableTemporalHabitante.Edad > 25 select variableTemporalHabitante).First();
Console.WriteLine(personaEdad.datosHabitante());
Console.WriteLine("---------------------------Lo mismo pero con lambdas---------------------------------------------------------");
// Se hace lo mismo que la línea anterior, pero usando una expresión lambda.
var Habitante1 = ListaHabitantes.First(objectTemp => objectTemp.Edad >25);
Console.WriteLine(Habitante1.datosHabitante());

// Si no tenemos el elemento que buscamos entoences la sonsulta devolvera una exepcion esto detendra el codigo en su totalidad
//Casa EdadError = (from vCasaTemp in ListaCasas where vCasaTemp.Id >10 select vCasaTemp).First() ;
//Console.WriteLine(EdadError.dameDatosCasa());
// Se intenta obtener la primera casa con un Id mayor a 200. Si no existe, se devuelve null.
Casa CasaConFirsthOrDedault = ListaCasas.FirstOrDefault(vCasa => vCasa.Id > 200);

// Si no se encontró ninguna casa, se imprime un mensaje y se sale del método.
if (CasaConFirsthOrDedault == null ) {
    Console.WriteLine("No existe !No hay!");
    return;
}
Console.WriteLine("existe !Si existe!");
*/
#endregion
#region Last
/*
// Se obtiene la última casa en la lista "ListaCasas" que tenga un Id mayor a 1. 
Casa ultimaCasa = ListaCasas.Last(temp => temp.Id>1);
Console.WriteLine(ultimaCasa.dameDatosCasa());
Console.WriteLine("_____________________________________________________");

// Se utiliza LINQ para seleccionar el último habitante cuya edad sea mayor a 60 años. Si no existe, devuelve null.
var h1 = (from objHabitante in ListaHabitantes where objHabitante.Edad > 60 select objHabitante)
    .LastOrDefault();

// Si no se encontró ningún habitante, se imprime un mensaje de error.
if (h1 == null) {
    Console.WriteLine("Algo fallo");
return;
}
Console.WriteLine(h1.datosHabitante());
*/
#endregion
#region ElementAt
/*
// Se obtiene la casa en la posición 3 (índice 2) de la lista "ListaCasas".
var terceraCasa = ListaCasas.ElementAt(2);
Console.WriteLine($"La tercera casa es {terceraCasa.dameDatosCasa()}");

// Se intenta obtener la casa en la posición 4 (índice 3). Si no existe, devuelve null.
var casaError = ListaCasas.ElementAtOrDefault(3);
if ( casaError != null) { Console.WriteLine($"La tercera casa es {casaError.dameDatosCasa()}"); }

// Utiliza LINQ para seleccionar el tercer habitante en la lista (índice 2). Si no existe, devuelve null.
var segundoHabitante = (from objetoTem in ListaHabitantes select objetoTem).ElementAtOrDefault(2);
Console.WriteLine($" segundo habitante es : {segundoHabitante.datosHabitante()}");
*/
#endregion
#region single
/*

try {
    // Utiliza el método "Single" para encontrar un habitante cuya edad esté entre 40 y 70 años. 
    // Lanza una excepción si no hay exactamente un elemento que cumpla la condición.
    var habitantes = ListaHabitantes.Single(variableTem => variableTem.Edad > 40 && variableTem.Edad <70);
    // Creando esta consulta pero con LinQ
    
    // Utiliza LINQ con "SingleOrDefault" para seleccionar un habitante mayor de 70 años. 
    // Devuelve null si no se encuentra ningún elemento.
    var habitante2 = (from obtem in ListaHabitantes where obtem.Edad >70 select obtem).SingleOrDefault() ;

    Console.WriteLine($"habitante con menos de 20 años {habitantes.datosHabitante()}");
        // Imprime la información de los habitantes seleccionados.
    if ( habitante2 != null ) Console.WriteLine($"habitante con mas de 70 años {habitante2.datosHabitante()}");
}
catch (Exception) {
    Console.WriteLine($"Ocurrio el error"); // Captura la excepción en caso de que la consulta "Single" no cumpla con la condición.

}
*/
#endregion
#region typeOf
/* 
// Se crea una lista de empleados que incluye objetos de tipo "Medico" y "Enfermero". 
 var listaEmpleados = new List<Empleado>() { 
    new Medico(){ nombre= "Jorge Casa" },
    new Enfermero(){ nombre = "Raul Blanco"}
};

// Filtra la lista para obtener solo los objetos de tipo "Medico".
var medico = listaEmpleados.OfType<Medico>();
Console.WriteLine(medico.Single().nombre);
*/
#endregion
#region OrderBy
/*
// Ordena la lista de habitantes por edad en orden ascendente. 
var edadA = ListaHabitantes.OrderBy(x => x.Edad);
// Lo mismo que arriba, pero usando sintaxis LINQ.
var edadAC = from vt in ListaHabitantes orderby vt.Edad select vt;

// Imprime la información de los habitantes ordenados por edad.
foreach (var edad in edadAC) { 
    Console.WriteLine(edad.datosHabitante());
}
*/
#endregion
#region OrderBYDescending()
/* 
// Ordena la lista de habitantes por edad en orden descendente. 
 var listaEdad = ListaHabitantes.OrderByDescending(x => x.Edad);
// Imprime la información de los habitantes en orden descendente.
foreach (Habitante h in listaEdad) { 
    Console.WriteLine(h.datosHabitante());
}
Console.WriteLine("-------------------------------------------");

// Lo mismo que arriba, pero usando sintaxis LINQ.
var ListaEdad2 = from h in ListaHabitantes orderby h.Edad descending select h;
// Imprime la información de los habitantes ordenados por edad en orden descendente.
foreach (Habitante h in ListaEdad2)
{
    Console.WriteLine(h.datosHabitante());
}
*/
#endregion
#region ThenBy
//var habitantes3 = ListaHabitantes.OrderBy(x => x.Edad).ThenBy(x => x.Nombre);


// Ordena primero por edad y luego por nombre en orden descendente.
var edadATA = from h in ListaHabitantes orderby h.Edad, h.Nombre descending select h;

// Imprime la información de los habitantes, primero ordenados por edad y luego por nombre.
foreach (var h in edadATA)
{
    Console.WriteLine(h.datosHabitante());
}

Console.WriteLine("------------------");

//var habitantes4 = ListaHabitantes.OrderBy(x => x.Edad).ThenByDescending(x => x.Nombre);

// Lo mismo que arriba, pero esta vez el nombre se ordena en orden ascendente.
var lista4 = from h in ListaHabitantes orderby h.Edad, h.Nombre ascending select h;

// Imprime la información de los habitantes ordenados por edad y nombre en orden ascendente.
foreach (var h in lista4)
{
    Console.WriteLine(h.datosHabitante());
}

#endregion
