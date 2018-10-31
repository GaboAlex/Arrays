using System;

namespace Ejercicio3
{
    class Program
    {
        //Realizar un programa que te permita sumar todos los elementos de un array, 
        //Dicho elemento deben ser generados aleatoriamente y estarán entre el rango de 0 a 20
        public static int[] LlenarArray()
        {
            Random rdn = new Random();
            int[] array;
            array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                int a = rdn.Next(0, 20);
                array[i] = a;
            }
            return (array);
        }
        public static int SumarTodo(int[] array)
        {
            int suma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                suma = suma + array[i];
            }
            return (suma);
        }
        public static void ImprimirArray(int[] array, int sum)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("El " + i + " numero natural es: " + array[i]);
            }
            Console.WriteLine("La suma es: " + sum);
        }
        static void Main(string[] args)
        {
            int[] arra;
            int su = 0;
            arra = LlenarArray();
            su = SumarTodo(arra);
            ImprimirArray(arra, su);
        }
    }
}
