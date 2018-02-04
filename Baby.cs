using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Humankind
{
    class Baby : Human
    {
        public string Diaper;
        public Baby (string Name, int Age,string diaper) : base(Name, Age)
        {
            Diaper = diaper;
        }

        public override string ToString()
        {
            return base.ToString() + " I wear " + Diaper + ".";
        }

        public override void Move()
        {
            Console.WriteLine("crawling!");
        }
    }
}
