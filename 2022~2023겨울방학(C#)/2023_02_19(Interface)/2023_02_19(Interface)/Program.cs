using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_02_19_Interface_
{

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

    class Human : IHuman
    {
        public void Eat()
        {
            Console.WriteLine("사람이 밥을 먹습니다");
        }
        public void Walk()
        {
            Console.WriteLine("사람이 걷습니다");
        }
    }

    class God : IGod
    {
        public void Eat()
        {
            Console.WriteLine("God can eat");
        }
        public void Walk()
        {
            Console.WriteLine("God can walk");
        }
        public void Fly()
        {
            Console.WriteLine("God can fly");
        }
        public void CanAnyThing()
        {
            Console.WriteLine("God can anything");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            Elephant elephant = new Elephant();

            lion.Eat();
            elephant.Eat();


            MyEatFunc(lion);
            /* MyEatFunc(elephant); */ //출력 X

            Human human = new Human();
            human.Eat();
            human.Walk();

            God god = new God();
            god.Eat();
            god.Walk();
            god.Fly();
            god.CanAnyThing();
        }

        private static void MyEatFunc(object obj)
        {
            IAnimal animal = obj as IAnimal; //매개변수로 받아온 ogj를 IAnial로 형변환, IAnimal을 상속받지 않았다면 Eat 메서드 수행 X
            if(obj != null)
            {
                animal.Eat();
            }
        }
    }
}
