

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