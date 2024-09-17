using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    { // WAP to Input two number and Find Sum
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter first");
            a= Convert.ToInt32(Console.ReadLine());
            int b;
            Console.WriteLine("Enter second");
            b= Convert.ToInt32(Console.ReadLine()); 
            //Console.WriteLine("sum="+(a+b));
            Console.WriteLine($"Sum = {a+b}");
            Console.ReadLine();
           
           
        }
    }
}
