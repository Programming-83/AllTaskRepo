using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is Pust Follow the Principal of LIFO (Last in Frist Out)
            Stack st = new Stack();
            st.Push(5);
            st.Push(4);
            st.Push(3);
            st.Push(2);
            //st.Pop(); // This is Deleted 2
            st.Push(1);
            st.Pop(); // this is Deleted 1
            st.Pop(); // this is deleted 2
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
         // 
        }
    }
}
