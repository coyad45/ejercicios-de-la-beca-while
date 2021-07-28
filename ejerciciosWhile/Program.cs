using System;

namespace ejerciciosWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            do
            {
                contador += 1;
                Console.WriteLine(contador);
            } while (contador < 10);
            
        }
    }
}
