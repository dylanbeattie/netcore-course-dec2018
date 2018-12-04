using System;

namespace Enumerations
{
    enum DayOfTheWeek {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday    
    }
    
    class Program
    {

        static void Main(string[] args) {
            DayOfTheWeek today = (DayOfTheWeek)5;
            Console.WriteLine(today.GetType());
            switch(today) {
                case DayOfTheWeek.Monday: 
                case DayOfTheWeek.Tuesday: 
                case DayOfTheWeek.Wednesday: 
                case DayOfTheWeek.Thursday: 
                case DayOfTheWeek.Friday: 
                    Console.WriteLine("It's a normal weekday");
                    break;
                case DayOfTheWeek.Saturday: 
                case DayOfTheWeek.Sunday: 
                    Console.WriteLine("YAY!WEEKEND!");
                    break;
            }
        }
    }
}
