using System;
using System.Globalization;

namespace Localization {
    class Program {
        static void Main(string[] args) {
            var thread = System.Threading.Thread.CurrentThread;


            foreach (var cultureName in new[] { "en-GB", "fr-FR", "de-DE", "ru-RU", "fr-CA" }) {
                var culture = new CultureInfo(cultureName);
                thread.CurrentCulture = culture;
                thread.CurrentUICulture = culture;
                ShowThings(thread);
            }
            Console.WriteLine("Hello World!");
            Console.ReadKey(false);
        }

        public static void ShowThings(System.Threading.Thread thread) {

            string eszett = "ß";

            var equalCurrently = eszett.Equals("ss", StringComparison.CurrentCulture);
            var equalNormally = eszett.Equals("ss", StringComparison.InvariantCultureIgnoreCase);
            var equalOrdinally = eszett.Equals("ss", StringComparison.Ordinal);
            Console.WriteLine(equalOrdinally);

            Console.WriteLine("fitness".Contains("ß", StringComparison.CurrentCultureIgnoreCase));
            // Console.WriteLine("fitness".Contains("ß", StringComparison.InvariantCultureIgnoreCase));

            Console.WriteLine(equalCurrently);
            Console.WriteLine(equalNormally);

            Console.WriteLine(thread.CurrentCulture);
            Console.WriteLine(thread.CurrentUICulture);
            Console.WriteLine(DateTime.Now.ToString("dddd dd MMMM yyyy"));
            var x = 123456789;
            var howHeavyIsDylan = 102.345M;
            var y = 12345.67890M;

            Console.WriteLine("Dylan weighs " + howHeavyIsDylan.ToString() + "kg");
            Console.WriteLine(y);
        }
    }
}
