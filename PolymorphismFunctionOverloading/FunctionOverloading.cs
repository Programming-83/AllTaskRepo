using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismFunctionOverloading
{
    class Area
    {
        public void rectangle() //   Fuction overloading 
        {
            Console.WriteLine("No Parameter");
        }
        public void rectangle(int a) // Function Overloading
        {
            Console.WriteLine("--------------------------------");
            int sq = a * a;
            Console.WriteLine($"Squer = {sq}");
            Console.WriteLine("One Parameter Parameter");
        }
        public void rectangle(int l, int b) // Function Overloading
        {
            Console.WriteLine("--------------------------------");
            int ar=l*b;
            Console.WriteLine($"Area = {ar}");
            Console.WriteLine("Two  Parameter");
        }
    }
    class FunctionOverloading
    {
        static void Main(string[] args)
        {
            Area are = new Area();
            are.rectangle();
            are.rectangle(5);
            are.rectangle(10,20);
            Console.ReadLine();
        }
    }
}
