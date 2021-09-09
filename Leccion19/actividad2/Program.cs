using System;

namespace actividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 15.5;
            double numero2 = 5;
            Console.WriteLine($"El resultado es: {suma(numero, numero2)}");
        }
        static double suma(double num1, double num2) => num1 + num2;
    }
}
