using HelloWorld.Math;
using System;

namespace HelloWorld
{

    internal class Program
    {
        static void Main(string[] args)
        {
//            int[] numbers = new int[3] {10,20,30};
            var numbers = new int[3] {10,20,30};
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            // create different arrays for checking which values
            // they allocate when not initialized

            var flags = new bool[3];

            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var strings = new string[3];

            Console.WriteLine(strings[0]);
            Console.WriteLine(strings[1]);
            Console.WriteLine(strings[2]);

            var names = new string[3] { "Natu" , "Uru" ,"Parents" };

        }
    }
}
