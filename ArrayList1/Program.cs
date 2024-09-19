using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Abhishek");
            al.Add(25);
            al.Add(DateTime.Now);
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
