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
            Func<int, int, int> FPlus = (a, b) => a + b; //매개변수 있는 Fun

            Console.WriteLine(fun());
            Console.WriteLine(FPlus(6,6));

            Action action = () => Console.WriteLine(14); //매개변수 없는 Action
            Action<int, int> APlus = (a,b) => Console.WriteLine(a + b); //매개변수 있는 Action

            action();
            APlus(8,8);
        }
    }
}
