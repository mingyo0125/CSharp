using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_03_07_Lamda2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int> fun = () => 10; //매개변수 없는 Fun
            Func<int, int, int> Plus = (a, b) => a + b; //매개변수 있는 Fun

            Console.WriteLine(fun());
            Console.WriteLine(Plus(6,6));
        }
    }
}
