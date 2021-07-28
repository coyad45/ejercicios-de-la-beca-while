using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexo;
            

            do
            {
                Console.WriteLine("Ingrese su sexo \"f\" femenino y \"m\" masculino");
                sexo = Console.ReadLine();

            } while (sexo != "f" && sexo != "m");
        }
    }
}
