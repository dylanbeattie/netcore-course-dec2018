using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace WebServiceExamples {
    class Program {

        static void Main(string[] args) {
            while (true) {
                var activities = GetSuggestionsMatching("movie");
                foreach(var a in activities) {
                    Console.WriteLine(a);
                }
                Console.WriteLine("Press Ctrl-C to quit, or any other key to try again");
                Console.ReadKey(false);
            }
        }

        static IEnumerable<ActivitySuggestion> GetSuggestionsMatching(string phrase) {
            var tasks = new List<Task<ActivitySuggestion>>();
            for (var i = 0; i < 100; i++) {
                var task = GetRandomActivity();
                tasks.Add(task);
            }
            Task.WaitAll(tasks.ToArray());
            var matches = tasks.Select(t => t.Result).Where(s => s.Activity.Contains(phrase));
            return matches;
        }

        static async Task<ActivitySuggestion> GetRandomActivity() {
            HttpClient client = new HttpClient();
            try {
                var boredApiUri = "https://www.boredapi.com/api/activity?type=recreational";
                var json = await client.GetStringAsync(boredApiUri);
                var activitySuggestion = JsonConvert.DeserializeObject<ActivitySuggestion>(json);
                return activitySuggestion;
            } finally {
                client.Dispose();
            }
        }
    }
    class ActivitySuggestion {
        public string Activity { get; set; }
        public decimal Accessibility { get; set; }
        public string Type { get; set; }
        public int Participants { get; set; }
        public decimal Price { get; set; }

        public override string ToString() {
            return ($"{Activity} (Accessibility: {Accessibility}; Type: {Type})");
        }
    }
}
