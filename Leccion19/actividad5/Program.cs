using System;

namespace actividad5
{
    class Program
    {
        static void Main(string[] args)
        {
            double dividendo;
            double divisor;
            Console.WriteLine("Introduce el dividendo");
            try
            {
                dividendo = double.Parse(Console.ReadLine());
            }
            catch (Exception e) when (e.GetType() != typeof(FormatException))
            {
                Console.WriteLine(@"Ha ocurrido un error, se toma como valor predeterminado 1");
                dividendo = 1;
            }
            catch (FormatException)
            {
                Console.WriteLine("Has escrito un texto, se toma por defecto el valor de 1");
                dividendo = 1;
            }
            Console.WriteLine("Introduce el divisor");
            try
            {
                divisor = double.Parse(Console.ReadLine());
            }
            catch (Exception e) when (e.GetType() != typeof(FormatException))
            {
                Console.WriteLine("Ha ocurrido un error, se toma como valor predeterminado 1");
                divisor = 1;
            }
            catch (FormatException)
            {
                Console.WriteLine("Has escrito un texto, se toma como valor predeterminado 1");
                divisor = 1;
            }
            Console.WriteLine($"El resultado es: {division(dividendo, divisor)}");
        }
        static double division(double num1, double num2) => num1 / num2;
    }
}
