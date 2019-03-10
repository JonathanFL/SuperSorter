using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSorter.GlobalMethodForEnheritance;

namespace SuperSorter.Sortings
{
    class SelectionSort : Exchanging , ISorting
    {
        public void Sort(int[] list)
        {
            IntArraySelectionSort(list);
        }

        private int IntArrayMin(int[] data, int start)
        {
            int minPos = start;
            for (int pos = start + 1; pos < data.Length; pos++)
                if (data[pos] < data[minPos])
                    minPos = pos;
            return minPos;
        }

        private void IntArraySelectionSort(int[] data)
        {
            int i;
            int N = data.Length;

            for (i = 0; i < N - 1; i++)
            {
                int k = IntArrayMin(data, i);
                if (i != k)
                    Exchange(data, i, k);
            }
        }
    }
}
