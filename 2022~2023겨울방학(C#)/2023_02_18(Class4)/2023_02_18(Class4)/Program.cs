using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2023_02_18_Class4_; //확장클래스

namespace _2023_02_18_Class4_
{
    readonly struct readonlyStruct
    {
        public readonly int Value;

        public readonlyStruct(int value)
        {
            this.Value = value;
        }
        /*
        public string Name; //readonly 구조체는 readonly필드만 가능
        */
    }


    struct Calculator
    {
        public int firstNum;
        public int SecondNum;

        public Calculator(int firstNum, int secondNum)
        {
            this.firstNum = firstNum;
            this.SecondNum = secondNum;
        }

        public int Plus() //구조체를 이용한 덧셈
        {
            return firstNum + SecondNum;
        }

        public int Minus() //구조체를 이용한 뺄셈
        {
            return firstNum - SecondNum;
        }
    }


    public static class Calculator2
    {
        public static int Multifly(this int firstNum, int secondNum) //확장클래스를 이용한 곱셈
        {
            return firstNum * secondNum;
        }

        public static int division(this int firstNum, int secondNum) //확장클래스를 이용한 나눗셈
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
            Console.WriteLine($" {firstNum} x {secondNum} = {firstNum.Multifly(secondNum)}"); //확장클래스
            Console.WriteLine( firstNum.division(secondNum)  != 0 ? $" {firstNum} ÷ {secondNum} = {firstNum.division(secondNum)}" :
                $" {firstNum} ÷ {secondNum} = {firstNum} / {secondNum}"); //확장클래스

            Calculator calculator; //구조체
            calculator.firstNum = firstNum; //구조체는 인스턴스 생성을 하지 않아도 됨
            calculator.SecondNum = secondNum; //구조체는 인스턴스 생성을 하지 않아도 됨

            Calculator calculator1 = new Calculator(firstNum, secondNum); //물론 인스턴스 생성도 가능함

            Console.WriteLine($" {firstNum} + {secondNum} = {calculator.Plus()}"); //인스턴스 생성을 하지 않은 구조체를 이용한 덧셈
            Console.WriteLine($" {firstNum} - {secondNum} = {calculator1.Minus()}"); //인스턴스 생성을 하여 구조체를 이용한 뺄셈

            readonlyStruct readonlyStruct;
            /*
            readonlyStruct.Value = 1; //readonly라서 할당 불가능
            */
            readonlyStruct readonlyStruct1 = new readonlyStruct(1); //하지만 생성자는 할당가능
        }
    }
}
