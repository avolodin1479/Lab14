using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кошка");
            Dog dog = new Dog("Собака");
            cat.ShowInfo();
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Say();
        public virtual void ShowInfo()
        {
            Console.Write("{0} ", Name);
            Say();
        }
    }
    internal class Cat : Animal
    {
        private string name;
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Cat(string name)
            : base(name)
        {
            this.Name = name;
        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }

    class Dog : Animal
    {
        private string name;
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Dog(string name)
            : base(name)
        {
            this.Name = name;
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
