using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_02_17_Class3_
{
    class Hero
    {
        public virtual void CwHero()
        {
            Console.WriteLine("I am Hero");
        }
    }

    class Ironman : Hero
    {
        public override void CwHero() //override
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


    internal class Program
    {
        static void Main(string[] args)
        {
            Hero ironman = new Ironman(); //override ("I am Ironman"출력)
            ironman.CwHero();

            Hero captin = new Captin(); //new ("I am Hero"출력)
            captin.CwHero();

        }
    }
}
