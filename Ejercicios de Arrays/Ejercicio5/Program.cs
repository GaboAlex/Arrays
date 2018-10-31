using System;

namespace Ejercicio5
{
    class Program
    {
        //Encontrar el máximo y el mínimo elemento de array
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
        public static void ImprimirArray(int[] array, int ma, int min)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("El " + i + " numero natural es: " + array[i]);
            }
            Console.WriteLine("El numero maximo en el arreglo es: " + ma);
            Console.WriteLine("El numero minimo en el arreglo es: " + min);

        }
        public static int Maximo(int[] arrays) {
            int mayor = arrays[0];
            for (int i = 0; i < arrays.Length; i++)
            {
                if (arrays[i] > mayor) {
                    mayor = arrays[i];
                }
            }
            return (mayor);
        }
        public static int Minimo(int[] arrays)
        {
            int menor = arrays[0];
            for (int i = 0; i < arrays.Length; i++)
            {
                if (arrays[i] < menor)
                {
                    menor = arrays[i];
                }
            }
            return (menor);
        }
        static void Main(string[] args)
        {
            int[] arra;
            arra = LlenarArray();
            int maxi = Maximo(arra);
            int min = Minimo(arra);
            ImprimirArray(arra,maxi,min);
        }
    }
}
