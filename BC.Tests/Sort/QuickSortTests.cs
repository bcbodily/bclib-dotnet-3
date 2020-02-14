using System;
using Xunit;


namespace BC.Sort
{
    public class QuickSortTests
    {
        [Fact]
        public void partion_leftside_is_lessthan_or_equal_to_pivot()
        {
            var array = getTestArray();

            var sorter = new QuickSort<int>(new Sorting<int>());

            var pivotIndex = sorter.partition(ref array, 0, array.Length - 1);

            foreach (var item in array)
            {
                Console.Write($"{item},");
            }
            Console.WriteLine();

            for (int i = 0; i < pivotIndex; i++)
            {
                Assert.True(array[i] <= array[pivotIndex], $"index: {i} ({array[i]}) not <= pivot: {pivotIndex} ({array[pivotIndex]}");
            }

            for (int i = pivotIndex + 1; i < array.Length; i++)
            {
                Assert.True(array[i] >= array[pivotIndex], $"index: {i} ({array[i]}) not >= pivot: {pivotIndex} ({array[pivotIndex]}");
            }
        }


        public int[] getTestArray()
        {
            Random rand = new Random(0);
            int size = 10;
            var array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(10, 100);
            }

            return array;
        }
    }
}