using HelloWorld.Math;
using System.Collections.Generic;
using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // excercise - 1
            /*
            var users = new List<string>();
            while(true)
            {
                Console.Write("Enter Username: ");
                var name = Console.ReadLine();
                if(String.IsNullOrEmpty(name.Trim()))
                {
                    if(users.Count == 1)
                    {
                        Console.WriteLine(users[0] + " liked your post.");
                    } else if(users.Count == 2)
                    {
                        Console.WriteLine(users[0] + " and " + users[1] + " liked your post.");
                    } else if(users.Count >= 3 )
                    {
                        Console.WriteLine(users[0] + ", " + users[1] + " and " + (users.Count - 2) + " others liked your post.");
                    } else
                    {
                        Console.WriteLine("No one likes your post.");
                    }
                    break;
                }
                users.Add(name);
            }
            */

            // excercise - 2
            /*
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            var namesArray = new string[name.Length];
        
            for(var i = 0; i < name.Length; i++)
            {
                namesArray[i] = name[i].ToString();
            }

            Array.Reverse(namesArray);

            var newName = "";
            
            foreach(var value in namesArray)
            {
                newName += value;
            }

            Console.WriteLine(newName);
            */

            // excercise - 3

            /*
            Console.Write("Enter unique 5 numbers: ");

            var numbers = new List<int>();

            
            while(true)
            {
                try
                {
                    var number = int.Parse(Console.ReadLine());
                    var isAlready = false;
                    foreach(var value in numbers)
                    {
                        if(number == value)
                        {
                            isAlready = true;
                            Console.WriteLine("You already entered " + number + " earlier, please enter all different numbers");
                        }
                    }
                    
                    if(!isAlready)
                    {
                        numbers.Add(number);
                    }
                    
                    if (numbers.Count == 5)
                    {
                        break;
                    }
                } catch(Exception) {
                    Console.WriteLine("Enter valid number");
                    continue;
                }
            }

            numbers.Sort();
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
            */

            // excercise - 4

            /*
            var numbers = new List<int>();
            Console.WriteLine("Type quit to exit program");
            Console.WriteLine();

            while(true)
            {
                Console.Write("Enter a number: ");
                try
                {
                    var input = Console.ReadLine();
                    if(input.ToLower().Equals("quit"))
                    {
                        break;
                    }
                    var number = int.Parse(input);
                    numbers.Add(number);
                } catch(Exception)
                {
                    Console.WriteLine("You entered invalid number");
                    continue;
                }
            }

            Console.WriteLine();
            var newNumbers = new List<int>();
            foreach(var number in numbers)
            {
                var isAlready = false;
                foreach(var newNumber in newNumbers)
                {
                    if(number == newNumber)
                    {
                        isAlready = true;
                    }
                }
                if(!isAlready)
                {
                    newNumbers.Add(number);
                }
                
            }

            Console.WriteLine();
            Console.WriteLine("Entered unique numbers");
            foreach(var number in newNumbers)
            {
                Console.WriteLine(number);
            }
            */

            // excercise - 5

            var numbers = new List<int>();

            while(true)
            {
                Console.Write("Enter comma separated numbers greater than 5 numbers: ");
                var inputNumbers = Console.ReadLine();
               
                var separedNumbers = inputNumbers.Split(',');
              
                var intNumbers = new int[separedNumbers.Length];
                for (var i = 0; i < separedNumbers.Length; i++)
                {
                    intNumbers[i] = int.Parse(separedNumbers[i]);
                }
                numbers.AddRange(intNumbers);
                if (numbers.Count >= 5)
                {
                    break;
                }
                numbers.Clear();
                Console.WriteLine("Invalid list, Please try again");
            }

            numbers.Sort();
            for (var i = 0; i < 3 ; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
