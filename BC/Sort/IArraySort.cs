using System;

namespace BC.Sort
{
    public interface IArraySort<T> where T : IComparable<T>
    {
        public void Sort(T[] array);
    }
}