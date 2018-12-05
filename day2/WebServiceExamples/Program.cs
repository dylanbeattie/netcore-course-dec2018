using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;

namespace WebServiceExamples
{
    class Program 
    {

        static void Main(string[] args)
        {
           
        }

        static Activity GetRandomActivity() {
             HttpClient client = new HttpClient();

            try {
                var boredApiUri = "https://www.boredapi.com/api/activity";
                var task = client.GetStringAsync(boredApiUri);
                var json = task.Result; // THIS LINE is where we wait for the response to come back.
                return(null);

            } finally {
                client.Dispose();
            }
        }
    }
    class ActivitySuggestion {
        public string Activity {get;set;}
        public decimal Accessibility {get;set;}
        public string Type {get;set;}
        public int Participants {get;set;}
        public decimal Price {get;set;}
    }
}
