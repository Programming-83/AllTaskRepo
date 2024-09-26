using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int ,string> dic = new Dictionary<int ,string>();
            dic.Add(1, "Apple");
            dic.Add(2, "Mango");
            dic.Add(3, "Banana");
            dic.Add(4, "Papaya");
            foreach (KeyValuePair<int ,string> dt in dic)
            {
                Console.WriteLine(dt.Key+":"+dt.Value);
            }
        }
    }
}
