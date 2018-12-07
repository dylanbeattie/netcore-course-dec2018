using System;

namespace StructsAndOperators {
    class Program {
        static void Main(string[] args) {

            var d = DateTime.Now;
            Console.WriteLine(d.ToString("F"));
            Console.WriteLine(d.ToString("dddd dd MMMM yyyy HH:mm:ss"));
            Console.ReadKey(false);
        }

        static void DateArithmeticExamples() {
            var d = DateTime.Now;

            var d1 = DateTime.Parse("1917-10-15 14:32:00");
            var d2 = DateTime.Parse("1969-07-20 03:00:00");

            var result = d2 - d1;
            Console.WriteLine(result.Days + " days, " + result.Hours + " hours, " + result.Minutes + " minutes " + result.Seconds + " seconds");
            Console.WriteLine(result.TotalHours);
            Console.WriteLine(result.TotalMinutes);

            Console.ReadKey(false);
        }
    }
}
