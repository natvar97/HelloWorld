using System;

namespace HelloWorld
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public DateTime BirthDate { get; set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
        

        public void Introduce()
        {
            Console.WriteLine("My name is : " + FirstName + " "  + LastName);
        }
    }
}
