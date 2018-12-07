using System;
using System.Collections.Generic;
using System.Linq;

namespace StructExamples {
    class Program {
        static void Main(string[] args) {

            var p1 = new PersonStruct { NationalInsuranceNumber = "EVH1234A", FirstName = "Eddie", LastName = "van Halen" };
            var p2 = new PersonStruct { NationalInsuranceNumber = "JS123456A", FirstName = "Theresa", LastName = "May" };
            var p3 = new PersonStruct { NationalInsuranceNumber = "JOA1234B", FirstName = "Joan", LastName = "of Arc" };
            var p4 = new PersonStruct { NationalInsuranceNumber = "AE12345G", FirstName = "Amelia", LastName = "Earhart" };
            var p5 = new PersonStruct { NationalInsuranceNumber = "JS123456A", FirstName = "Jeremy", LastName = "Corbyn" };

            var people = new List<PersonStruct> { p1, p2, p3, p4, p5 };
            people.Sort();
            foreach (var person in people) {
                Console.WriteLine(person);
            }
            //var d = new Dictionary<PersonStruct, decimal> {
            //    { p1, 250000M },
            //    { p2, 85000M },
            //    { p3, 0M },
            //    { p4, 4500M },
            //    { p5, 200M }
            //};

            //foreach (var person in d) {
            //    Console.WriteLine(person.Key + "=" + person.Value);
            //}
            //Console.WriteLine(d.Count());

            //if (p1 == p2) {
            //    Console.WriteLine("They're the same!");
            //} else {
            //    Console.WriteLine("TOTALLY DIFFERENT...");
            //}
            //if (p1.Equals(p2)) {
            //    Console.WriteLine("They're the same!");
            //} else {
            //    Console.WriteLine("TOTALLY DIFFERENT...");
            //}

            Console.ReadKey(false);
        }
    }

    //public class PersonClass {
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //}

    public struct PersonStruct : IComparable {

        public override string ToString() {
            return (this.FirstName + " " + this.LastName);
        }

        public override int GetHashCode() {
            return NationalInsuranceNumber.GetHashCode();
        }
        public static bool operator <(PersonStruct p1, PersonStruct p2) {
            return (p1.FirstName.Length < p2.FirstName.Length);
        }

        public static bool operator >(PersonStruct p1, PersonStruct p2) {
            return (p1.FirstName.Length > p2.FirstName.Length);
        }

        public static bool operator ==(PersonStruct p1, PersonStruct p2) {
            return p1.Equals(p2);
        }

        public static bool operator !=(PersonStruct p1, PersonStruct p2) {
            return !p1.Equals(p2);
        }

        public override bool Equals(object obj) {
            if (obj is PersonStruct) {
                return NationalInsuranceNumber == ((PersonStruct)obj).NationalInsuranceNumber;
            } else {
                return (false);
            }
        }

        public int CompareTo(object obj) {
            if (obj is PersonStruct) {
                PersonStruct that = (PersonStruct)obj;
                if (that < this) return (-1);
                if (that > this) return (1);
                return (0);
            }
            return (0);            
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }


        public string NationalInsuranceNumber { get; set; }

    }

}
