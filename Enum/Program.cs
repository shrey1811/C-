using System;

public class Test
{
    enum Colors { Red, Green, Blue, Yellow };

    public static void Main()
    {

        Console.WriteLine("The values of the Colors Enum are:");
        foreach (int i in Enum.GetValues(typeof(Colors)))
            Console.WriteLine(i);

        Console.WriteLine();

        Console.WriteLine("The names of the Colors enum are:");
        foreach (string s in Enum.GetNames(typeof(Colors)))
            Console.WriteLine(s);
    }
}