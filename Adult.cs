using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Humankind
{
    class Adult : Human
    {
        public string Car;
        public Adult(string Name, int Age, string car) : base(Name, Age)
        {
            Car = car;
        }

        public override string ToString()
        {
            return base.ToString() + " I drive " + Car + ".";
        }

        public override void Move()
        {
            Console.WriteLine("walking!");
        }
    }
}
