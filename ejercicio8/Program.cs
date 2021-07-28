using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma, cantP,cantN, valor, promedioS, promedioM, multip;
            suma = 0;
            cantP= 0;
            cantN = 0;
            multip = 1;
            do
            {
                Console.WriteLine("ingrese los numeros deseados o presione 0 para sumar");
                Console.WriteLine($"Valores ingresados hasta ahora: P: {cantP} N: {cantN}");
                valor = double.Parse(Console.ReadLine());

                if (valor<0)
                {
                    multip = multip * valor ;
                    cantN++;
                }
                else if (valor > 0)
                {
                    suma = suma + valor;
                    cantP++;

                }             

            } while (valor != 0);
            if (cantP != 0 || cantN != 0)
            {

                promedioS = suma;
                promedioM = multip;
                Console.WriteLine($"El promedio del valor ingresado es: {promedioS}");
                Console.WriteLine($"El promedio del valor multi es: {promedioM}");
            }
            else
            {
                Console.WriteLine("No se ingresaron valores.");
            }
        }
    }
}
