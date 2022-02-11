using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Customer
    {

        private string Name;
        private string Description;

        private Customer()
        {

        }

        public Customer(string name)
        {
            this.Name = name;
        }

        public Customer(string name, string description)
        {
            this.Description = description;
        }

    }
}
