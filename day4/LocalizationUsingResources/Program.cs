using System;
using System.Globalization;

namespace LocalizationUsingResources {
    class Program {
        static void Main(string[] args) {
            var cultureNames = new[] { "en-GB", "fr-FR", "es", "ru-RU" };
            foreach (var cultureName in cultureNames) {
                var culture = new CultureInfo(cultureName);

                System.Threading.Thread.CurrentThread.CurrentCulture = culture;
                System.Threading.Thread.CurrentThread.CurrentUICulture = culture;
                Console.WriteLine(Messages.Program_HelloWorld);
            }
            Console.ReadKey(false);
        }
    }
}
