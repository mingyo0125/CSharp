using System;
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
            Console.WriteLine(test.scores.Length^1); //^연산자
        }
    }
}