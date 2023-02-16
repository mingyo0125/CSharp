using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _2023_02_16_Class2_
{
    class Animal
    {
        string category;
        string name;
        int age;

        protected Animal(string category, string name, int age)
        {
            this.category = category;
            this.name = name;
            this.age = age;
        }
    }

    class Dog : Animal //상속
    {
        public Dog(string category, string name, int age) : base(category, name, age) //base키워드
        {
            WriteLine($"종류 : {category} \n 이름 : {name} \n 나이 : {age}");
        }
    }

    class Cat : Animal //상속
    {
        public Cat(string category, string name, int age) : base(category, name, age) //base키워드
        {
            WriteLine($"종류 : {category} \n 이름 : {name} \n 나이 : {age}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SelectAnimal();
        }

        static void SelectAnimal()
        {
            WriteLine("종류를 선택하세요 (강아지, 고양이)");

            string category = ReadLine();
            string name;
            int age;

            switch (category)
            {
                case "강아지":
                    WriteLine("이름을 입력하세요");
                    name = ReadLine();
                    WriteLine("나이을 입력하세요");
                    age = int.Parse(ReadLine());
                    Dog dog = new Dog(category, name, age);
                    break;

                case "고양이":
                    WriteLine("이름을 입력하세요");
                    name = ReadLine();
                    WriteLine("나이을 입력하세요");
                    age = int.Parse(ReadLine());
                    Cat cat = new Cat(category, name, age);
                    break;

                default:
                    WriteLine("다른 종류를 선택하셨습니다. 강아지와 고양이중 골라주세요");
                    break;
            }
        }
    }
    
}
