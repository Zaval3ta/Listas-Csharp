using System.Collections.Generic;

namespace MetodosComunes
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeros =new List< int > ()
            {
                1,22,33,42,11,2,3,90
            };

            Show(numeros); //mostrar los números de la lista

            //METODOS PORPULARES DE LA LISTA:

            //Insert()
                      //(posición, elemento a insertar)
            numeros.Insert(0, 25); //Insertar un número en la posición 0
            //Inserta en la posición indicada y recorre todos los elementos hacia la derecha
            Show(numeros);
            //Contains()
            //Comprobar si un elemento existe en la lista
            if (numeros.Contains(42)) //Comprobar si el número 42 existe en la lista
                                      //Contains es una función que devuelve un booleano
            {
                Console.WriteLine("Existe"); //True
            }
            else
            {
                Console.WriteLine("No existe"); //False
            }

            //IndexOf()
            //Devuelve la posición de un elemento en la lista
            int posicion = numeros.IndexOf(42); //Devuelve la posición del número 42
            Console.WriteLine($"Posición: {posicion}"); //Imprime la posición del número 42. Posición: 4
            //Esta en la posicion 4 porque insertamos un 25 en la posición 0
            posicion = numeros.IndexOf(100); //Devuelve -1 si el elemento no existe
            Console.WriteLine($"Posición: {posicion}");

            //Sort()
            //Ordenar los elementos de la lista de menor a mayor
            numeros.Sort(); //Ordenar los elementos de la lista
            //La lista es mutable, es decir, se modifica la lista original
            Show(numeros); //Mostrar los números de la lista ordenados de menor a mayor

            //AddRange()
            //Agregar una colección de elementos a la lista. Una lista a otra lista.
            var numeros2 = new List<int>() { 1000, 20, 3, }; //Nueva lista
            numeros.AddRange(numeros2); //Agregar los elementos de la lista numeros2 a la lista numeros
            Show(numeros); //Mostrar los números de la lista

            //AddRange()
            numeros.AddRange(new List<int>()
            {
                400,2,3,22,
            }); //Agregar una lista de elementos a la lista
            //2 Formas de agregar una lista a otra lista

            Show(numeros); //Mostrar los números de la lista

        } //Fin del método Main

        //Método para mostrar los números de la lista
        public static void Show(List<int> numeros)
        {
            Console.WriteLine("-----Numeros-----");
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }
        } //Fin del método Show

    } //Fin de la clase Program


} //Fin del namespace MetodosComunes