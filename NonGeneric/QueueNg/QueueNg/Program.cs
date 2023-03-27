using System;
using System.Collections;

namespace QueueNg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue name= new Queue();
            name.Enqueue(1);
            name.Enqueue(2);
            name.Enqueue(3);
            name.Enqueue("monday");
            name.Dequeue();
            foreach(var item in name) 
            {
                Console.WriteLine(item);
            }
            name.Clear();
            Console.WriteLine(name.Count);
        }
    }
}
