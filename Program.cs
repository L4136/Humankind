using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Humankind
{
    class Program
    {
        static void Main(string[] args)
        {


            // create a list to store objects
            List<Mammal> mammals = new List<Mammal>();
            // use polymorphis to store objects
            mammals.Add(new Baby("Amelia", 1, "Libero"));
            mammals.Add(new Adult("Bertil", 45, "Audi"));
            mammals.Add(new Baby("Charles", 0, "Pampers"));
            mammals.Add(new Adult("Diane", 22, "BMW"));
           

            Console.WriteLine("Humans:");

            foreach (Mammal mammal in mammals)
            {
                Human.AgeUp();
                Console.WriteLine(mammal.ToString());
                Console.Write("I am ");
                mammal.Move();
            }
        }   
    }
}
