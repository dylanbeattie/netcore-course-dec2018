using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;

namespace WebServiceExamples
{
    class Program
    {
        static Stopwatch sw = new Stopwatch();
        static void Log(string message) {
            Console.WriteLine($"{sw.ElapsedMilliseconds} : {message}");
        }

        static void Main(string[] args)
        {
            sw.Start();
            Log("Creating HTTP client");
            HttpClient client = new HttpClient();
            Log("Done!");
            try {
                var boredApiUri = "https://www.boredapi.com/api/activity";


                // example of firing three asynchronous tasks so 
                // that they'll run in parallel side-by-side
                // and give us a faster execution time.
                var task1 = client.GetStringAsync(boredApiUri);
                var task3 = client.GetStringAsync(boredApiUri);
                var task2 = client.GetStringAsync(boredApiUri);

                Log("calling task1.Result");
                Console.WriteLine(task1.Result);
                Log("Done");

                Log("calling task2.Result");
                Console.WriteLine(task2.Result);
                Log("Done");

                Log("calling task3.Result");
                Console.WriteLine(task3.Result);
                Log("Done");
                Log("PROGRAM COMPLETED. WE'RE ALL DONE HERE!");
            } finally {
                client.Dispose();
            }
        }
    }
}
