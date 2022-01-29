using HelloWorld.Math;
using System;

namespace HelloWorld
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // excercise - 1 
            /*
            Console.WriteLine("Enter number:");
            var number = int.Parse(Console.ReadLine());
            if (number > 0 && number <= 10 )
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
            */


            // excercise - 2
            // find max number
            /*
            Console.WriteLine("Enter Number1: ");
            var number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number2: ");
            var number2 = int.Parse(Console.ReadLine());

            var maxNumber = (number1 < number2) ? number2 : number1;

            Console.WriteLine("Max Number: {0}", maxNumber);
            */


            // excercise - 3
            // print image type as users width and height
            /*
            Console.Write("Enter Your Image width: ");
            var width = int.Parse(Console.ReadLine());

            Console.Write("Enter Your Image Height: ");
            var height = int.Parse(Console.ReadLine());

            var imageType = (width > height) ? "Landscape" : "Portrait";

            Console.WriteLine("Image Type: {0}", imageType);
            */

            // excercise - 4
            // program for license suspension

            Console.Write("Enter your speed limit: ");
            var speedLimit = int.Parse(Console.ReadLine());

            Console.Write("Enter your car speed: ");
            var carSpeed = int.Parse(Console.ReadLine());

            if(carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            } else
            {
                var extraSpeed = carSpeed - speedLimit;
                var demerit = (int) extraSpeed / 5;

                if(demerit <= 12)
                    Console.WriteLine("Demerit: {0}", demerit);
                else {
                    Console.WriteLine("Demerit: {0}", demerit);
                    Console.WriteLine("License suspended");
                }
            }
        }
    }
}
