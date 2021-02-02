using System;
using System.Collections.Generic;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {

            coleccion_ejemplo4();
        }

        public static void coleccion_ejemplo1()
        {
            //Declarar una colección de tipo lista
            List<int> numeros = new List<int>();

            //Agregar elementos
            numeros.Add(5);
            numeros.Add(12);
            numeros.Add(24);

            //mostrar
            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine(numeros[i]);
            }
        }

        public static void coleccion_ejemplo2()
        {
            //Declarar una colección de tipo lista
            List<int> numeros = new List<int>();

            //Declarar array
            int[] conjuntoNumeros = new int[] { 3, 12, 44, 90, 110 };

            //Agregar elementos
            for (int i = 0; i < conjuntoNumeros.Length; i++)
            {
                numeros.Add(conjuntoNumeros[i]);
            }

            //mostrar
            for (int i = 0; i < conjuntoNumeros.Length; i++)
            {
                System.Console.WriteLine(numeros[i]);
            }

        }

        public static void coleccion_ejemplo3()
        {
            List<int> numeros = new List<int>();
            Console.WriteLine("Cuantos elementos quieres introducir?");
            int nElementos = int.Parse(Console.ReadLine());

            for (int i = 0; i < nElementos; i++)
            {
                numeros.Add(int.Parse(Console.ReadLine()));
            }

            
            Console.WriteLine("Elementos introducidos");
            
            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }

        }

        public static void coleccion_ejemplo4()
        {
            List<int> numeros = new List<int>();
            Console.WriteLine("Introduce elementos en la colección (0 para salir)\n");

            int elementos = 1;

            while (elementos!=0)
            {
                elementos = int.Parse(Console.ReadLine());
                numeros.Add(elementos);
            }

            numeros.RemoveAt(numeros.Count-1);

            Console.WriteLine("\nElementos introducidos\n");

            foreach (int items in numeros)
            {
                Console.WriteLine(items);
            }
        }
        
    }
}
