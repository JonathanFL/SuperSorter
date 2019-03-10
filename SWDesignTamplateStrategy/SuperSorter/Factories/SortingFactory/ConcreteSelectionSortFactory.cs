using System;
using SuperSorter.Generating;
using SuperSorter.Sortings;

namespace SuperSorter.Factories.SortingFactory
{
    public class ConcreteSelectionSortFactory : SortingControl
    {
        public override ISorting Sorting()
        {
            ISorting sorting = new SelectionSort();
            return sorting;
        }
    }
}
