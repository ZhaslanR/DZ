using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class RangeOfArray
    {
        public int FirstIndex { get; set; }
        public int LastIndex { get; set; }


        private int[] mas;

        public RangeOfArray()
        {
            mas = new int[LastIndex - FirstIndex]
        }
        //public int this[int index]
        //{
        //    get
        //    {
        //        if(FirstIndex > LastIndex)
        //        {
        //            if(index > FirstIndex && index < LastIndex)
        //            {
        //                return mas[index - LastIndex];
        //            }
        //            else
        //            {
        //                Console.WriteLine("Выход за границы массива");
        //            }
        //        }
        //        else
        //        {
        //            if (index > FirstIndex && index < LastIndex)
        //            {
        //                return mas[index - FirstIndex];
        //            }
        //            else
        //            {
        //                Console.WriteLine("Выход за границы массива");
        //            }
        //        }
        //    }
        //    set
        //    {
        //        if (FirstIndex > LastIndex)
        //        {
        //            if (index > FirstIndex && index < LastIndex)
        //            {
        //                mas[index - LastIndex] = value;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Выход за границы массива");
        //            }
        //        }
        //        else
        //        {
        //            if (index > FirstIndex && index < LastIndex)
        //            {
        //                mas[index - FirstIndex] = value;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Выход за границы массива");
        //            }
        //        }
        //    }
        //}

        public void Show()
        {
            for(int i = FirstIndex;i<LastIndex;i++)
            {
                Console.Write("{0}\t", mas[i]);
            }
        }
    }
}
