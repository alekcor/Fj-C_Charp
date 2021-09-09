using System;

namespace actividad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 20;
            Console.WriteLine("Introduce dato 2");
            int numero2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"El resultado es: {resta(numero1, numero2)}");
        }
        static int resta(int num1, int num2) => num1 - num2;
    }
}
