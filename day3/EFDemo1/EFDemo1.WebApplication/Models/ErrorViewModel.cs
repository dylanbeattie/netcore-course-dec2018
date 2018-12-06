using System;
using System.Collections.Generic;

namespace EFDemo1.WebApplication.Models {
    public class ErrorViewModel {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class HelloViewModel {
        public string MessageOfTheDay { get; set; }
        public List<Greeting> PersonalisedGreetings { get; set; }
    }

    public class Greeting {
        public Greeting(string salutation, string name) {
            this.Salutation = salutation;
            this.Name = name;
        }
        public string Salutation { get; set; } = "Hello";
        public string Name { get; set; } = "World";
    }

    public class GreetingGenerator {
        private string salutation;
        public GreetingGenerator(string salutation) {
            this.salutation = salutation;
        }
        public List<Greeting> GenerateGreetings(params string[] names) {
            List<Greeting> result = new List<Greeting>();
            foreach (var name in names) {
                result.Add(new Greeting(salutation, name));
            }
            return result;
        }
    }
}