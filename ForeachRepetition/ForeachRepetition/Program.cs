using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ForeachRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            var alias = new Dictionary<string, string>();
            alias.Add("Bruce Wayne", "Batman");
            alias.Add("Clark Kent", "Superman");
            alias.Add("Peter Quill", "Star-Lord");
            alias.Add("Groot", "Groot");
            PrintDictionary(alias);
        }
        public static void PrintDictionary(Dictionary<string, string> aliasList)
        {
            foreach (var name in aliasList)
            {
                Console.WriteLine($"{name.Key} is {name.Value}");
            }
        }
    }
}