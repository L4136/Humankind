using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Humankind
{
    abstract class Mammal
    {
        
        public static int Age { get; set; }

        public  Mammal(int age)
        {
            Age = age;
        }

        public abstract void Move();

        public override string ToString()
        {
            return "!";
        }

       
    }
}

