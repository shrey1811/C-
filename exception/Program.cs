using System;

namespace exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());

            try
            {
                int result = num1 / num2;
                Console.WriteLine("division is : " + result);
                //string a = null;                                   // Null refrence exception
                //Console.WriteLine(a.Length);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(" You can't divide a number by zero...");
                Console.WriteLine(ex.Message);
            }
            //catch(NullReferenceException ex)                        // Null refrence exception
            //{
            //    Console.WriteLine(ex.Message);
            //}
            finally
            {
                Console.WriteLine("Finally Block Executed..");
            }
            

            //Console.WriteLine("Remaining Statement 1");
            //Console.WriteLine("Remaining Statement 2");
            //Console.WriteLine("Remaining Statement 3");

            Console.ReadLine();
        }
    }
}
