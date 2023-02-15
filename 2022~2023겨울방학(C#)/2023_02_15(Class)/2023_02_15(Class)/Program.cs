using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_02_15_Class_
{
    class Cat
    {
        public string name; 
        public static string color; //정적

        //생성자
        public Cat(string name)
        {
            this.name = name; //this키워드 사용
        }

        public void Meow()
        {
            Console.WriteLine($"{name} : {color}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("newcat"); //인스턴스
            Cat.color = "black"; //정적(인스턴스가 필요없음) 
            cat.Meow();
        }
    }
}
