using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_02_21_Property_
{
    internal class Program
    {
        class Friends
        {
            private int age;
            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    age = value;
                }
            }
        }

        static void Main(string[] args)
        {
            Friends friends = new Friends();
            Console.WriteLine(friends.Age = 5);
        }
    }
}
