using System;

namespace 實例81_到底呼叫了誰
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Animal a1 = new Cat();
            Animal a2 = new Rabbit();
            Animal a3 = new Dog();
            a1.Name
            Console.WriteLine($"這只寵物是{a1.Name}");
            Console.WriteLine($"這只寵物是{a2.Name}");
            Console.WriteLine($"這只寵物是{a3.Name}");

        }
    }

    abstract class Animal
    {
        public abstract string Name { get; }

        public int Add(int i, int j) => i + j;
    }

    class Cat : Animal
    {
        public override string Name => "貓貓";

        public double Pi()
        {
            return Math.PI;
        }
    }

    class Rabbit : Animal
    {
        public override string Name => "兔子";
    }

    class Dog : Animal
    {
        public override string Name => "狗狗";
    }
}
