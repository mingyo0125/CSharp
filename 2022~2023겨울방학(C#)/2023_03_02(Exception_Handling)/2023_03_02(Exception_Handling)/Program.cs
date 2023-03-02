using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_03_02_Exception_Handling_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("홀수를 입력하세요");
            try
            {
                int input = int.Parse(Console.ReadLine());
                if(input % 2 == 0)
                {
                    throw new Exception("짝수입니다.");
                }
                else
                {
                    Console.WriteLine("어 잘했어");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
