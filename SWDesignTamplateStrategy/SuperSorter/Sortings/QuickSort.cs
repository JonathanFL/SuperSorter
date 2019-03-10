using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSorter.GlobalMethodForEnheritance;

namespace SuperSorter.Sortings
{
    class QuickSort : Exchanging , ISorting
    {
        private int[] Array;
        public void Sort(int[] list)
        {
            Array = list;
            IntArrayQuickSort(Array);
        }

        private void IntArrayQuickSort(int[] data, int l, int r)
        {
            int i, j;
            int x;

            i = l;
            j = r;

            x = data[(l + r) / 2]; /* find pivot item */
            while (true)
            {
                while (data[i] < x)
                    i++;
                while (x < data[j])
                    j--;
                if (i <= j)
                {
                    Exchange(data, i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (l < j)
                IntArrayQuickSort(data, l, j);
            if (i < r)
                IntArrayQuickSort(data, i, r);
        }

        public void IntArrayQuickSort(int[] data)
        {
            IntArrayQuickSort(data, 0, data.Length - 1);
        }
    }
}
