using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMethodeSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };
            // Step2: Query
            var QuerySyntax = integerList.Where(obj => obj>5).ToList();
            // step3: Execution
            foreach (var item in integerList)
            {
                Console.WriteLine(item +" ");
            }
            Console.ReadLine();

        }
    }
}
