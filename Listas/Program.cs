using System.Collections.Generic; //Se agrega la libreria de Listas
/*Una Lista es un Objeto que puede contener cualquier tipo de datos, incluso otros objetos.
Tambien se le conoce como una estructura de datos dinámica, ya que puede crecer o decrecer en tiempo de ejecución.
La lista tiene una coleccion de metodos que permiten agregar, eliminar, buscar, ordenar y manipular los elementos de la lista.
*/
namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>(); //Se crea una lista de enteros
            //List es una clase que representa una lista de objetos de un tipo especifico
            //numeros es un objeto de la clase List que contiene enteros y almacena los elementos de la lista
            numeros.Add(1); //Se agrega un elemento a la lista
            numeros.Add(2); //Se agrega un elemento a la lista
            Console.WriteLine(numeros.Count); //Se imprime la cantidad de elementos de la lista
            //Count es una propiedad que devuelve la cantidad de elementos de la lista

            List<int> numeros2 = new List<int>() //Se crea una lista de enteros con elementos iniciales
            {
                1,2,3,4,5 
            };
            Console.WriteLine(numeros2.Count); //Se imprime la cantidad de elementos de la lista
            numeros2.Add(25); //Se agrega un elemento a la lista numeros2
            Console.WriteLine($"Se agrego un elemento mas a la lista numeros2: {numeros2.Count}");
             //Se imprime la cantidad de elementos de la lista (6) elementos

            numeros2.Clear(); //Se eliminan todos los elementos de la lista
            Console.WriteLine($"Se eliminaron todos los elementos de la lista numeros2: {numeros2.Count}");

            List<string> nombres = new List<string>() //Se crea una lista de cadenas
            {
                "Juan", "Pedro", "Maria", "Ana"
            };
            Console.WriteLine($"Cantidad de elementos en la lista de nombres: {nombres.Count}"); //Se imprime la cantidad de elementos de la lista


        } //Fin del método Main

    } //Fin de la clase Program


}// Fin del namespace Listas