using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 5, 6, 9 };
            int[] arr2 = new int[3];
            int[] arr3 = { 8, 9, 1 };


            for (int i=0; i<3; i++)
            {
                Console.WriteLine($"{arr1[i]}, {arr3[i]}");
            }
            Console.ReadLine();
        }
    }
}
