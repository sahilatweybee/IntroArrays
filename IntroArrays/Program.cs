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
            //foreach(Object el in args)
            //{
            //    Console.WriteLine(el);
            //}

            Program program = new Program();
            int[] arr1 = new int[] { 5, 6, 9 };
            int[,] arr2 = new int[3, 3]; // Multidimentional Array
            int[] arr3 = new int[3]{ 8, 9, 1 };

            int[][] arr4 = new int[3][]; // Jagged Array Treated as normal 1D array
            arr4[0] = new int[3] { 3, 9, 6 };
            arr4[1] = new int[6] { 2, 5, 8, 6, 7, 4 };
            arr4[2] = new int[4] { 7, 4, 1, 0 };

            Console.WriteLine(arr4[0][1]);
            program.Show(2, 4, 6, 8, 10, 12, 14, 1, 5);
            program.ShowArray(arr1, arr2);
            
            IList<int> arr5 = Array.AsReadOnly(arr1);
            Console.WriteLine(arr5.IsReadOnly);

            Console.WriteLine(arr3.IsFixedSize);
            Console.WriteLine(arr3.IsSynchronized);
            Console.WriteLine(arr2.Rank);
            Console.WriteLine(arr2.LongLength);
            Console.WriteLine(Array.IndexOf(arr1, 9));

            Console.ReadLine();
        }

        public void ShowArray(int[] arr1, int[,] arr2)
        {
            
            for (int i = 0; i < 3; i++)
            {
                // Console.WriteLine($"{arr1[i]}, {arr2[i]}");
                for (int j=0; j < 3; j++)
                {
                    arr2[i, j] = arr1[j];
                    Console.Write($"{arr2[i,j]}  ");
                }
                Console.WriteLine(" ");
            }
        }

        public void Show(params int[] val) // Params Paramater  
        {
            Array.Sort(val);
            Array.Reverse(val);
            foreach (var i in val)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine(" ");
        }
    }
}
