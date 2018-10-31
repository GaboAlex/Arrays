using System;

namespace Ejercicio6
{
    class Program
    {
        //Llenar un Array de 8 elementos, luego Buscar un elemento en particular ingresado por teclado
        public static int[] LlenarArray()
        {
            int[] array;
            array = new int[8];
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
        public static void Buscar(int[] arrays) {
            Console.WriteLine("Escriba el numero que busca: ");
            int n = int.Parse(Console.ReadLine());
            bool flag = false;
            for (int i = 0; i < arrays.Length; i++)
            {
                if (n == arrays[i])
                {
                    flag = true;
                    break;
                }
                else {
                    flag = false;          
                }
            }
            if (flag == true)
            {
                Console.WriteLine("El numero si se Encuentra en el Array");
            }
            else {
                Console.WriteLine("El numero no Esta en el Array");
            }
        }
        static void Main(string[] args)
        {
            int[] arra;
            arra = LlenarArray();
            Buscar(arra);
            ImprimirArray(arra);
        }
    }
}
