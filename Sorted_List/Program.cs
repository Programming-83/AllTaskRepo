using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add(3, "Java");
            sl.Add(1, "C#");
            sl.Add(2, "Angular");
            sl.Add(5, "PHP");
            sl.Add(4, "JavaScript");
            foreach (DictionaryEntry dt in sl)
            {
               Console.WriteLine(dt.Key + ":" + dt.Value);
            }
                Console.ReadLine();
        }
    }
}
