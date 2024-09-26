using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritance
{

    class Prent
    {
        public int c;
        public int sum(int a, int b)
        {
            c = a + b;
            return c;
        }
    }
    class Child : Prent
    {
        int m;
        public int Multy(int d)
        {
            m = c * d;
            return m;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child ch = new Child();
            int sm = ch.sum(10, 20);
            Console.WriteLine($"Sum = {sm}");
            int mul = ch.Multy(10);
            Console.WriteLine($"Multyply = {mul}");
            Console.ReadLine();
        }
    }
}
