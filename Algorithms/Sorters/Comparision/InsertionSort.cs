namespace Algorithms.Sorters.Comparision;
public class InsertionSort<T> : IComparisionSorter<T>
{
    public void Sort(T[] array, IComparer<T> comparer)
    {
        int n = array.Length;
        for (int i = 1; i < n; i++)
        {
            T key = array[i];
            int j = i - 1;

            while (j >= 0 && comparer.Compare(key, array[j]) < 0)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = key;
        }
    }
}