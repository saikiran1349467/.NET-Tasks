using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<String> list = new LinkedList<String>();

            list.AddFirst("monday");
            list.AddFirst("tuesday");
            list.AddFirst("wednesday");
            list.AddLast("thursday");
            foreach(String s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(list.Contains("monday"));
        }
    }
}
