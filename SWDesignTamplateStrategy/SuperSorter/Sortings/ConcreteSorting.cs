using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSorter.Sortings
{
    class ConcreteSorting
    {
        private ISorting _sorting;

        public ConcreteSorting(ISorting sorting)
        {
            _sorting = sorting;
        }

        public void Sort(int[] list)
        {
            _sorting.Sort(list);
        }

        public void SetSorting(ISorting sortingMethod)
        {
            _sorting = sortingMethod;
        }
    }
}
