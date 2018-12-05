using System;
using System.Linq;
using System.Collections.Generic;

namespace CustomerLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new CustomerDatabase();
            var vips = db.ListAllCustomers()
                .Where(c => c.IsVip)
                .OrderByDescending(c => c.TotalSpending)
                .Take(5)
                .ToList();
            foreach(var vip in vips) {
                Console.WriteLine(vip.Name);
            }
        }
    }

    public class Customer {
        public string Name {get;set;}
        public bool IsVip {get;set;}

        public decimal TotalSpending {get;set;}
    }

    public class CustomerDatabase {
        public IEnumerable<Customer> ListAllCustomers() {

            yield return new Customer {
                Name = "Mickey Moneybags",
                IsVip = true,
                TotalSpending = 12345698.00M
            };
            yield return new Customer {
                Name = "Broke Sid",
                IsVip = false,
                TotalSpending = 0.03M
            };
            yield return new Customer {
                Name = "Kanye West",
                IsVip = true,
                TotalSpending = 123458.00M
            };
        }
    }
}
