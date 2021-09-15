using System;

namespace actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Introduce un número");
            num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("El numero es menor a cero");
            }
            else
            {
                Console.WriteLine("El número es igual o mayor a cero");
            }
        }
    }
}
