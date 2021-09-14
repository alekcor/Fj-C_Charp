using System;

namespace Leccion20
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Introduzca un número");
            num = int.Parse(Console.ReadLine());
            if(num <0)
            {
                Console.WriteLine("El número es menor a cero");
            }
            else{
                Console.WriteLine("El numero es igual o mayor a cero");
            }
        }
    }
}
