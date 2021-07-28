using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma, cant, valor, promedio;
            suma = 0;
            cant = 0;
            do
            {
                Console.WriteLine("ingrese los numeros deseados o presione 0 para sumar");
                Console.WriteLine($"Valores ingresados hasta ahora:{cant}");
                valor = double.Parse(Console.ReadLine());

                if (valor != 0)
                {
                    suma = suma + valor;
                    cant++;
                }
               


            } while (valor!=0);
            if (cant!=0)
            {
                promedio = suma / cant;
                Console.WriteLine($"El promedio del valor ingresado es: {promedio}");
               
                
            }
            else
            {
                Console.WriteLine("No se ingresaron valores.");
            }
        }
    }
}
