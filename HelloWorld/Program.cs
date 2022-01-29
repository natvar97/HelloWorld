using HelloWorld.Math;
using System;

namespace HelloWorld
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            // if-else
            if(hour > 0 && hour < 12)
                Console.WriteLine("it is morning");
            else if (hour >12 && hour < 18 )
                Console.WriteLine("it is afternoon");
            else
                Console.WriteLine("it is evening");


            bool isGoldCustomer = true;
            float price = (isGoldCustomer) ? 99.99f : 49.99f;
            Console.WriteLine(price);

            // switch statements

            var season = Season.Autumn;

            switch(season)
            {
                case Season.Autumn:
                    Console.WriteLine("It is very dry");
                    break;
                case Season.Summer:
                    Console.WriteLine("It is very hot");
                    break;
                case Season.Spring:
                    Console.WriteLine("It is very greenery environment");
                    break;
                case Season.Winter:
                    Console.WriteLine("It is very cool environment");
                    break;
            }


        }
    }
}
