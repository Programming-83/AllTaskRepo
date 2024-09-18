using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
     class Program
    {   
        static void Main(string[] args)
        {
            List<int> lt = new List<int> { 12, 3, 54, 67, 9, 98, 4 };
         List<int>eveno= lt.FindAll(jyoti => (jyoti % 2) == 0);
            foreach (int jyoti in eveno)
            {
                Console.WriteLine(jyoti);
            }
            Console.ReadLine();
        }
    }
}
