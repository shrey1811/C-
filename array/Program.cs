using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int i = 0;
        int j = 0;

        int[] array1 = new int[5] { 10,30,50,5,100};
        int[] array2 = new int[5] {15,25,7,59,92};
        int[] finalArray = new int[10];

        for (i = 0, j = 0; i < 5; i++)
        {
            finalArray[j++] = array1[i];
        }
        for (i = 0; i < 5; i++)
        {
            finalArray[j++] = array2[i];
        }

        Array.Sort(finalArray);

        foreach (int value in finalArray)
        {
            Console.Write(value + " ");
        }

        Console.WriteLine();
    }
}