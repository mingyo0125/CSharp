using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2023_02_18_Class4_; //확장클래스

namespace _2023_02_18_Class4_
{
    public static class Calculator
    {
        public static int Multifly(this int firstNum, int secondNum) //확장클래스
        {
            return firstNum * secondNum;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($" 3 * 4 = {3.Multifly(4)}"); //확장클래스
        }
    }
}
