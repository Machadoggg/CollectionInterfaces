

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
