using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 3, 5, 8, 2, 9, 4, 15, 6 };

            int [] sortedArray = inserSort(array);


        }

        static int[] inserSort(int[] input)
        {
            for (int i = 0; i < 4 - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (input[j - 1] > input[j])
                    {
                        int temp = input[j - 1];
                        input[j - 1] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;
        }



    }
}
