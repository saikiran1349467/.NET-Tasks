
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableNg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht=new Hashtable();
            ht.Add("monday", 1);
            ht.Add("tuesday", 2);
            ht.Add("sunday", 3);
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            Console.WriteLine(ht.ContainsKey("monday"));
            
        }
    }
}
