using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_02_22_Property2_
{
    

    abstract class Parents
    {
        public abstract int Age { get; set;}
        public abstract string Name { get; set; }
    }

    #region 인터페이스의 프로퍼티
    interface ITeacher //인터페이스의 프로퍼티
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
    #endregion

    class _Person : Parents
    {
        public override int Age { get; set; }
        public override string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new { Name = "안형주", Age = 18 }; //무명형식
            Console.WriteLine($"이름: {student.Name} \n나이: {student.Age}");

            Parents _Person = new _Person();
            _Person.Name = "안형주";
            _Person.Age = 18;
            Console.WriteLine($"이름: {_Person.Name} \n나이: {_Person.Age}");
        }
    }
}
