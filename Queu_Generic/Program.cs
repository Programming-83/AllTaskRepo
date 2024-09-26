using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queu_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  FIFO ( First in Last Out)
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Dequeue(); // 1 Deleted ho jayega kyo ki pahle 1 entery kiye aur out bhi 1 ho rah hai 
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
