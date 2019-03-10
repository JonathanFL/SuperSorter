using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSorter.Sortings;

namespace SuperSorter.Generating
{
    class ReverseOrderedArray : IArrayGenerator
    {
        private int[] Array { get; set; }

        private int _seed;
        private int _max;
        private int _size;

        public ReverseOrderedArray(int seed, int max, int sizeN)
        {
            _seed = seed;
            _max = max;
            _size = sizeN;
        }

        public int[] GenerateArray()
        {
            GenerateAndSortArray();
            ReverseArray(Array);
            return Array;
        }

        private void GenerateAndSortArray()
        {
            ConcreteArrayClass c = new ConcreteArrayClass(new ArrayGenerator(_seed, _max, _size));
            Array = c.GenerateArray();
            ConcreteSorting sorting = new ConcreteSorting(new QuickSort());
            sorting.Sort(Array);
        }

        private void ReverseArray(int[] list)
        {
            for (int i = 0; i < list.Length / 2; i++)
            {
                int tmp = list[i];
                list[i] = list[list.Length - i - 1];
                list[list.Length - i - 1] = tmp;
            }
        }
    }
}
