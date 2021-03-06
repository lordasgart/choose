using System;
using System.Collections.Generic;

namespace Choose.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib deine Optionen mit ENTER ein:");

            List<string> options = new List<string>();
            string option = string.Empty;
            while (true)
            {
                option = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(option))
                {
                    break;
                }
                options.Add(option);
            }

            if (options.Count < 2)
            {
                var random = RandomNumber.Between(0, 1);

                if (random == 1)
                {
                    Console.WriteLine("Ja.");
                }
                else
                {
                    Console.WriteLine("Nein.");
                }
            }
            else
            {
                var random = RandomNumber.Between(0, options.Count - 1);

                Console.WriteLine("Deine Wahl fällt auf:");
                Console.WriteLine(options[random]);
            }

            Console.ReadLine();
        }
    }
}
