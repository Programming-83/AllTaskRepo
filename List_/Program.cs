using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lt=new List<int>();
            lt.Add(1);
            lt.Add(2);
            lt.Add(3);
            lt.Add(4);
            foreach(int i in lt)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
