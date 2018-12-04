using System;

namespace InheritanceAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat();
            Console.WriteLine("Walking the cat...");
            cat.Walkies();

            var dog = new Dog();
            Console.WriteLine("Walking the dog...");
            dog.Walkies();

            var worm = new Worm();
            Console.WriteLine("Walking the worm...");
            worm.Walkies();

        }
    }

    public abstract class Animal {
        public virtual string Speak() {
            return "<random animal noise>";
        }
        public void Walkies() {
            if (NumberOfLegs == 0) {
                Console.WriteLine("Can't walk! No legs!");
            }else {
                for(var i = 0; i < this.NumberOfLegs; i++) {
                    Console.WriteLine("Clomp");
                }
            }
        }

        protected abstract int NumberOfLegs { get; }

    }

    public abstract class Quadraped : Animal {
        protected override int NumberOfLegs { get { return 4; } }
    }

    public class Cat : Quadraped {
        public override string Speak() {
           return("Meow!");
        }
    }

    public class Dog : Quadraped {
        public override string Speak() {
            return("Woof!");
        }
    }
    public class Millipede : Animal {
        protected override int NumberOfLegs { get { return 100; } }
    }

    public class Worm : Animal {
        protected override int NumberOfLegs { get { return 0; } }
    }
}
