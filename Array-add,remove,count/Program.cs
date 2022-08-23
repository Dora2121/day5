using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_add_remove_count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList(10);
            var coun = 0;

            // Adding elements to ArrayList
            myList.Add("M");
            myList.Add("p");
            myList.Add("h");
            myList.Add("a");
            myList.Add("s");
            myList.Add("i");
            myList.Add("s");
            myList.Add("L");
            myList.Add("T");
            myList.Add("D");

            coun = +1; ;
            coun = myList.Count();
            // Displaying the elements in ArrayList
            Console.WriteLine("The initial ArrayList is: ");
             
            Console.WriteLine(coun);

            foreach (string str in myList)
            {
                Console.WriteLine(str);
            }

            // removing 2 elements starting from index 2
            myList.RemoveRange(7, 3);

            // Displaying the modified ArrayList
            Console.WriteLine("The ArrayList after Removing elements: ");

            // Displaying the elements in ArrayList
            foreach (string str in myList)
            {
                Console.WriteLine(str);
            }
        }
    }
}
