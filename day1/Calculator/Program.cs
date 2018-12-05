using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = "0.4675672";
            decimal bucket;
            if (decimal.TryParse(d, out bucket)) {
                Console.WriteLine("That worked - there's a decimal in the bucket!");
                Console.WriteLine(bucket);
            } else {
                Console.WriteLine("Parsing failed!");
            }
        }

        public void Nope() {
            ICalculateThings calculator;
            while(true) {
                try {
                    Console.WriteLine("Enter your calculation");
                    var calculation = Console.ReadLine();
                    var tokens = calculation.Split(' ');

                    var a = decimal.Parse(tokens[1]);
                    var b = decimal.Parse(tokens[2]);

                    switch(tokens[0]) {
                        case "divide":
                            calculator = new Divider();
                            break;
                        default:
                            continue;
                    }
                    Console.WriteLine(calculator.Calculate(a,b));
                } catch(System.FormatException formatEx) {
                    Console.WriteLine("Sorry, I don't recognise one of those numbers!");
                } catch(System.DivideByZeroException) {
                    Console.WriteLine("Divide by zero is not allowed.");
                } catch(System.OverflowException) {
                    Console.WriteLine("Sorry - one of those numbers is too big!");
                } catch(System.Exception ex) {
                    Console.WriteLine($"Sorry - that failed ({ex.Message})");
                } finally {

                }
                // } catch(Exception ex) {
                //     Console.WriteLine(ex.Message);
                // }
            }
            Console.WriteLine("Hello World!");
        }
    }
    public interface ICalculateThings {
        decimal Calculate(decimal a, decimal b);
    }

    public class Divider : ICalculateThings {
        public decimal Calculate(decimal a, decimal b) {
            return(a/b);
        }
    }

}
