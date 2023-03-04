using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_03_04_Delegate_
{

    internal class Program
    {

        delegate int Calculator(int a, int b); //delegate
        delegate int Generic<T>(T a, T b); //일반화 대리자

        static int Plus(int a, int b)
        {
            return a + b;
        }

        static int Minus(int a, int b)
        {
            return a - b;
        }

        static int Multyply<T>(int a, int b)
        {
            return a * b;
        }

        
        static void Main(string[] args)
        {
            Calculator calculator;
            calculator= new Calculator(Plus);
            Console.WriteLine(calculator(5,3)); //Plus

            calculator = new Calculator(Minus);
            Console.WriteLine(calculator(5, 3)); //Minus

            Generic<int> generic = new Generic<int>(Multyply<int>);
            Console.WriteLine(generic(5,3)); //Multifly(Generic)
        }
    }
}
