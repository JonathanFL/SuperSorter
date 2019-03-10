using SuperSorter.Sortings;

namespace SuperSorter.Factories.SortingFactory
{
    public abstract class SortingControl
    {
        public abstract ISorting Sorting();

        public ISorting GetObject()
        {
            return this.Sorting();
        }
    }
}
