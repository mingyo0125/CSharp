using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_02_24_Array_
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
            Console.WriteLine(test.scores.Length ^ 1); //^연산자(인덱스의 역순으로 인덱스 지정)


             #region 배열을 초기화 하는 방법
            string[] array1 = new string[3] { "안", "형", "주" }; //1
            string[] array2 = new string[] { "안", "형", "주" }; //2
            string[] array3 = { "안", "형", "주" }; //3
            #endregion


            #region 2023_02_24
            Range range = 0..3; //0: 시작 인데스 1: 마지막 인덱스
            int[] sliced = test.scores[range]; //[와] 사이에 인덱스 대신 Systeam.Range 객체를 입력하면 분활된 배열이 반환
            int[] sliced2 = test.scores[1..3]; //더 간결한 버전
            Console.WriteLine(sliced2.Length);

            int[,] square = new int[3,4]; //2차원배열
            int[,,] tetrahedron = new int[3,3,3]; //3차원 배열

            int[][] jaggedArray = new int[3][]; //가변배열
            jaggedArray[0] = new int[3] {1,2,3};
            jaggedArray[1] = new int[5] {1,2,3,4,5};
            jaggedArray[2] = new int[] { 1,2,3,4,4,5,6}; //지정하지 않았으므로 한계가 존재하지 않는다(무한)
            Console.WriteLine(jaggedArray[0][0]); //가변배열 jaggedArray의 0번째 인덱스(new int {1,2,3})의 0번째 인덱스(1)출력
            #endregion
        }
    }
}