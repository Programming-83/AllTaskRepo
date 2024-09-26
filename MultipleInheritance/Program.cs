using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    interface Father
    {
        int sum(int a, int b);
    }
    interface Mother
    {
        int multy(int c, int d);
    }
    class child : Father, Mother
    {
        public int sum(int a, int b) // Impliment Prent Method
        {
           return a+b;
        }
        public int multy(int c, int d) // Impliment Mother Method
        {
            return c*d;
        }


        public void test()
        {
            Console.WriteLine("Hello Test");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            child c= new child();
           int sm= c.sum(10, 20);
            Console.WriteLine($"Sum = {sm}");
            int ml= c.multy(10, 20);
            Console.WriteLine($"Multyply = {ml}");
            Console.ReadLine();
        }
    }
}
