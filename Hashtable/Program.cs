using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht= new Hashtable();
            ht.Add("Abhishek", "Apple");
            ht.Add(2, "Gapes");
            ht.Add(3, "Banana");
            ht.Add(4, "Mango");
            foreach(DictionaryEntry dt in ht)
            {
                Console.WriteLine(dt.Key+":"+ dt.Value);
            }
            Console.ReadLine(); 
            // Key and Value ke liye ham DictionaryEntry ka use krte hai
        }
    }
}
