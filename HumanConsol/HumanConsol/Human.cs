using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanConsole
{
    class Human
    {
        private string firstName;
        private string lastName;
        private int age;

        public Human(string first, string last)
        {
            firstName = first;
            lastName = last;

        }

        public Human(string first, string last, int age) : this(first, last)
        {
            this.age = age;
        }

        public void PrintData()
        {
            Console.WriteLine("Name: " + this.firstName + " " + this.lastName);
            Console.WriteLine("Age: " + this.age);
        }
    }
}
