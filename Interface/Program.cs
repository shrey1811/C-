﻿using System;

namespace Interface
{
    interface i1
    {
        void print();
    }

    interface i2
    {
        void print1();
    }

    interface i3 : i1,i2
    {
        void print2();
    }


    class Program : i3
    {
        public void print()
        {
            Console.WriteLine(" this is interface 1 !!");
        }

        public void print1()
        {
            Console.WriteLine(" this is interface 2 !!");
        }

        public void print2()
        {
            Console.WriteLine(" this is interface 3 !!");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.print();
            p.print1();
            p.print2();
            Console.ReadLine();
        }
    }
}
