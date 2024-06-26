﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_02_26_Array_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Arraylist
            ArrayList arrayList = new ArrayList();
            Arlist.Add(1);
            Arlist.Add(2);
            Arlist.Add(3);
            Arlist.Insert(3, 2);
            Arlist.RemoveAt(2);
            #endregion

            #region Queue
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();
            for (int i = 0; i < queue.Count; i++)
            {
                Console.WriteLine(queue.Count);
            }
            #endregion

            #region Stack
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            Console.WriteLine(stack.Count);
            #endregion

            #region Hasatable
            Hashtable hashtable = new Hashtable();
            hashtable[0] = "일";
            hashtable[1] = "이";
            hashtable[2] = "삼";
            for (int i = 0; i < hashtable.Count; i++)
            {
                Console.WriteLine(hashtable[i]);
            }
            #endregion

            #region 컬렉션을 초기화하는 방법
            int[] arr = { 0, 1, 2 };
            ArrayList arrayList1 = new ArrayList(arr);
            Queue queue1 = new Queue(arr);
            Stack stack1 = new Stack(arr);
            Hashtable hashtable1 = new Hashtable(arr);

            ArrayList arrayList2 = new ArrayList() { 11, 22, 33 }; //ArrayList는 배열의 도움 없이 직접 컬렉션 초기자를 이용해 초기화 가능

            Hashtable hashtable2 = new Hashtable()
            {
                "1" = "하나";
                "2" = "둘";
                "3" = "셋";
            };
            #endregion
        }
    }
}