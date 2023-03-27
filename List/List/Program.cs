using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    using System;
    using System.Collections.Generic;

    namespace ListMethodsExample
    {
        class Program
        {
            static void Main(string[] args)
            {
                List<String> days = new List<string>();
                days.Add("monday");
                days.Add("tuesday");
                days.Add("wednesday");
                days.Add("thursday");
                days.Add("friday");
                days.Add("saturday");
                foreach(Object day in days)
                {
                    Console.WriteLine(day);
                }
                days.RemoveAt(1);
                Console.WriteLine(days.Count());
                days.Insert(2, "monday");
                Console.WriteLine(days.Count());
                Console.WriteLine(days.Contains("tuesday"));
                Console.WriteLine(days[2]);
                

               
            }
        }
    }

}
