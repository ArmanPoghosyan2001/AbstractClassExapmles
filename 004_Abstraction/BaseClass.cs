using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Abstraction
{
    abstract class AbstractBaseClass
    {
        public void SumpleMethod()
        {
            Console.WriteLine("AbstractBaseClass.SimpleMethod");
        }

        public virtual void VirtualMethod()
        {
            Console.WriteLine("AbstractBaseClass.VirtualMethod");
        }


        abstract public void AbstractMethod();
    }
}
