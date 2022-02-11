using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Math
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var numebr in numbers)
            {
                sum += numebr;
            }

            return sum;
        }

    }
}
