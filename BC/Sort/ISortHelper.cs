using System;

namespace BC.Sort
{
    public interface ISortHelper<T> where T : IComparable<T>
    {
        public int Compare(T[] array, int left, int right);

        public void Swap(ref T[] array, int left, int right);
    }
}