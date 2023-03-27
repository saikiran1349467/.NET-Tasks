using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<String> strings = new Queue<String>();
            strings.Enqueue("monday");
            strings.Enqueue("tuesday");
            strings.Enqueue("wednesday");
            strings.Enqueue("thursday");
            strings.Dequeue();  
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(strings.Contains("monday"));
        }
    }
}

