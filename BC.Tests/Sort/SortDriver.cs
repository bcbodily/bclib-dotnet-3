using System;
using Xunit;

namespace BC.Sort
{
    public class SortDriver
    {

        [Fact]
        public void BubbleSortTest()
        {
            var sortHelper = new Sorting<int>();
            var sort = new BubbleSort<int>(sortHelper);

            var array = GetTestArray();
            sort.Sort(array);

            bool expected = true;
            bool actual = IsSorted(array);

            Assert.Equal(expected, actual);
            sortHelper.Summarize("Bubble Sort");
        }

        [Fact]
        public void QuickSortTest()
        {
            var sortHelper = new Sorting<int>();
            var sort = new QuickSort<int>(sortHelper);

            var array = GetTestArray();
            sort.Sort(array);

            bool expected = true;
            bool actual = IsSorted(array);

            Assert.Equal(expected, actual);
            sortHelper.Summarize("QuickSort");
        }

        private void ShowArray(int[] array) {
            var output = "";
            for (int i=0; i < array.Length; i++) {
                output += $"{array[i]}, ";
            }

            Console.WriteLine(output);
        }



        private int[] GetTestArray()
        {
            Random rand = new Random(0);
            int size = 10;
            var array = new int[size];
            var start = 10;

            for (int i = 0; i < size; i++)
            {
                // array[i] = rand.Next(10, 100);
                array[i] = start++;
            }

            return array;
        }

        private bool IsSorted(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                    return false;
            }
            return true;
        }
    }
}