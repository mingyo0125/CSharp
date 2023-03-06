using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_03_06_Lamda_
{
    internal class Program
    {
        delegate int Calculate(int a, int b);
        delegate void DoSomething(string msg);

        static void Main(string[] args)
        {
            //Calculate calculate = (int a, int b) => a + b; //람다

            Calculate calculate = (a,b) => a + b; //형식유추람다
            Console.WriteLine(calculate(3,3));



            DoSomething doSomething = (string msg) => //문 형식의 람다식
            {
                Console.WriteLine(msg);
            };

            doSomething("문 형식의 람다식"); //문 형식의 람다식
        }
    }
}
