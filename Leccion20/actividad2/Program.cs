using System;

namespace actividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu edad");

            int edad = int.Parse(Console.ReadLine());
            if (edad <= 0) Console.WriteLine("Nadie tiene edad negativa, vuelve a ingresar tu edad");
            else if (edad >= 18) Console.WriteLine("Eres mayor de edad");
            else Console.WriteLine("Eres menor de edad");
        }
    }
}
