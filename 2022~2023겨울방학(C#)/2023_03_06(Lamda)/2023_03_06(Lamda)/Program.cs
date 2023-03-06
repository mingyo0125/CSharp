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
        static void Main(string[] args)
        {
            //Calculate calculate = (int a, int b) => a + b; //람다

            Calculate calculate = (a,b) => a + b; //형식유추람다
        }
    }
}
