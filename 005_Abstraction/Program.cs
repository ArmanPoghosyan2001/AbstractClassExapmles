using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteDerivedClass instance = new ConcreteDerivedClass();
            instance.SimpleMethod();
            instance.VirtualMethod();
            instance.AbstractMethod();

            //Delay
            Console.ReadKey();
        }
    }
}
