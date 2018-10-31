using System;

namespace Ejercicios_de_Arrays
{
    class Program
    {
        //Hacer un programa que inicialice un array con los 10 primeros naturales pares y luego los imprima.
        public static int[] LlenarArray()
        {
            int[] array;
            array = new int[10];
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
