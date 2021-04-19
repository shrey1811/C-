using System;

namespace MultipleCatchException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //int a = 10;                               //DivideByZeroException
                //int b = 0;
                //int c = a / b;

                //string a = null;                         // NullReferenceException
                //Console.WriteLine(a.Length);

                int[] arr = new int[3];                       // IndexOutOfRangeException
                arr[0] = 11;
                arr[1] = 12;
                arr[2] = 13;
                arr[3] = 14;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)                               // Parent class 
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
