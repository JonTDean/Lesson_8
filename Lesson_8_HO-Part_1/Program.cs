using System;

namespace Lesson_8_HO_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog buddy = new Dog();
            Cat buzz = new Cat();
            Cow marybelle = new Cow();

            buddy.speak();
            buddy.run();
            buddy.eat();

            buzz.speak();
            buzz.run();
            buzz.eat();

            marybelle.speak();
            marybelle.run();
            marybelle.eat();
        }
    }

    public interface Animal
    {
        void eat();
    }

    public interface Mammal : Animal
    {
        void speak();

        void run();
    }

    class Dog : Mammal
    {
        public void speak()
        {
            Console.WriteLine("Bark!");
        }

        public void run()
        {
            Console.WriteLine("Dogs can run at a top speed of 45mph!");
        }
        
        public void eat()
        {
            Console.WriteLine("Dogs eat bones.");
        }
    }

    class Cat : Mammal
    {
        public void speak()
        {
            Console.WriteLine("Meow!");
        }

        public void run()
        {
            Console.WriteLine("Cats can run at a top speed of 30 mph!");
        }

        public void eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
    }

    class Cow : Mammal
    {
        public void speak()
        {
            Console.WriteLine("Moo!");
        }

        public void run()
        {
            Console.WriteLine("Cows can run at a top speed of 25mph!");
        }

        public void eat()
        {
            Console.WriteLine("Cows eat grass.");
        }
    }
}
