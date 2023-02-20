using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_02_20_abstract_
{
    internal class Program
    {
        abstract class AbstractBase
        {
            public abstract void AbstractMethod();
        }

        class Derived : AbstractBase
        {
            public override void AbstractMethod()
            {
                Console.WriteLine("Dervied.AbstractMethod");
            }
        }


        static void Main(string[] args)
        {
            AbstractBase derived = new Derived();
            derived.AbstractMethod();
        }
    }
}
