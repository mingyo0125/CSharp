using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_02_22_Property2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new { Name = "안형주", Age = 18 }; //무명형식
            Console.WriteLine($"이름: {student.Name} \n나이: {student.Age}");
        }
    }
}
