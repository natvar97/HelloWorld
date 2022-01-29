using HelloWorld.Math;
using System;

namespace HelloWorld
{
    public  class PersonMain
    {
        public int Age;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 20;
            Increment(number);
            Console.WriteLine(number);

            var person = new PersonMain() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
            Console.WriteLine("Number in Increment {0}", number);
        }

        public static void MakeOld(PersonMain person)
        {
            person.Age += 10;
        }

    }
}
