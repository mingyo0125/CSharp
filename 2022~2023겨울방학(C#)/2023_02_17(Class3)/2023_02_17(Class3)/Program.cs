using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_02_17_Class3_
{
    #region 상속
    class Hero
    {
        public virtual void CwHero()
        {
            Console.WriteLine("I am Hero");
        }
    }

    class Ironman : Hero
    {
        public sealed override void CwHero() //override, sealed
        {
            Console.WriteLine("I am Ironman");
        }
    }

    class Captin : Hero
    {
        public new void CwHero()
        {
            Console.WriteLine("I am Captin");
        }

    }

    class WarMachine : Ironman
    {
        /*
        public override void CwHero() //sealed로 인해 컴파일에러
        {
            Console.WriteLine("I am WarMachine");
        }
        */
    }
    #endregion

    #region readonly
    class Number
    {
        readonly int min; //readonly
        readonly int max; //readonly
        const int _min = 1;

        private Number(int min, int max)
        {
            this.min = min; //readonly라서 생성자에서만 수정가능
            this.max = max; //readonly라서 생성자에서만 수정가능
        }

        private void ResetNumber()
        {
            /*
            min = 1; //readonly라서 생성자에서만 수정가능
            max = 2; //readonly라서 생성자에서만 수정가능
            */
        }
    }
    #endregion

    class Calculator
    {
        private int startNum;
        private int endNum;

        public class Plus //중첩클래스
        {
            int plusNum;
            Calculator calculator = new Calculator();

            public Plus(int _startNum, int _plusNum)
            {
                calculator.startNum = _startNum;
                plusNum = _plusNum;
                calculator.endNum = 0;
            }

            public int PlusNum()
            {
                calculator.endNum = calculator.startNum + plusNum;
                return calculator.endNum;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 상속
            Hero ironman = new Ironman(); //override ("I am Ironman"출력)
            ironman.CwHero();

            Hero captin = new Captin(); //new ("I am Hero"출력)
            captin.CwHero();
            #endregion

            int startNum = int.Parse(Console.ReadLine());
            int plusNum = int.Parse(Console.ReadLine());
            Calculator.Plus plus = new Calculator.Plus(3,3);
            Console.WriteLine(plus.PlusNum());
            
        }
    }
}
