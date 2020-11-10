using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Animal an1 = new Animal();
            Animal an2 = new Animal();

            an1.legs = 55;

            Console.WriteLine(an1.legs);
            Console.WriteLine(an2.legs);

            Cat cat = new Cat();

            Dog dog = new Dog();

            Animal spider = new Animal();

            cat.Speak();
            dog.Speak();
            spider.Speak();

            cat.FindSunbeam();

            Animal unknownPet = new Cat();
            unknownPet.Speak();
            ((Cat)unknownPet).FindSunbeam();

            //Game.Play();
            Game.Test();

        }

       

    }
}
