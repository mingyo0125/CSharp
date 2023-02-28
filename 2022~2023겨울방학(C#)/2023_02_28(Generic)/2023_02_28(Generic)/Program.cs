using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_02_28_Generic_
{
    internal class Program
    {
        static void CopyArray(int[] source, int[] target) 
        {
            for(int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
                Console.WriteLine(target[i]);
            }
        }

        static void CopyArray<T>(T[] source, T[] target) //일반화메서드
        {
            for (int i = 0;i < source.Length;i++)
            {
                target[i] = source[i];
                Console.WriteLine(target[i]);
            }
        }


        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3 };
            int[] target = { 4, 5, 6 };
            CopyArray<int>(source,target); //일반화 메서드 사용
        }
    }
}