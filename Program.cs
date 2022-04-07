using System;

namespace LoopSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random = 0;
            int sum = 0;
         
            
            for (int i = 0; i < 10; i++)
            {
                random = rnd.Next(1, 11);
                sum = random + sum;
                Console.WriteLine($"Random number {i+1} is {random}");
            }

            Console.WriteLine($"Total is {sum}");


        }
    }
}
