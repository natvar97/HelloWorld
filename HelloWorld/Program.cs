using HelloWorld.Math;

namespace HelloWorld
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.firstName = "Urvashi";
            person.lastName = "Prajapati";
            person.Introduce();

            var calculator = new Calculator();
            var sum = calculator.Add(20, 10);
            System.Console.WriteLine(sum);

        }
    }
}
