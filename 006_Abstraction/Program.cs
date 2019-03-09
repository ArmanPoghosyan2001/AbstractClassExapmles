using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Abstraction
{
    abstract class AbstractClass
    {
        public AbstractClass()
        {
            Console.WriteLine("1 AbstractClass();");
            this.AbstractMethod();

            Console.WriteLine("2 AbstractClass():");
        }

        public abstract void AbstractMethod();
    }

    class ConcreteClass : AbstractClass
    {
        string s = "First";

        public ConcreteClass()
        {
            Console.WriteLine("3 ConcreteClass():");
            s = "Second";
        }
        public override void AbstractMethod()
        {
            Console.WriteLine("Realise AbstractMethod() in ConcreteClass {0}", s);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass instance = new ConcreteClass();
            Console.WriteLine(new string ('-',55));

            instance.AbstractMethod();

            //Delay
            Console.ReadKey();
        }
    }
}
