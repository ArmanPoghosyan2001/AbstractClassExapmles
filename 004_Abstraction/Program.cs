using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Abstraction
{

    class Program
    {
        static void Main(string[] args)
        {
            ConcreteDerivedClass instance = new ConcreteDerivedClass();
            instance.SumpleMethod();
            instance.VirtualMethod();
            instance.AbstractMethod();

            //Delay
            Console.ReadKey();
        }
    }
}
