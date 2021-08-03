using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStringBuilderClass
{
    class Student
    {
        public string Name;
        public string Surname;
        public int Age;

        public string GetFullName()
        {
            return $"{Name} {Surname}";
        }

        public void PrintFullName()
        {
            Console.WriteLine($"{GetFullName()} {Age}");
        }
    }
}
