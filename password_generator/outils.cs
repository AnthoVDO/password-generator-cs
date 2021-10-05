using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    static class outils
    {
        public static int AskPositiveNumber(string question)
        {
            int number = AskNumber(question);
            if (number > 0)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Error: The number should be above zero");
                return AskNumber(question);
            }
        }
        public static int AskNumberBetweenMinAndMax(string question, int min, int max)
        {
            int number = min - 1;
            while ((number < min) || (number > max))
            {
                number = AskNumber(question);
                if ((number < min) || (number > max))
                {
                    Console.WriteLine($"The value should be between {min} and {max}");
                }

            }
            return number;
        }
        public static int AskNumber(string question)
        {
            // ask question

            // take the answer

            // convert
            // handle error
            // loop until valid answer

            while (true)
            {
                Console.Write(question + ": ");
                string answer = Console.ReadLine();
                int number = 0;
                try
                {
                    number = int.Parse(answer);
                    return number;
                }
                catch
                {
                    Console.WriteLine("Error: you need to enter a valid number");
                }
            }

        }
    }
}
