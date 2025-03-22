using System.Collections.Generic;
using System.Net; //Se agrega la libreria de Listas

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            //  List<int> numeros = new List<int>() {};
            var numeros = new List<int>() //Se crea una lista de números
            //var simplifica la declaración de variables y permite que el compilador determine el tipo de variable.
            //var solo se puede usar en metodos locales y variables locales, no en campos de clase.
            {
                1,2,3,4,5,6,7,8,9,10
            }; //Fin de la lista de números

            //foreach
            foreach (var numero in numeros) //Se recorre la lista de números
                //var numero = int numero
            {
                Console.WriteLine(numero);
            }

            //Listas de objetos de la clase Personas
            // List<Personas> personas = new List<Personas>() {};
            //var sustituye la declaración de la lista de personas porque el compilador puede determinar el tipo de variable.
            var personas = new List<Personas>() //Se crea una lista de personas
            {
                new Personas() { Nombre = "Juan", Pais = "Mexico" },
                new Personas() { Nombre = "Pedro", Pais = "Colombia" },
                new Personas() { Nombre = "Maria", Pais = "Argentina" }
            }; //Fin de la lista de personas

            ShowPersonas(personas); //Se llama al método ShowPersonas
            //Eliminamos a Pedro de la lista de personas
            personas.Remove(personas[1]);
            ShowPersonas(personas); //Se llama al método ShowPersonas e imprime la lista de personas sin Pedro
        } //Fin del método Main

        //Metodo para imprimir la lista de personas
        static void ShowPersonas(List<Personas> personas)
        {
            Console.WriteLine("----------Lista de personas----------");
            foreach (var persona in personas) //Se recorre la lista de personas
            {
                Console.WriteLine($"Nombre: {persona.Nombre}, Pais: {persona.Pais}");
            }
        } //Fin del método ShowPersonas

    } //Fin de la clase Program

    public class Personas
    {
        public string Nombre { get; set; }
        public string Pais { get; set; }
    }

}// Fin del namespace ForEach