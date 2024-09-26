using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    abstract class Employee
    {
        abstract public int sum(int a, int b);
        abstract public int multiply(int c, int d);
    }
    class ABC : Employee // Inherit abstract Clas
    {
        public override int sum(int a, int b)  // Implimentetion abstract methode
        {
           return a + b;
        }
        public override int multiply(int c, int d) // Implimentetion abstract methode
        {
           return c * d;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            ABC a = new ABC();
            int sum=  a.sum(100, 200);
            Console.WriteLine($"Sum = {sum}");
            int multyp= a.multiply(100, 200);
            Console.WriteLine($"Multyply = {multyp}");
            Console.ReadLine();
        }
    }
}
