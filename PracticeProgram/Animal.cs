using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgram
{
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("Dog Eating Food");
        }
        public class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine("Barking...");
            }
        }
    }
}
