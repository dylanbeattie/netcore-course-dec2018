using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryExamples
{
    class Program {
        static void Main(string[] args)
        {
            Dictionary<string,Customer> customers = new Dictionary<string, Customer>();

            customers.Add("justinbieber", new Customer("Justin Bieber", true, 1234.56M));
            customers.Add("ladygaga", new Customer("Lady Gaga", true, 123456.78M));

            foreach(var item in customers.Values.Where(c => c.TotalSpending > 1236M)) {
                Console.WriteLine(item);
            }
        }
    }

    public class Customer {
        public override string ToString() {
            return($"{this.Name} ({this.TotalSpending})");
        }
        public Customer(string name, bool isVip, decimal spending) {

            this.Name = name;
            this.IsVip = isVip;
            this.TotalSpending = spending;
        }
        public string Name {get;set;}
        public bool IsVip {get;set;}

        public decimal TotalSpending {get;set;}
    }
}
