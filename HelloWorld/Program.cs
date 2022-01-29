using HelloWorld.Math;
using System;

namespace HelloWorld
{
    public enum ShippingMethods
    {
        RegularMail = 1,
        RegisteredMail = 2,
        Express = 3
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethods.Express;
            Console.WriteLine((int) method);

            var methodId = 3;
            Console.WriteLine((ShippingMethods) methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethods) Enum.Parse(typeof(ShippingMethods), methodName);

            Console.WriteLine(shippingMethod);

        }
    }
}
