using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LIFO (Last In Frist Out )
            Console.WriteLine("Stack");
            Stack<int> sg = new Stack<int>();
            sg.Push(1);
            sg.Push(2);
            sg.Push(3);
            sg.Push(4);
            sg.Push(5);
            sg.Pop(); // 5 ko delete kr dega kyo ki 5 last me in hua pahe out hoga is liye delete ho jayega
            foreach (int i in sg)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            Console.WriteLine("StackList");
          

        }
    }
}
