using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue qu = new Queue();
            qu.Enqueue(1);
            qu.Enqueue(2);
            qu.Enqueue(3);
            qu.Enqueue(4);
            qu.Enqueue(5);
            qu.Dequeue(); // This is Delted 1 becaust it followed FIFO (First in Frist Out)
            foreach (object Qu in qu)
            {
                Console.WriteLine(Qu);
            }
            Console.ReadLine();
        }
    }
}
