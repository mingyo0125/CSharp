using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_03_05_Delegate2_
{
    internal class Program
    {
        delegate void EventHandler(string msg);

        class MyNotifier
        {
            public event EventHandler SomethingHappened;
            

            public void Dosomething()
            {
                Console.WriteLine("Dosomething 실행됨");
            }
        }

        static public void MyHandler(string msg)
        {
            Console.WriteLine(msg);
        }

        static void Main(string[] args)
        {
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler);
            notifier.Dosomething();
        }

    }
}
