using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SortedlistGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<String,int> name=new SortedList<String,int>();
            name.Add("monday", 1);
            name.Add("tuesday", 2);
            name.Add("wednesday", 3);
            name.Add("Thursday", 4);
            foreach(var s in name)
            {
                Console.WriteLine("key: {0},value: {1}",s.Key,s.Value);
            }

        }
    }
}
