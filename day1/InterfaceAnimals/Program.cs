using System;

namespace InterfaceAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            var incubator = new Incubator();
            var c = new Crocodile();
            var o = new Ostrich();
            var s = new Sparrow();
            Console.WriteLine("Crocodile eggs!");
            incubator.Incubate(c);
            Console.WriteLine("Ostrich");
            incubator.Incubate(o);
            Console.WriteLine("Sparrow");
            incubator.Incubate(s);
        }
    }


    public class Incubator {
        public void Incubate(ILayEggs subject) {
            int numberOfEggsToHatch = subject.LayEggs();
            for(var i = 0; i < numberOfEggsToHatch; i++) {
                Console.WriteLine($"Hatched {i+1} eggs!");
            }
        }
     }

    public class Crocodile : ILayEggs, ICanSwim, I {
        public int LayEggs() {
            return(3);
        }

        public void Swim() {
            throw new NotImplementedException();
        }
    }

    public class Sparrow : ICanFly, ILayEggs {
        public void Fly() {
            throw new NotImplementedException();
        }

        public int LayEggs() {
            return(10);
        }
    }

    public class Ostrich : ILayEggs {
        public int LayEggs() {
            return(1);
        }
    }
    public interface ILayEggs {
        int LayEggs();
    }

    public interface ICanFly {
        void Fly();
    }

    public interface ICanSwim {
        void Swim();
    }

}
