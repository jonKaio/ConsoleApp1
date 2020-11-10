using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Cat : Animal
    {

        public override void Speak()
        {
            Console.WriteLine("Meow");
        }

        public void FindSunbeam()
        {
            Console.WriteLine("I go find a sunbeam now");
        }
    }
}
