using System;

namespace Ejercicio2
{
    class Program
    {
        //Hacer un programa que inicialice un array con los N primeros naturales pares y luego los imprima.
        public static int[] LlenarArray()
        {
            int[] array;
            Console.WriteLine("Ingrese la cantidad de numeros que desee: ");
            int n = int.Parse(Console.ReadLine());
            array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (i + 1) * 2;
            }
            return (array);
        }
        public static void ImprimirArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("El " + i + " numero natural es: " + array[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] arra;
            arra = LlenarArray();
            ImprimirArray(arra);
        }
    }
}
