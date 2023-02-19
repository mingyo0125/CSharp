using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_02_19_Interface_
{
    class Person : IAnimal //interface 상속
    {
        public void Eat()
        {
            Console.WriteLine("밥을 먹습니다");
        }
    }

    class Lion : IAnimal //interface 상속
    {
        public void Eat()
        {
            Console.WriteLine("고기를 먹습니다");
        }
    }

    class Elephant //interface 상속 X
    {
        public void Eat()
        {
            Console.WriteLine("풀을 먹습니다");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Lion lion = new Lion();
            Elephant elephant = new Elephant();

            person.Eat();
            lion.Eat();
            elephant.Eat();

            MyEatFunc(person);
            MyEatFunc(lion);
            MyEatFunc(elephant); //출력 X
        }

        private static void MyEatFunc(object obj)
        {
            IAnimal animal = obj as IAnimal;
            if(obj != null)
            {
                animal.Eat();
            }
        }
    }
}
