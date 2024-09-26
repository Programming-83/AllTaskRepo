using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Employee<T>
    {
       
        T a;
        public Employee(T a)
        {
            this.a = a;
        }
        public void dispaly()
        {
            Console.WriteLine(this.a); 
        }
        public void printTable()
        {
           if(a is double)
            {
                int b = (int)(object)a;
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine(b*i);
                }
                Console.ReadLine();
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee<int> emp = new Employee<int>(12);
            Employee<string> emp1 = new Employee<string>("Abhishek");
            emp.dispaly();
            emp1.dispaly();
            emp.printTable();  // Will print the table of 12
            emp1.printTable(); // Will show that it can't print table for string
            Console.ReadLine();
        }
    }
}
