using HelloWorld.Math;
using System.Collections.Generic;
using System;
using System.Data.SqlTypes;
using System.Globalization;
using System.Text;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // exercise - 1 => consecutive exercise

            /*Console.Write("Enter numbers separated by hyphen :");
            var numbers = Console.ReadLine();
            var numbersArray = numbers.Split(',');
            var isConsecutive = false;

            for (var i = 0; i < numbersArray.Length; i++)
            {
                if (i < numbersArray.Length - 1)
                {
                    if (Int32.Parse(numbersArray[i]) == (Int32.Parse(numbersArray[i + 1]) - 1))
                    {
                        isConsecutive = true;
                    }
                    else
                    {
                        isConsecutive = false;
                        break;
                    }
                }
            }

            if (isConsecutive)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }*/


            // exercise - 2 => find duplicates

            /*
            Console.Write("Enter numbers separated by hyphen: ");
            var numbers = Console.ReadLine();
            var isDuplicate = false;
            var value = 0;
            if (numbers.Trim().Equals(""))
            {
                Environment.Exit(0);
            }
            else
            {
                var numbersArray = numbers.Split(',');
                for (int i = 0; i < numbersArray.Length; i++)
                {
                    value = Int32.Parse(numbersArray[i]);

                    for (int j = i+1; j < numbersArray.Length; j++)
                    {
                        if (value == Int32.Parse(numbersArray[j]))
                        {
                            isDuplicate = true;
                            break;
                        }
                       
                    }
                    
                }
            }

            if (isDuplicate)
            {
                Console.WriteLine("Duplicates");
            }
            else
            {
                Console.WriteLine("No Duplicates");
            }
            */

            // exercise - 3 

            /*
            Console.Write("Enter a time in 24 hour format  (eg- 19:00) : ");
            var time = Console.ReadLine();
            var timesArray = time.Split(':');
            var hour = Int32.Parse(timesArray[0]);
            var minute = Int32.Parse(timesArray[1]);

            if (hour < 0 || hour >= 24)
            {
                Console.WriteLine("Invalid time");
            } else if (minute < 0 || minute >= 60)
            {
                Console.WriteLine("Invalid time");
            }
            else
            {
                Console.WriteLine("Valid time");
            }
            */

            // exercise - 4

            /*
            Console.Write("Enter random sentence: ");
            var sentence = Console.ReadLine();

            var sentenceArray = sentence.Split(' ');

            var finalString = "";

            foreach (var value in sentenceArray)
            {
                finalString += string.Concat(value[0].ToString().ToUpper(), value.Substring(1));
            }

            Console.WriteLine(finalString);
            */

            // exercise - 5

            /*
            Console.Write("Enter any English word: ");
            var word = Console.ReadLine();

            var count = 0;

            foreach (var ch in word)
            {
                switch (ch)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        count++;
                        break;
                    default:
                        continue;
                }
            }

            Console.WriteLine("Count of Vovels: {0}", count);
            */

        }
    }
}
