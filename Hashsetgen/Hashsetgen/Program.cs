using System;
using System.Collections.Generic;

namespace Hashsetgen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("a");
            set.Add("b");
            set.Add("c");
            set.Add("d");
            set.Add("a");
            set.Add("b");
            foreach(string s in set)
            {
                Console.WriteLine(s);
            }
            set.RemoveWhere(s => s != "b");
            Console.WriteLine(set.Count);
            Console.WriteLine(set.Contains("a"));
        }
    }
}
