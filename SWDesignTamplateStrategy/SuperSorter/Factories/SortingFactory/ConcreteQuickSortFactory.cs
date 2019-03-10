using SuperSorter.Sortings;

namespace SuperSorter.Factories.SortingFactory
{
    public class ConcreteQuickSortFactory : SortingControl
    {
        public override ISorting Sorting()
        {
            ISorting sorting = new QuickSort();
            return sorting;
        }
    }
}
