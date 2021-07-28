using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            
            do
            {
                Console.WriteLine("Ingrese un numero entre 0 y 9");
                num = int.Parse(Console.ReadLine());
            } while (num >= 0 && num <= 9);
        }
    }
}
