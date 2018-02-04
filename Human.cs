using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Humankind
{
    class Human : Mammal
    {
        public static string Name;
        public Human(string name, int Age) : base(Age)
        {
            Name = name;
        }

        public static void AgeUp()
        {
            Age++;
        }
        public override string ToString()
        {
            return "My name is " + Name + " and I am " + Age + " years old. ";
        }

        public override void Move()
        {
            Console.WriteLine("moving!");
        }
    }
}
