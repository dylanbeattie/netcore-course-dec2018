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

            
        //     string responseBody = await client.GetStringAsync(uri);
        //     var task = GetDataFromWebApi("https://www.boredapi.com/api/activity");
        //     task.Wait();
        //     Console.WriteLine("Hello World!");
        // }

        // static async Task GetDataFromWebApi(string url) {
        // // Create a New HttpClient object.
        // HttpClient client = new HttpClient();
        
        // // Call asynchronous network methods in a try/catch block to handle exceptions
        // try	
        // {
        //     HttpResponseMessage response = await client.GetAsync(url);
        //     response.EnsureSuccessStatusCode();
        //     string responseBody = await response.Content.ReadAsStringAsync();
        //     // Above three lines can be replaced with new helper method below
        //     // string responseBody = await client.GetStringAsync(uri);

        //     Console.WriteLine(responseBody);
        // }  
        // catch(HttpRequestException e)
        // {
        //     Console.WriteLine("\nException Caught!");	
        //     Console.WriteLine("Message :{0} ",e.Message);
        // }

        // // Need to call dispose on the HttpClient object
        // // when done using it, so the app doesn't leak resources
        // client.Dispose();
        // }
    }
}
