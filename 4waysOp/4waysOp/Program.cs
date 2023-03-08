using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _4waysOp
{
    internal class Program
    {
        //public void Greet(string name)
        //{
        //    Greet(name, "hello");
        //}

        //public void Greet(string name, string greeting)
        //{
        //    Console.WriteLine($"{greeting}  {name}!");
        //}

        //public void Greet(string name, string greeting = default(string))
        //{
        //    Console.WriteLine($"{greeting} {name}!");
        //}


        //public void Greet(string name, params string[] greetings)
        //{
        //    if (greetings.Length == 0)
        //    {
        //        greetings = new[] { "Hello" };
        //    }
        //    foreach (var greeting in greetings)
        //    {
        //        Console.WriteLine($"{greeting}  {name}!");
        //    }
        //}

        //public void employee(string officename, string firstname, string lastname)
        //{
        //    Console.WriteLine($"Employee Name: {firstname} {lastname}\nOffice Name: {officename}\n");
        //}

        //static void Main(string[] args)
        //{
        //    Program ob = new Program();
        //    ob.employee(officename: "Epam Systems",  "sai",  "kiran");
        //    ob.employee(lastname: "kumar", officename: "TCS", firstname: "sai");
        //}
        //static void Main(string[] args)
        //{
        //    Program ob = new Program();

        //    // calling the method with positional arguments
        //    ob.employee("Epam Systems", "sai", "kiran");
        //    ob.employee("TCS", "sai", "kumar");
        //}
        public void employee(string officename, string firstname, string lastname)
        {
            Console.WriteLine($"Employee Name: {firstname} {lastname}\nOffice Name: {officename}\n");
        }

        static void Main(string[] args)
        {
            Program ob = new Program();

            // This will throw a compilation error, because we're mixing positional and named arguments
            ob.employee(officename: "Epam Systems", "sai", "kiran");
        }


    }
}
