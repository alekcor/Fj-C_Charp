using System;

namespace actividad3
{
    class Program
    {
        static void Main(string[] args)
        {
            string auth = "Password123";
            Console.WriteLine("Escribe tu contraseña");
            string password = Console.ReadLine();
            int confirm = String.Compare(auth, password);
            if (confirm == 0) Console.WriteLine("Cargando base de datos\nBienvenido Usuario");
            else Console.WriteLine("El ingreso esta prohibido");
        }
    }
}
