using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_02_19_Interface_
{
    internal interface IAnimal
    {
        void Eat();
    }

    interface IHuman : IAnimal
    {
        void Walk();
    }

    interface IBird
    {
        void Fly();
    }

    interface IGod : IHuman, IBird
    {
        void CanAnyThing();
    }
}
