using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortirovka
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masiv = UniqueRandomArray(-100, 100, 10);
            Bubble_Sort(masiv);
            var a = UniqueRandomArray(-100, 100, 10);

            ArrayToString(a);

            Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", QuickSort(a)));

            Console.ReadLine();
        }

        public static void Bubble_Sort(int[] anArray)
        {
            PrintArray(anArray);

            for (int i = 0; i < anArray.Length; i++)
            {
                for (int j = 0; j < anArray.Length - 1 - i; j++)
                {
                    if (anArray[j] > anArray[j + 1])
                    {
                        Swap(ref anArray[j], ref anArray[j + 1]);
                    }
                }
            }
        }
    }
}