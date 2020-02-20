using System;

namespace BC.Sorting.Sorts
{
    public class MergeSort<T> : IArraySort<T> where T : IComparable<T>
    {
        public MergeSort(ISortHelper<T> sortHelper)
        {
            SortHelper = sortHelper;
        }

        private ISortHelper<T> SortHelper { get; }

        public void Sort(T[] array)
        {
            SplitRange(ref array, 0, array.Length);
        }

        public void MergeSortedRanges(ref T[] array, int left, int mid, int right)
        {
            T[] copy = new T[array.Length];
            // right is exclusive
            var a = left;
            var b = mid;
            var populateIndex = left;
            while (populateIndex < right)
            {
                if (a >= mid)
                {
                    while (b < right)
                    {
                        SortHelper.Write(ref copy, populateIndex++, array[b++]);
                    }
                }
                else if (b >= right)
                {
                    while (a < mid)
                    {
                        SortHelper.Write(ref copy, populateIndex++, array[a++]);
                    }
                }
                else
                {
                    SortHelper.Write(ref copy, populateIndex++, SortHelper.Compare(array, a, b) <= 0 ? array[a++] : array[b++]);
                }
            }

            // copy to original array
            for (int i = left; i < right; i++)
            {
                SortHelper.Write(ref array, i, copy[i]);
            }
        }

        public void SplitRange(ref T[] array, int left, int right)
        {
            if (right - left < 2) return;
            var mid = (right + left) / 2;
            // Console.WriteLine($"Spliting on {left}, {mid}");
            SplitRange(ref array, left, mid);
            // Console.WriteLine($"Spliting on {mid}, {right}");
            SplitRange(ref array, mid, right);
            MergeSortedRanges(ref array, left, mid, right);
        }
    }
}