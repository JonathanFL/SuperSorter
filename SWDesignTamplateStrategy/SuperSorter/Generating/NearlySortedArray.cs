using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSorter.Sortings;
using SuperSorter.GlobalMethodForEnheritance;

namespace SuperSorter.Generating
{
    class NearlySortedArray : Exchanging, IArrayGenerator
    {
        private int[] Array { get; set; }

        private int _seed;
        private int _max;
        private int _size;

        public NearlySortedArray(int seed, int max, int sizeN)
        {
            _seed = seed;
            _max = max;
            _size = sizeN;
        }
        public int[] GenerateArray()
        {
            GenerateAndSortArray();

            MessUpArray(Array);

            return Array;
        }

        private void MessUpArray(int[] array)
        {
            Random randNum = new Random(_seed);
            for (int i = 0; i < Array.Length / 8; i++)
            {
                Exchange(Array, randNum.Next(0, _size), randNum.Next(0, _size));
            }
        }

        private void GenerateAndSortArray()
        {
            ConcreteArrayClass c = new ConcreteArrayClass(new ArrayGenerator(_seed,_max,_size));
            Array = c.GenerateArray();
            ConcreteSorting sorting = new ConcreteSorting(new QuickSort());
            sorting.Sort(Array);
        }

        
    }
}
