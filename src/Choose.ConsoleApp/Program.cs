using System;
using System.Collections.Generic;

namespace Choose.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] trues = { "1", "true", "True", "TRUE", "yes", "Yes", "YES", "Ja", "ja", "JA", "ok", "OK" };
            string[] falses = { "0", "false", "False", "FALSE", "no", "No", "NO", "Nein", "nein", "NEIN", "nok", "NOK" };

            string[] messages = { "Solar system status", "Answer", "Result", "Status", "Code" };

            Console.Write($"{messages[RandomNumber.Between(0, messages.Length-1)]}: ");

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
                    Console.Write($"{trues[RandomNumber.Between(0, trues.Length-1)]}");
                }
                else
                {
                    Console.Write($"{falses[RandomNumber.Between(0, trues.Length-1)]}");
                }
            }
            else
            {
                var random = RandomNumber.Between(0, options.Count - 1);

                Console.Write("");
                Console.Write(options[random]);
            }

            Console.ReadLine();
        }
    }
}
