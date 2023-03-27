using System;
using System.Collections;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList arrayList = new ArrayList();
            arrayList.Add("Hello");
            arrayList.Add(20);
            arrayList.Add(3.14);

            Console.WriteLine("ArrayList:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(arrayList.IndexOf(20));
            Console.WriteLine(arrayList.Count);
            Console.WriteLine(arrayList.Contains(1));

            Console.ReadLine();
        }
    }
}


