using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileSystemExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"gutenberg-complete-shakespeare.txt";
            var lines = File.ReadAllLines(path);
            var characterNames = lines.Where(line => IsCharacterName(line));
            var actualDialogue = lines.Except(characterNames);
            Console.WriteLine(characterNames.Count());
            var groups = characterNames.GroupBy(c => c.Trim())
                .ToDictionary(group => group.Key, group => group.Count())
                .Where(group => group.Value > 10)
                .OrderBy(entry => entry.Value)
                .Reverse();
            foreach(var thing in groups)
            {
                Console.WriteLine(thing.Key + " : " + thing.Value);
            }
            Console.ReadKey();
        }

        static bool IsCharacterName(string line) {
            return (IsOnlyCapitalsAndPunctuation(line));
        }

        static bool IsOnlyCapitalsAndPunctuation(string line)
        {
            return (line == line.ToUpper());
        }
    }
}