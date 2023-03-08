
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondProblem
{
    class A
    {
        public void Print()
        {
            Console.WriteLine("A");
        }
    }

    class B : A
    {
        public void Print()
        {
            Console.WriteLine("B");
        }
    }

    class C : A
    {
        public void Print()
        {
            Console.WriteLine("C");
        }
    }

    class D : B, C
    {
       
        
        
        
        static void Main()
        {
            D d = new D();
            d.Print();
        }
    }

}
