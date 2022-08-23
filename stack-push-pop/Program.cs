using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_push_pop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            Console.Write("Number of elements in Stack: {0}\n", myStack.Count);

            while (myStack.Count > 2)
                Console.Write(myStack.Pop() + ",");

            Console.Write("Number of elements in Stack: {0}\n", myStack.Count);
        }
    }
}
