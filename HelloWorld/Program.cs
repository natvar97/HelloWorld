using HelloWorld.Math;
using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // excercise - 1 : remainder
            /*
            var count = 0;
            for(var i = 0; i <= 100; i++)
            {
                if(i % 3 == 0 )
                {
                    count++;
                }
            }
            Console.WriteLine("Counts: " + count);
            */

            // excercise - 2 : 
            /*
            var sum = 0;
            while(true)
            {
                Console.Write("Enter a number or type \"ok\" to exit: ");
                var input = Console.ReadLine();
                if(input.ToLower() == "ok")
                {
                    Console.WriteLine("sum of entered number: " + sum);
                    break;
                }
                try
                {
                    sum += int.Parse(input);
                } 
                catch(Exception) 
                {
                    Console.WriteLine("You entered invalid number");
                    continue;
                }
            }
            */

            // excercise - 3:
            /*
            Console.Write("Enter number: ");
            var number = 0;
            try
            {
                number = int.Parse(Console.ReadLine());
                var result = 1;
                for (var i = number; i > 0; i--)
                {
                    result *= i;
                }
                Console.WriteLine(number + "! = " + result);
            } catch (Exception)
            {
                Console.WriteLine("You entered invalid number");
            }
            */

            // excercise - 4:
            /*
            var random = new Random();
            var randomNumber = random.Next(1, 10);
            Console.WriteLine("Random Number: " + randomNumber);

            for(var i = 0; i < 4; i++)
            {
                Console.Write("Enter a number between 1-10 : ");
                try
                {
                    var number = int.Parse(Console.ReadLine());
                    if(number == randomNumber)
                    {
                        Console.WriteLine("You won");
                        break;
                    }
                    else
                    {
                        if(i < 3)
                        {
                            Console.WriteLine("You loose, make another try: remain trials: " + (3 - i));
                        } else {
                            Console.WriteLine("You lost the game.");
                        }
                    }
                } catch (Exception)
                {
                    Console.WriteLine("You entered invalid number. remain trials: " + (3 - i));
                    continue;
                }
            }
           */

            // excercise - 5
           
            Console.Write("Enter multiple numbers divide by \',\' comma : ");

            var numberSeries = Console.ReadLine();
            var numbersStr = numberSeries.Split(',');


            var max = 0;
            foreach (var number in numbersStr)
            {
                var value = int.Parse(number);
                if ( value > max)
                {
                    max = value;
                }
            }

            Console.WriteLine("maximum number : " + max);
           
        }
    }
}
