using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    interface Creditcard
    {
        void withdraw();
    }

    interface Debitcard
    {
        void withdraw();
    }

    class Document : Creditcard,Debitcard
    {
        public void withdraw()
        {
            Console.WriteLine("Printing document");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            document.withdraw();
            Console.ReadLine();
        }
    }


}
