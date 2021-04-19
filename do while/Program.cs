using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            do
            {
                Console.WriteLine(number);
                number = number + 1;
            } while (number < 5);

            Console.ReadLine();
        }
    }
}