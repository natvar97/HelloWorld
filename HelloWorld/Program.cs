using HelloWorld.Math;
using System.Collections.Generic;
using System;
using System.Data.SqlTypes;
using System.Globalization;
using System.Management.Instrumentation;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // try catch method
            /*try
            {
                var number = int.Parse("abc");
            }
            catch (Exception e)
            {
                throw new InvalidCastException("Invalid number provided for parsing");
            }*/

            int newNumber;
            var result = int.TryParse("10", out newNumber);
            if (result)
            {
                Console.WriteLine(newNumber);
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }

        }

        public static void Params()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));

        }

        public static void Points()
        {
            try
            {
                var point = new Point(1, 2);
                Console.WriteLine("Point value ({0}, {1})", point.X, point.Y);

                point.Move(10, 20);
                Console.WriteLine("Point value ({0}, {1})", point.X, point.Y);

                point.Move(null);
                Console.WriteLine("Point value ({0}, {1})", point.X, point.Y);
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Invalid point provided");
            }
        }

    }
}
