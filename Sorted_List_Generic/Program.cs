using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_List_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ye only Key ko leke Sorted Krta hai na ki value ko leke
            SortedList<string,int> sl=new SortedList<string,int>();
            sl.Add("Zoro", 5);
            sl.Add("Yak", 3);
            sl.Add("Parrot", 4);
            sl.Add("Orange", 2);
            sl.Add("Apple", 1);
            foreach(KeyValuePair<string,int> s in sl)
            {
                Console.WriteLine(s.Key+":"+s.Value);
            }
            Console.ReadLine();
        }
    }
}
