using System;
using BC.Sorting.Partitioners;
using BC.Sorting.SortHelpers;
using BC.Sorting.Sorts;
using Xunit;

namespace BC.Sorting
{
    public class SortDriver
    {
        private const int DEFAULT_TEST_ARRAY_SIZE = 10;

        [Fact]
        public void BubbleSortInOrderTest()
        {
            var sortHelper = new InstrumentedSortHelper<int>(new SortHelper<int>());
            var sort = new BubbleSort<int>(sortHelper);

            var array = GetTestArrayInOrder();
            sort.Sort(array);

            bool expected = true;
            bool actual = IsSorted(array);

            Assert.Equal(expected, actual);
            sortHelper.Summarize("Bubble Sort In Order");
        }

        [Fact]
        public void BubbleSortReverseTest()
        {
            var sortHelper = new InstrumentedSortHelper<int>(new SortHelper<int>());
            var sort = new BubbleSort<int>(sortHelper);

            var array = GetTestArrayReverseOrder();
            sort.Sort(array);

            bool expected = true;
            bool actual = IsSorted(array);

            Assert.Equal(expected, actual);
            sortHelper.Summarize("Bubble Sort Reverse");
        }

        [Fact]
        public void BubbleSortRandomTest()
        {
            var sortHelper = new InstrumentedSortHelper<int>(new SortHelper<int>());
            var sort = new BubbleSort<int>(sortHelper);

            var array = GetTestArrayRandomOrder();
            sort.Sort(array);

            bool expected = true;
            bool actual = IsSorted(array);

            Assert.Equal(expected, actual);
            sortHelper.Summarize("Bubble Sort Random");
        }

        [Fact]
        public void InsertionSortInOrderTest()
        {
            var sortHelper = new InstrumentedSortHelper<int>(new SortHelper<int>());
            var sort = new InsertionSort<int>(sortHelper);

            var array = GetTestArrayInOrder();
            sort.Sort(array);

            bool expected = true;
            bool actual = IsSorted(array);

            Assert.Equal(expected, actual);
            sortHelper.Summarize("Insertion Sort In Order");
        }

        [Fact]
        public void InsertionSortReverseTest()
        {
            var sortHelper = new InstrumentedSortHelper<int>(new SortHelper<int>());
            var sort = new InsertionSort<int>(sortHelper);

            var array = GetTestArrayReverseOrder();
            sort.Sort(array);

            bool expected = true;
            bool actual = IsSorted(array);

            Assert.Equal(expected, actual);
            sortHelper.Summarize("Insertion Sort Reverse");
        }

        [Fact]
        public void InsertionSortRandomTest()
        {
            var sortHelper = new InstrumentedSortHelper<int>(new SortHelper<int>());
            var sort = new InsertionSort<int>(sortHelper);

            var array = GetTestArrayRandomOrder();
            sort.Sort(array);

            bool expected = true;
            bool actual = IsSorted(array);

            Assert.Equal(expected, actual);
            sortHelper.Summarize("Insertion Sort Random");
        }


        [Fact]
        public void MergeSortInOrderTest()
        {
            var sortHelper = new InstrumentedSortHelper<int>(new SortHelper<int>());

            var sort = new MergeSort<int>(sortHelper);

            var array = GetTestArrayInOrder();
            sort.Sort(array);

            bool expected = true;
            bool actual = IsSorted(array);

            sortHelper.Summarize("MergeSort In Order");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MergeSortReverseTest()
        {
            var sortHelper = new InstrumentedSortHelper<int>(new SortHelper<int>());

            var sort = new MergeSort<int>(sortHelper);

            var array = GetTestArrayReverseOrder();
            sort.Sort(array);

            bool expected = true;
            bool actual = IsSorted(array);

            sortHelper.Summarize("MergeSort Reverse");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MergeSortRandomTest()
        {
            var sortHelper = new InstrumentedSortHelper<int>(new SortHelper<int>());

            var sort = new MergeSort<int>(sortHelper);

            var array = GetTestArrayRandomOrder();
            sort.Sort(array);

            bool expected = true;
            bool actual = IsSorted(array);

            sortHelper.Summarize("MergeSort Random");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void QuickSortInOrder()
        {
            var sortHelper = new InstrumentedSortHelper<int>(new SortHelper<int>());
            var partioner = new LomutoPartitioner<int>(sortHelper);

            var sort = new QuickSort<int>(sortHelper, partioner);

            var array = GetTestArrayInOrder();
            sort.Sort(array);

            bool expected = true;
            bool actual = IsSorted(array);

            Assert.Equal(expected, actual);
            sortHelper.Summarize("QuickSort In Order");
        }

        [Fact]
        public void QuickSortReverseTest()
        {
            var sortHelper = new InstrumentedSortHelper<int>(new SortHelper<int>());
            var partioner = new LomutoPartitioner<int>(sortHelper);

            var sort = new QuickSort<int>(sortHelper, partioner);

            var array = GetTestArrayReverseOrder();
            sort.Sort(array);

            bool expected = true;
            bool actual = IsSorted(array);

            Assert.Equal(expected, actual);
            sortHelper.Summarize("QuickSort Reverse");
        }

        [Fact]
        public void QuickSortRandomTest()
        {
            var sortHelper = new InstrumentedSortHelper<int>(new SortHelper<int>());
            var partioner = new LomutoPartitioner<int>(sortHelper);

            var sort = new QuickSort<int>(sortHelper, partioner);

            var array = GetTestArrayRandomOrder();
            sort.Sort(array);

            bool expected = true;
            bool actual = IsSorted(array);

            Assert.Equal(expected, actual);
            sortHelper.Summarize("QuickSort Random");
        }



        public static int[] GetTestArrayInOrder(int size = DEFAULT_TEST_ARRAY_SIZE)
        {
            Random rand = new Random(0);
            var array = new int[size];
            var start = 10;

            for (int i = 0; i < size; i++)
            {
                array[i] = start++;
            }

            return array;
        }

        public static int[] GetTestArrayRandomOrder(int size = DEFAULT_TEST_ARRAY_SIZE)
        {
            Random rand = new Random(0);
            var array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(10, 100);
            }

            return array;
        }

        public static int[] GetTestArrayReverseOrder(int size = DEFAULT_TEST_ARRAY_SIZE)
        {
            Random rand = new Random(0);
            var array = new int[size];
            var start = 99;

            for (int i = 0; i < size; i++)
            {
                array[i] = start--;
            }

            return array;
        }

        public static bool IsSorted(int[] array)
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