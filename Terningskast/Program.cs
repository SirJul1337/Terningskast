using System;

namespace Terningskast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Random random = new Random();
            int terningskast = random.Next(1, 7);
            switch (terningskast)
            {
                case 0:
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du slog en etter");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Du slog en to'er");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Du slog en treer");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Du slog en fireer");
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Du slog en femmer");
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Du slog en sekser");
                    break;
            }
        }
    }
}
