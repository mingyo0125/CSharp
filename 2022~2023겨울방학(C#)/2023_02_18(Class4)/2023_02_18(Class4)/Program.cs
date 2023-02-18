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

        public static int division(this int firstNum, int secondNum) //확장클래스
        {
            return firstNum / secondNum;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine($" {firstNum} * {secondNum} = {firstNum.Multifly(secondNum)}"); //확장클래스
            Console.WriteLine($" {firstNum} / {secondNum} = {firstNum.division(secondNum)}"); //확장클래스
        }
    }
}
