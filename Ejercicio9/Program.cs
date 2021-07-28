using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int cuenta;
            Console.WriteLine("Cuantas veces quieres imprimir Hola mundo");
            cuenta = int.Parse(Console.ReadLine());

            for (int i = 0; i < cuenta; i++)
            {
                Console.WriteLine("Hola mundo");
            }
        }
    }
}
