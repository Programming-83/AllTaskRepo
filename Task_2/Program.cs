using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class operation
    {
        public int calculate(params int[] a)
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                s += a[i];
            }
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            operation op = new operation();
            int res = op.calculate(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            int avg = res / 10;
            Console.WriteLine("Sum =" + res);
            Console.WriteLine("Average=" + avg);
            Console.ReadLine();
        }
    }
}
