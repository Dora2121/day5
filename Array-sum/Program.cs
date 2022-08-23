using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n,sum=0;

            int[] a = new int[100];
            

            Console.Write("Enter the number of elements to store in the array :");
            n = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input {0} number of elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe values store into the array are : \n");
            for (i = 0; i < n; i++) 
            {
                Console.Write("{0}  ", a[i]);
            }

            
            for ( i = 0; i < n; i++)
            {
                sum += a[i];
            }
            Console.Write("\n\nThe Sum of an Array:{0}\n",sum);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
