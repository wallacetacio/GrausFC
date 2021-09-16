using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            string fahrenheit;

            Console.WriteLine(" ");
            Console.Write("Olá Habitantes do planeta ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Terra!");
            Console.ResetColor();
            Console.WriteLine(" ");
            Console.WriteLine(@"No decorrer desse programa, irei converter
valores de Fahrenheit para Celsius.");
            Console.WriteLine(" ");

            Console.Write("Digite um valor..: ");
            fahrenheit = Console.ReadLine();
            double F = Convert.ToDouble(fahrenheit);
            Console.WriteLine(" ");
            Console.WriteLine($"°F = {F}");

            double Dc = (F - 32) / 1.8;

            Console.WriteLine(" ");
            Console.WriteLine($"{fahrenheit}°F equivalem a {Dc}°C");
        }
    }
}
