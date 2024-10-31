

// - 1.IEnumerable -
//Propósito:
//Es la interfaz más básica para colecciones. Se usa principalmente 
//para iterar sobre una colección, y es adecuada para casos donde solo necesitas 
//recorrer los elementos.
//Métodos importantes:
//GetEnumerator(): Devuelve un enumerador que permite recorrer la colección.
//Características:
//- Solo permite iteración, sin acceso directo por índice.
//- Es read-only, por lo que no se pueden agregar, eliminar o modificar elementos.
//- Soporta el uso de foreach en C# para recorrer elementos.
//- Se evalúa de forma diferida (Lazy Evaluation) cuando se usa con LINQ.
//Uso común:
//Ideal para colecciones donde solo necesitas leer los datos 
//sin manipularlos directamente.
using System;

IEnumerable<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
foreach (var numero in numeros)
{
    Console.WriteLine(numero);
}



//2.ICollection
//Propósito:
//Extiende IEnumerable y agrega características para modificar colecciones, 
//como agregar y eliminar elementos. Es más útil cuando necesitas manipular los 
//elementos de la colección.
//Espacio de nombres:
//System.Collections para no genéricos y System.Collections.
//Generic para genéricos.
//Métodos y propiedades importantes:
//Count:
//Obtiene el número de elementos en la colección.
//Add(T item):
//Agrega un elemento a la colección.
//Remove(T item):
//Elimina un elemento de la colección.
//Clear():
//Elimina todos los elementos.
//Contains(T item):
//Verifica si un elemento está en la colección.
//Características:
//Es mutable; permite agregar, eliminar y consultar el tamaño.
//No tiene acceso por índice, por lo que no puedes obtener elementos por posición.
//Uso común: 
//Útil para colecciones donde se necesita manipulación básica 
//(agregar o eliminar elementos), como una lista simple de objetos o una cola de eventos.
ICollection<string> nombres = new List<string> { "Juan", "Ana", "Carlos" };
nombres.Add("Marta");
nombres.Remove("Ana");
Console.WriteLine("Número de nombres: " + nombres.Count);



//3.IList
//Propósito:
//Extiende ICollection y permite acceso directo a los elementos por índice, 
//lo que facilita la manipulación de elementos en posiciones específicas.
//Espacio de nombres: System.Collections y System.Collections.Generic.
//Métodos y propiedades importantes:
//this[int index]:
//Propiedad de índice que permite acceso a un elemento por su posición.
//Insert(int index, T item):
//Inserta un elemento en una posición específica.
//RemoveAt(int index):
//Elimina un elemento en una posición específica.
//Características:
//- Permite acceso directo y manipulación por índice.
//- Facilita operaciones en posiciones específicas, como Insert y RemoveAt.
//- Se usa cuando el orden y la posición de los elementos es importante.
//Uso común:
//Es ideal para colecciones en las que el acceso y la manipulación por índice
//son necesarios, como listas ordenadas.
IList<int> numeros2 = new List<int> { 10, 20, 30 };
numeros2[1] = 25; // Modifica el segundo elemento
numeros2.Insert(2, 35); // Inserta en la tercera posición
numeros2.RemoveAt(0); // Elimina el primer elemento
foreach (var numero in numeros2)
{
    Console.WriteLine(numero);
}



//4.IQueryable
//Propósito:
//Extiende IEnumerable y se utiliza para realizar consultas a colecciones 
//que admiten operaciones de transformación y proyección, especialmente en bases 
//de datos y otros almacenes de datos.
//Espacio de nombres:
//System.Linq
//Métodos importantes:
//Provider:
//Obtiene el proveedor de consultas que traduce la consulta LINQ a una consulta 
//específica (como SQL para bases de datos).
//Expression:
//Obtiene la expresión de consulta, que se puede modificar o transformar.
//Características:
//- Utiliza evaluación diferida, pero en lugar de en memoria, ejecuta consultas en el origen 
//  de datos.
//- Permite escribir consultas complejas que pueden ser traducidas a SQL o a otras consultas 
//  en almacenes de datos externos.
//- Solo se evalúa cuando se accede a los datos (por ejemplo, con ToList o FirstOrDefault).
//Uso común:
//Ideal para aplicaciones con Entity Framework o consultas a bases de datos, 
//donde se necesita eficiencia y evitar cargar todos los datos en memoria.

//IQueryable<Usuario> usuarioss = dbContext.Usuarios.Where(u => u.Activo);
//IQueryable<Usuario> usuarioss = dbContext.Usuarios.Where(u => u.Activo);
//var usuariosActivos = usuarioss.ToList(); // Ejecuta la consulta en la base de datos

// Lista de usuarios simulada
List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario { Id = 1, Nombre = "Juan", Activo = true },
            new Usuario { Id = 2, Nombre = "Ana", Activo = false },
            new Usuario { Id = 3, Nombre = "Carlos", Activo = true },
            new Usuario { Id = 4, Nombre = "Lucia", Activo = false },
            new Usuario { Id = 5, Nombre = "María", Activo = true }
        };


// Convertir la lista en IQueryable
IQueryable<Usuario> usuariosQuery = usuarios.AsQueryable();

// Consulta LINQ usando IQueryable para obtener solo los usuarios activos
IQueryable<Usuario> usuariosActivos = usuariosQuery.Where(u => u.Activo);

// Ejecutar la consulta (evaluación diferida)
List<Usuario> resultado = usuariosActivos.ToList();

// Mostrar resultados
Console.WriteLine("Usuarios Activos:");

foreach (var usuario in resultado)
{
    Console.WriteLine($"Id: {usuario.Id}, Nombre: {usuario.Nombre}");
}

public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; } = default!;
    public bool Activo { get; set; }
}







