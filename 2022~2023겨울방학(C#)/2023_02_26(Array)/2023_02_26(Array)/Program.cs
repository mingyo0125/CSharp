using System;
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
            ArrayList Arlist = new ArrayList();
            Arlist.Add(1);
            Arlist.Add(2);
            Arlist.Add(3);
            Arlist.Insert(3,2);
            Arlist.RemoveAt(2);
            #endregion
        }
    }
}