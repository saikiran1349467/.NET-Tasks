using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,String> days= new Dictionary<int,string>();
            days.Add(1,"monday");
            days.Add(2,"Tuesday");
            days.Add(3,"wednesday");
            days.Add(4,"thursday");
            Console.WriteLine("Enter a number");
            int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(days[n]);
            days.Remove(2);
            foreach (var i in days)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(days.Count());
        }
    }
}
