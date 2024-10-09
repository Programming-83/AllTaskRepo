using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMixedSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9,10
            };
            // Step2: Query
            var MixSyntax = ( from obj in integerList
                              where obj>5
                              select obj).Sum();
            Console.WriteLine("Sum is = "+MixSyntax);
            Console.ReadLine();
        }
    }
}
