﻿using System;
public class Pattern
{
    public static void Main()
    {
        int row, column;


        for (row = 0; row <= 6; row++)
        {
            for (column = 0; column <= 6; column++)
            {
                if (((row == 0 || row == 3 || row == 6) && column > 1 && column < 5) || (column == 1 && (row == 1 || row == 2 || row == 6)) || (column == 5 && (row == 0 || row == 4 || row == 5)))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.Write("\n");
        }
        Console.Write("\n");
    }
}