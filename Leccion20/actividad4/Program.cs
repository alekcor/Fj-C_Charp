using System;

namespace actividad4
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia = 0;
            Console.WriteLine("Escribe un numero de la semana:");
            try
            {
                dia = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error de formato, solo puedes escribir números\nSe toma como valor 1");
                dia = 1;
            }
            try
            {
                switch (dia)
                {
                    case 1:
                        Console.WriteLine("Dia: Lunes");
                        break;
                    case 2:
                        Console.WriteLine("Dia: Martes");
                        break;
                    case 3:
                        Console.WriteLine("Dia: Miercoles");
                        break;
                    case 4:
                        Console.WriteLine("Dia: Jueves");
                        break;
                    case 5:
                        Console.WriteLine("Dia: Viernes");
                        break;
                    case 6:
                        Console.WriteLine("Dia: Sabado");
                        break;
                    case 7:
                        Console.WriteLine("Dia: Domingo");
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Dia elegido fuera de rango, intenta de nuevo");
            }
        }
    }
}
