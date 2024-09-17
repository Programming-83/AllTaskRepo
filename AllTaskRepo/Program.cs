using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTaskRepo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("First no");
            a=Convert.ToInt32(Console.ReadLine());
            int b;
            Console.WriteLine("second no");
                b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum="+ (a+b));
            Console.ReadLine();
        }
    }
}
