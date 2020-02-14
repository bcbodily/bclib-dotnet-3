using System;
using System.Text;

namespace BC.Sort
{
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


    public class Sorting<T> : ISortHelper<T> where T : IComparable<T>
    {
        
        public int CompareCount { get; private set; } = 0;

        public bool OutputOn {get;set;} = true;

        public int SwapCount { get; private set; } = 0;

        public int Compare(T[] array, int leftIndex, int rightIndex)
        {
            CompareCount++;
            if (OutputOn)
                Console.WriteLine($"Compare #{CompareCount}: Comparing elements #{leftIndex} and #{rightIndex}");
            var leftVsRight = array[leftIndex].CompareTo(array[rightIndex]);
            ShowRange(array, 0, array.Length - 1, GetRangeRenderer(leftIndex, rightIndex));
            ShowRange(array, 0, array.Length - 1, GetCompareRenderer(leftIndex, rightIndex, leftVsRight), Separators.Blank);

            return leftVsRight;
        }

        public void Reset()
        {
            CompareCount = 0;
            SwapCount = 0;
        }

        public void Summarize(string title)
        {
            Console.WriteLine(title);
            Console.WriteLine($"Compares/Swaps: {CompareCount} / {SwapCount}");
            Console.WriteLine();
            Console.WriteLine();
        }

        public void Swap(ref T[] array, int leftIndex, int rightIndex)
        {
            SwapCount++;
            if (OutputOn) Console.WriteLine($"Swap #{SwapCount}: Swapping elements #{leftIndex} and #{rightIndex}");

            // display pre-change
            ShowRange(array, 0, array.Length - 1, GetRangeRenderer(leftIndex, rightIndex));

            // make the change
            var temp = array[leftIndex];
            array[leftIndex] = array[rightIndex];
            array[rightIndex] = temp;


            // show post-change
            ShowRange(array, 0, array.Length - 1, GetSwapRenderer(leftIndex, rightIndex), Separators.Blank);
            ShowRange(array, 0, array.Length - 1, GetRangeRenderer(leftIndex, rightIndex));
            ShowRange(array, 0, array.Length - 1, WriteElement);

            // Console.WriteLine();
        }

        private static Func<(T, int), string> GetCompareRenderer(int leftIndex, int rightIndex, int leftVsRight)
        {
            char leftChar = leftVsRight < 0 ? '-' : '+';
            char rightChar = leftVsRight > 0 ? '-' : '+';
            if (leftVsRight == 0) {
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
                builder.Append( $" {renderer((array[i], i))} ");
                builder.Append( i < right ? separators.Mid : separators.Right);
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