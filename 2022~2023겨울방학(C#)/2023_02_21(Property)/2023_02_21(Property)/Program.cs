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

            public string Name { get; set; } = "아"; //자동 구현 프로퍼티
        }

        #region 읽기전용 프로퍼티
        class ReadonlyFreiends
        {
            private int age = 10;
            public int Age
            {
                get
                {
                    return age;
                }
            }
        }
        #endregion

        static void Main(string[] args)
        {
            Friends friends = new Friends();
            Console.WriteLine(friends.Age = 5);

            #region 읽기전용 프로퍼티
            ReadonlyFreiends readonlyFreiends = new ReadonlyFreiends();
            Console.WriteLine(readonlyFreiends.Age);
            #endregion

            Console.WriteLine((friends.Name = "안형주")); //자동 구현 프로퍼티

            Friends friends1 = new Friends()
            {
                Age = 10,
                Name = "강민성"
            };
            Console.WriteLine($"{friends1.Name}, {friends1.Age}");
        }
    }
}
