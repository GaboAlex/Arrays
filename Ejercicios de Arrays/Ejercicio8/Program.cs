using System;

namespace Ejercicio8
{
    class Program
    {
        //Llenar un Array con el promedio de 3 notas para 10 alumnos, imprimir cuantos alumnos desaprobados el curso hay y cuantos aprobados y cuál es la nota media
        public static int[] LlenarArray()
        {
            Console.WriteLine("***PROGRAMA PARA PROMEDIO DE NOTAS***\n");
            int[] array;
            int suma = 0;
            int promedio = 0;
            array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                suma = 0;
                promedio = 0;
                for (int j = 0; j < 3 ; j++)
                {
                    Console.WriteLine("Ingres la nota del Alumno "+ i);
                    int x = int.Parse(Console.ReadLine());
                    suma = suma + x;
                }
                promedio = suma / 3;
                array[i] = promedio;
            }
            return (array);
        }
        public static void Aprueba(int []arrays) {
            for (int i = 0; i < arrays.Length; i++)
            {
                if (arrays[i] > 10)
                {
                    Console.WriteLine("El Alumno " + i + " esta APROBADO");
                }
                else {
                    Console.WriteLine("El Alumno " + i + " NO APROBO");
                }
                    
            }
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
            Aprueba(arra);
            ImprimirArray(arra);
        }
    }
}
