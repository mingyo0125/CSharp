using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_02_22_Property2_
{
    interface ITeacher
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    class Person : ITeacher
    {
        private int age;
        private string name;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new { Name = "안형주", Age = 18 }; //무명형식
            Console.WriteLine($"이름: {student.Name} \n나이: {student.Age}");
        }
    }
}
