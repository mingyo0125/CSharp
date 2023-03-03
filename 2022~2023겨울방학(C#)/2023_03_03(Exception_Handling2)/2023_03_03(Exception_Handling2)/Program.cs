 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_03_03_Exception_Handling2_
{

    class FilterableException : Exception //사용자 정의 예외 클래스
    {
        public string Error { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 ~ 10사이의 숫자를 입력해주세요");
            int input = int.Parse(Console.ReadLine());

            try
            {
                if( input > 10 || input < 0)
                {
                    throw new FilterableException() {Error = "0~10까지의 수가 아닙니다" };
                }
                else
                {
                    Console.WriteLine($"입력한 수 : {input}");
                }
            }
            catch(FilterableException filter)
            {
                Console.WriteLine(filter.Error);
            }

        }
    }
}
