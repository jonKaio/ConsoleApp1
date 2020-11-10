using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Animal 
    {
        public int legs=2;
        public int heads = 1;
        public int eyes = 2;
        public bool warmBlooded = true;

        public static string testStatic = "THIS IS A STATIC VAR OR FIELD";

        public void PrintThing()
        {
            Console.WriteLine("This is a test.");
        }

        public virtual void Speak()
        {
            Console.WriteLine("Mumble");
        }


    }
}
