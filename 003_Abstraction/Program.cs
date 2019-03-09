using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Abstraction
{

    abstract class AbstractClassA
    {
        public abstract void OperationA();
    }


    abstract class AbstractClassB : AbstractClassA
    {
        public abstract void OperationB();
    }


    class ConcreteClass : AbstractClassB
    {

        public override void OperationA()
        {
            Console.WriteLine("ConcreteOperationa");
        }

        public override void OperationB()
        {
            Console.WriteLine("ConcreteOperationB");
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            AbstractClassA instance = new ConcreteClass();

            instance.OperationA();

            //instance.OperationB();



            //Delay
            Console.ReadKey();
        }
    }
}
