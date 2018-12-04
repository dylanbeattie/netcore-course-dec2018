using System;

namespace ObjectExamples1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lionel = new Animal();
            Console.WriteLine(lionel.Name);
            var spider = new Animal("Cuddles");
            Console.WriteLine(spider.Name);
            Console.WriteLine(lionel.WeightInKg);
            Console.WriteLine(lionel.NumberOfLegs);
        }
    }
    [Flags]
    public enum Diet {
        Carnivore = 1 ,
        Herbivore = 2,
        Furniture = 4
    }

    public class Animal {

        public Animal() : this("Fluffy") { 

        }
        public Animal(string name) {
            this.Name = name;
        }
        private Diet diet;

        public Diet Diet {
            get; set;
        }

        public string Name {get; set; }
        public decimal WeightInKg {  get; set;  }
        public bool HasATail {get;set;}
        public bool IsItCute {get;set;}
        public int NumberOfLegs {get;set;}
    }
}
