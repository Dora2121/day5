using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable my_hashtable1 = new Hashtable();

            
            my_hashtable1.Add("A1", "Welcome");
            my_hashtable1.Add("A2", "to");
            my_hashtable1.Add("A3", "mphasis");

            Console.WriteLine("Key and Value pairs from my_hashtable:");

            foreach (DictionaryEntry ele1 in my_hashtable1)
            {
                Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
            }
            my_hashtable1.Remove("A3");
            Console.WriteLine("Key and Value pairs from my_hashtable:");
            foreach (DictionaryEntry ele1 in my_hashtable1)
            {
                Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
            }


        }
    }
}
