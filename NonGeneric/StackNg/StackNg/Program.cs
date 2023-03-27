using System;
using System.Collections;

namespace StackNg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack name = new Stack();
            name.Push(20);
            name.Push(30);
            name.Push("monday");
            name.Push("tuesday");
            name.Pop();
            foreach(var item in name) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(name.Peek());
            Console.WriteLine(name.Count);
            

        }
    }
}
