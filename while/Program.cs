using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            while (number < 5)
            {
                Console.WriteLine(number);
                number = number + 1;
            }

            Console.ReadLine();
        }
    }
}