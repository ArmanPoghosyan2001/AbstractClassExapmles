using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Abstraction
{
    class ConcreteDerivedClass: AbstractBaseClass
    {
        public override void VirtualMethod()
        {
            Console.WriteLine("DerivedClass.VirtualMethod():");
        }

        public override void AbstractMethod()
        {
            Console.WriteLine("DerivedClass.AbstractMethod();");
        }
    }
}
