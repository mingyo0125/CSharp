using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_03_04_Delegate_
{

    internal class Program
    {

        delegate void Calculator(int a, int b); //delegate
        delegate void Generic<T>(T a, T b); //일반화 대리자

        static void Plus(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        static void Minus(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        static void Multyply<T>(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }

        
        static void Main(string[] args)
        {
            Calculator calculator;
            /*
            calculator = new Calculator(Plus);
            calculator(5, 3); //Plus

            calculator = new Calculator(Minus);
            calculator(5, 3);
            */
            calculator = new Calculator(Plus);
            calculator += new Calculator(Minus);
            calculator(10, 5); //대리자 체인
            calculator -= new Calculator(Plus); //대리자 체인 제거
            calculator -= new Calculator(Minus); //대리자 체인 제거


            Generic<int> generic = new Generic<int>(Multyply<int>);
            generic(10,5); //Multifly(Generic)

            calculator = delegate (int a, int b) //익명메소드
            {
                Console.WriteLine($"{a} / {b} = {a / b}");
            };

            calculator(10,5);
        }
    }
}
