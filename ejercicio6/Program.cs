using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5;
            int suma;
            int promedio;
            string finalizar;


            do
            {
                //sumatoria
                Console.WriteLine("Ingrese cinco numeros");
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());
                n3 = int.Parse(Console.ReadLine());
                n4 = int.Parse(Console.ReadLine());
                n5 = int.Parse(Console.ReadLine());
                suma = n1 + n2 + n3 + n4 + n5;
                promedio = suma / 5;

                //detener
                Console.WriteLine($"la suma total de las notas es: {suma}");
                Console.WriteLine($"El promedio total es: {promedio}");
                Console.WriteLine("desea finalizar \"S\"o\"N\"");

                finalizar = Console.ReadLine();
                finalizar = finalizar.Trim();
                finalizar = finalizar.ToLower();
                

            } while (finalizar == "s");
        }
    }
}
