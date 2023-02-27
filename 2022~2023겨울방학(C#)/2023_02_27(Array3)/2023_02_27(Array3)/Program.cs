using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_02_27_Array3_
{
    internal class Program
    {
        #region indexer
        class MyList
        {
            private int[] array;

            public MyList(int index)
            {
                array = new int[index];
            }


            public int this[int index]
            {
                get
                {
                    return array[index]; //인덱스를 이용하여 내부 데이터 반환
                }
                set
                {
                    if (index >= array.Length) //인덱스를 이용하여 내부 데이터 저장
                    {
                        Array.Resize(ref array, index + 1); //지정한 인덱스보다 배열의 크기가 작다면 인덱스에 맞춰 배엻의 크기를 재조정
                        Console.WriteLine($"Array Resized : {array.Length}");
                    }
                    array[index] = value;
                }
            }
            public int Length
            {
                get { return array.Length; }
            }
        }
        #endregion

        static void Main(string[] args)
        {
            #region indexer
            int index = int.Parse(Console.ReadLine());
            MyList indexer = new MyList(index);

            for(int i = 0; i < 5; i++)
            {
                indexer[i] = i;
            }

            for(int i = 0; i < indexer.Length; i++)
            {
                Console.WriteLine(indexer[i]);
            }
            #endregion
        }
    }
}