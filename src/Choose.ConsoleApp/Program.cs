using System;
using System.Collections.Generic;

namespace Choose.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("private bool Options => ");

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
                    Console.Write("true");
                }
                else
                {
                    Console.Write("false");
                }
            }
            else
            {
                var random = RandomNumber.Between(0, options.Count - 1);

                Console.Write(" => ");
                Console.Write(options[random]);
            }

            Console.ReadLine();
        }
    }
}
