using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var listMaker = new NumberListMaker();
            var count = listMaker.AllTheIntegers.Count();
            Console.WriteLine(count);
        }
    }

    public class NumberListMaker {
        public IEnumerable<int> AllTheIntegers {
            get {
                var i = 0;
                while(true) yield return i++;
            }
        }
    }
}
