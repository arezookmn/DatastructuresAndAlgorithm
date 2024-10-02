namespace Algorithms.Sorters.Comparision;
public interface IComparisionSorter<T>
{
    void Sort(T[] array, IComparer<T> comparer);
}

