using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 11;
            do
            {
                contador -= 1;
                Console.WriteLine(contador);
            } while (contador > 0);
        }
    }
}
