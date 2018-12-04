using System;

namespace PhoneShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var galaxy = new Product("Samsung Galaxy", 599.00M);
            var order = new Order(galaxy, 10);
            var shop = new Shop();
            

            // Test that a customer with enough money CAN assign an order
            var testCustomer = new FakeCustomer(3.00M);
            shop.AssignOrder(order, testCustomer);

            // var c = new Customer();
            // var assignment = shop.AssignOrder(order, c);
            // var result = shop.PlaceOrder(order, c);
        }
    }
    public class OrderAssignment {
        public IHaveACreditBalance Customer { get;set;}
        public Order Order {get; set;}
    }

    public class FakeCustomer : IHaveACreditBalance {
        private decimal howMuchMoney;

        public FakeCustomer(decimal howMuchMoney) {
            this.howMuchMoney = howMuchMoney;
        }
        public decimal GetBalance() {
            return(howMuchMoney);
        }
    }
    public class Shop {
        public object AssignOrder(Order order, IHaveACreditBalance c) {
            if (c.GetBalance() > order.TotalPrice) {
                return new OrderAssignment() {
                    Customer = c,
                    Order = order
                };
            } else {
                throw new Exception("Not enough money!");
            }
        }
        // public object PlaceOrder(Order order, )
    }

    public class Product {
        public Product(string name, decimal price) {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get;set;}
        public decimal Price {get;set;}
    }

    public class Order {

        public Order(Product product, int quantity) {
            this.Product = product;
            this.Quantity = quantity;
        }
        
        public Product Product {get;set;}
    
        public int Quantity {get;set;}

        public decimal TotalPrice {
            get {
                return(Quantity * Product.Price);
            }
        }
    }



    // public class Customer : IHaveACreditBalance, IHaveAShippingAddress, IHaveAnEmailAddress {

    // }



    public interface IHaveACreditBalance {
        decimal GetBalance();

    }

    public interface IHaveAShippingAddress {
        string GetShippingAddress();
    }

    public interface IHaveAnEmailAddress {
        string EmailAddress { get; }
    }
}
