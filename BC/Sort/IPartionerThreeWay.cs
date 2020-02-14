using System;

namespace BC.Sort
{
    public interface IPartionerThreeWay<T> where T : IComparable<T>
    {
        (int left, int right) Partition(ref T[] array, int left, int right);
    }
}