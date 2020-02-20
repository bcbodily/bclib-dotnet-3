using System;
using System.Text;

namespace BC.Sorting.SortHelpers
{
    /// <summary>
    /// Utility struct that describes a left, middle, and right separator string
    /// </summary>
    public struct Separators
    {
        public static Separators Range => new Separators("[", "|", "]");
        public static Separators Blank => new Separators(" ", " ", " ");
        public string Left { get; }
        public string Mid { get; }
        public string Right { get; }

        public Separators(string left, string mid, string right)
        {
            this.Left = left;
            this.Mid = mid;
            this.Right = right;
        }
    }


    /// <summary>
    /// A <see cref="ISortHelper"/> that provides some instrumentation
    /// </summary>
    /// <typeparam name="T">the type of elements this sort helper works with</typeparam>
    public class InstrumentedSortHelper<T> : ISortHelper<T> where T : IComparable<T>
    {

        /// <summary>
        /// Creates a new instance of <see cref="InstrumentedSortHelper"/> with a specified underlying <see cref="ISortHelper"/>
        /// </summary>
        /// <param name="sortHelper">the underlying sort helper that will perform the actual operations</param>
        public InstrumentedSortHelper(ISortHelper<T> sortHelper)
        {
            SortHelper = sortHelper;
        }

        private ISortHelper<T> SortHelper { get; }

        public int CompareCount { get; private set; } = 0;

        public bool OutputOn { get; set; } = false;

        public int SwapCount { get; private set; } = 0;

        public int WriteCount {get;private set; } = 0;

        public int Compare(T[] array, int left, int right)
        {
            CompareCount++;
            if (OutputOn)
                Console.WriteLine($"Compare #{CompareCount}: Comparing elements #{left} and #{right}");
            var leftVsRight = SortHelper.Compare(array, left, right);
            ShowRange(array, 0, array.Length - 1, GetRangeRenderer(left, right));
            ShowRange(array, 0, array.Length - 1, GetCompareRenderer(left, right, leftVsRight), Separators.Blank);

            return leftVsRight;
        }


        public void Summarize(string title)
        {
            Console.WriteLine(title);
            Console.WriteLine($"Compares/Swaps/Writes: {CompareCount} / {SwapCount} / {WriteCount}");
            Console.WriteLine();
        }

        public void Swap(ref T[] array, int left, int right)
        {
            SwapCount++;
            if (OutputOn) Console.WriteLine($"Swap #{SwapCount}: Swapping elements #{left} and #{right}");

            // display pre-change
            ShowRange(array, 0, array.Length - 1, GetRangeRenderer(left, right));

            // make the change
            SortHelper.Swap(ref array, left, right);

            // show post-change
            ShowRange(array, 0, array.Length - 1, GetSwapRenderer(left, right), Separators.Blank);
            ShowRange(array, 0, array.Length - 1, GetRangeRenderer(left, right));
            ShowRange(array, 0, array.Length - 1, WriteElement);
        }


        public void Write(ref T[] array, int index, T value)
        {
            WriteCount++;
            if (OutputOn) Console.WriteLine($"Write #{WriteCount}: Writing to element {index}");

            // make the change
            SortHelper.Write(ref array, index, value);

            // show post-change
            // ShowRange(array, 0, array.Length - 1, GetSwapRenderer(left, right), Separators.Blank);
            ShowRange(array, 0, array.Length - 1, GetRangeRenderer(index, index));
            ShowRange(array, 0, array.Length - 1, WriteElement);
        }

        private static Func<(T, int), string> GetCompareRenderer(int leftIndex, int rightIndex, int leftVsRight)
        {
            char leftChar = leftVsRight < 0 ? '-' : '+';
            char rightChar = leftVsRight > 0 ? '-' : '+';
            if (leftVsRight == 0)
            {
                leftChar = '=';
                rightChar = '=';
            }
            Func<(T, int), string> renderer = delegate ((T value, int index) input)
            {
                var index = input.index;
                var value = input.value.ToString();

                if (index == leftIndex)
                    return ReplaceChars(value, leftChar);

                if (index == rightIndex)
                    return ReplaceChars(value, rightChar);

                return ReplaceChars(value, ' ');
            };

            return renderer;
        }

        private static Func<(T, int), string> GetRangeRenderer(int leftIndex, int rightIndex)
        {
            Func<(T, int), string> renderer = delegate ((T value, int index) input)
            {
                var index = input.index;
                var value = input.value.ToString();

                if (index == leftIndex || index == rightIndex)
                    return value;

                return ReplaceChars(value, ' ');
            };

            return renderer;
        }

        private static Func<(T, int), string> GetSwapRenderer(int leftIndex, int rightIndex)
        {
            Func<(T, int), string> renderer = delegate ((T value, int index) input)
            {
                var index = input.index;
                var value = input.value.ToString();

                if (index == leftIndex)
                    return ReplaceChars(value, '>');

                if (index == rightIndex)
                    return ReplaceChars(value, '<');

                if (index > leftIndex && index < rightIndex)
                    return ReplaceChars(value, '-');

                return ReplaceChars(value, ' ');
            };

            return renderer;
        }

        public void ShowRange(T[] array, int left, int right, Func<(T, int), string> renderer) =>
            ShowRange(array, left, right, renderer, Separators.Range);

        public void ShowRange(T[] array, int left, int right, Func<(T, int), string> renderer, Separators separators)
        {
            var builder = new StringBuilder();
            // elements
            builder.Append(separators.Left);
            for (int i = left; i <= right; i++)
            {
                builder.Append($" {renderer((array[i], i))} ");
                builder.Append(i < right ? separators.Mid : separators.Right);
            }
            if (OutputOn) Console.WriteLine(builder.ToString());
        }

        public static string WriteElement((T value, int index) input) => input.value.ToString();

        public static string ReplaceChars(string input, char replacement)
        {
            var output = "";

            foreach (var character in input)
                output += replacement;

            return output;
        }

    }
}