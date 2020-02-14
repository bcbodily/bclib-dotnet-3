using System;

namespace BC.Sort
{
    public interface IPartionerTwoWay<T> where T : IComparable<T>
    {
        int Partition(ref T[] array, int left, int right);
    }
}