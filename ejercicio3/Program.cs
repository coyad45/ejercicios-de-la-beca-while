using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string clave;
            do
            {
                Console.WriteLine("Ingrese su clave");
                clave = Console.ReadLine();
                clave = clave.Trim();
                if (clave == ".Net")
                {
                    Console.WriteLine("Clave correcta");
                }
                
            } while (clave != ".Net");
        }
    }
}
