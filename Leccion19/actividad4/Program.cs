using System;

namespace actividad4
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            Console.WriteLine("Introduce dato 1");
            try
            {
                num1 = double.Parse(Console.ReadLine());
            }
            catch (Exception e) when (e.GetType() != typeof(FormatException))
            {
                Console.WriteLine("Ha ocurrido un error, valor 1 por defecto");
                num1 = 1;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Escribiste un texto, se toma por defecto el valor de 1");
                num1 = 1;
            }
            Console.WriteLine("Introduce dato 2");
            try
            {
                num2 = double.Parse(Console.ReadLine());
            }
            catch (Exception e) when (e.GetType() != typeof(FormatException))
            {
                Console.WriteLine("Ha ocurrido un error, valor 1 por defecto");
                num2 = 1;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Has escrito un texto, se toma por defecto el valor de 1");
                num2 = 1;
            }
            Console.WriteLine($"El resultado es: {multiply(num1, num2)}");
        }
        static double multiply(double num1, double num2) => num1 * num2;
    }
}
