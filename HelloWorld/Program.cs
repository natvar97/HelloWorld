﻿using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            byte number = 255;
            // checked throws an exception if overthrowing happens
            checked
            {
                number = (byte)(number + 1);
            }
           
            Console.WriteLine(number);


        }
    }
}
