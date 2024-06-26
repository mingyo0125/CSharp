﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_02_23_Array_
{
    struct Test
    {
        public int[] scores; //Array

        public Test(int index)
        {
            scores = new int[index];
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test(5);
            foreach (var i in test.scores) //Array
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(test.scores.Length^1); //^연산자(인덱스의 역순으로 인덱스 지정)


            #region 배열을 초기화 하는 방법
            string[] array1 = new string[3] { "안", "형", "주" }; //1
            string[] array2 = new string[] { "안", "형", "주" }; //2
            string[] array3 = { "안", "형", "주" }; //3
            #endregion
        }
    }
}