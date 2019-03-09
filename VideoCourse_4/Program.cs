using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoCourse_4
{
    abstract class AbstractClass
    {
        public abstract void Method();
    }

    class ConcreteClass : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("Implementation");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass instance = new ConcreteClass();

            instance.Method();
            
            //Delay
            Console.ReadKey();
        }
    }
}
