using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_push_pop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> str = new Queue<string>();
            str.Enqueue("H");
            str.Enqueue("e");
            str.Enqueue("l");
            str.Enqueue("l");
            str.Enqueue("o");
            Console.WriteLine(str.Peek());
            Console.WriteLine("Total elements: {0}",str.Count);

            str.Dequeue();
            Console.WriteLine("Total elements: {0}", str.Count);
            if (str.Count > 0)
            {
                 
                Console.WriteLine(str.Peek()); 
            }

            Console.WriteLine("Total elements: {0}", str.Count);
        }
    }
}
