using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            while (true)
            {
                Console.Write("Please enter a number: ");
                if (!int.TryParse(Console.ReadLine(), out int num))
                {
                    Console.WriteLine("Wrong input, please enter a number");
                    continue;
                }
                numbers.Enqueue(num);
                Console.WriteLine("Would you like to enter a different number? (Yes/No) ");
                string input = Console.ReadLine();
                if (input.ToLower() != "yes")
                {
                    break;
                }
                continue;
            }
            while (numbers.TryDequeue(out int num))
            {
                Console.WriteLine(num);
            }

        }
    }
}
