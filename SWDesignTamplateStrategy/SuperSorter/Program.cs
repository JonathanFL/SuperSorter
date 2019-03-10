using System;
using SuperSorter.Generating;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SuperSorter.Factories;
using SuperSorter.Factories.GeneratingFactory;
using SuperSorter.Factories.SortingFactory;
using SuperSorter.Sortings;

namespace SuperSorter
{
    class Program
    {
        static void Main(string[] args)
        {

            SortingControl sortingControl = new ConcreteQuickSortFactory();
            GeneratingControl generatingControl = new ArrayGeneratorFactory();

            var unsortedArray = generatingControl.GetObject().GenerateArray();
            
            PrintList(unsortedArray);

            var watch = Stopwatch.StartNew();
            sortingControl.GetObject().Sort(unsortedArray);
            watch.Stop();

            PrintList(unsortedArray);
            Console.WriteLine("algorithm execution time: {0}ms", watch.ElapsedMilliseconds);
            

            Console.ReadLine();
        }

        private static void PrintList(int[] array)
        {
            Console.WriteLine("Array:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine("");
        }
    }
}
