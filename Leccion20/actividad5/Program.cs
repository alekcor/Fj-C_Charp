using System;

namespace actividad5
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal nota;
            Console.WriteLine("Introduce tu nota: ");
            try
            {
                nota = decimal.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error de formato, se toma como valor por defecto 60");
                nota = 60;
            }
            if (nota > 100) Console.WriteLine("La nota no puede ser mayor a 100");
            else if (nota >= 60) Console.WriteLine("Aprobaste satisfactoriamente");
            else if (nota < 0) Console.WriteLine("Error, la nota no puede ser negativa");
            else Console.WriteLine("Reprobaste");
        }
    }
}
