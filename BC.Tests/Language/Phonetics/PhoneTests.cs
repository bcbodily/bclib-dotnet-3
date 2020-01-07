using Xunit;

namespace BC.Language.Phonetics
{
    /// <summary>
    /// Units tests for Phone
    /// </summary>
    public class PhoneTests
    {
        /// <summary>
        /// Verifies Symbol returns the symbol specified in the constructor
        /// </summary>
        /// /// <param name="symbol">the symbol argument to pass to the constructor</param>
        [Theory]
        [InlineData("a")]
        [InlineData("")]
        [InlineData("123")]
        public void Symbol_is_specified_symbol(string symbol)
        {
            var expected = symbol;
            var actual = new Phone(symbol: symbol).Symbol;

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies Phone.Equals(Object) properly returns false when the other object is not a Phone
        /// </summary>
        /// <param name="symbol">the symbol to initialize the test Phone instance with</param>
        [Theory]
        [InlineData("a")]
        [InlineData("")]
        [InlineData("123")]
        public void Equals_other_isNot_Phone_returns_false(string symbol)
        {
            var other = new object();
            var instance = new Phone(symbol: symbol);

            Assert.IsNotType<Phone>(other);

            var expected = false;
            var actual = instance.Equals(other);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies Phone.Equals(Object) properly returns false when the other object is a Phone that is not equal to the instance
        /// </summary>
        /// <param name="symbol">the symbol to initialize the test Phone instance with</param>
        [Theory]
        [InlineData("a", "b")]
        [InlineData("", "b")]
        [InlineData("a", "")]
        public void Equals_other_is_Phone_with_different_symbol_returns_false(string symbol1, string symbol2)
        {
            object other = new Phone(symbol: symbol2);
            var instance = new Phone(symbol: symbol1);

            Assert.True(other is Phone otherPhone && !otherPhone.Symbol.Equals(instance.Symbol));

            var expected = false;
            var actual = instance.Equals(other);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies Phone.Equals(Object) properly returns true when the other object is a Phone that is equal to the instance
        /// </summary>
        /// <param name="symbol">the symbol to initialize the test Phone instance with</param>
        [Theory]
        [InlineData("a")]
        [InlineData("")]
        public void Equals_other_is_Phone_with_equal_symbol_returns_true(string symbol)
        {
            object other = new Phone(symbol: symbol);
            var instance = new Phone(symbol: symbol);

            Assert.True(other is Phone otherPhone && instance.Symbol.Equals(otherPhone.Symbol));

            var expected = true;
            var actual = instance.Equals(other);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies Phone.GetHashCode() properly returns a consistent hash code for equivalent Phones
        /// </summary>
        /// <param name="symbol">the symbol to initialize the test Phone instances with</param>
        [Theory]
        [InlineData("a")]
        [InlineData("")]
        [InlineData("b")]
        public void GetHashCode_returns_consistent_hashcode(string symbol)
        {
            var instance1 = new Phone(symbol: symbol);
            var instance2 = new Phone(symbol: symbol);

            Assert.Equal(instance1, instance2);
            Assert.Equal(instance1.GetHashCode(), instance2.GetHashCode());
        }

        /// <summary>
        /// Verifies Phone.ToString() properly returns a string containing the specified symbol, surrounded by square brackets
        /// </summary>
        /// <param name="symbol">the symbol to initialize the test Phone instance with</param>
        [Theory]
        [InlineData("a")]
        [InlineData("")]
        [InlineData("b")]
        public void ToString_returns_symbol_surrounded_with_square_brackets(string symbol)
        {
            var expected = $"[{symbol}]";
            var actual = new Phone(symbol: symbol).ToString();

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies Phone.CompareTo(Phone) properly returns the value that is returned by string.CompareTo(string) for the Phone instances being compared
        /// </summary>
        /// <param name="symbol1">the symbol to initialize the first test Phone instance with</param>
        /// <param name="symbol2">the symbol to initialize the second test Phone instance with</param>
        [Theory]
        [InlineData("a", "b")]
        [InlineData("b", "a")]
        [InlineData("a", "a")]
        public void CompareTo_returns_CompareTo_of_Symbol_values(string symbol1, string symbol2)
        {
            var instance1 = new Phone(symbol: symbol1);
            var instance2 = new Phone(symbol: symbol2);

            var expected = instance1.Symbol.CompareTo(instance2.Symbol);
            var actual = instance1.CompareTo(instance2);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies the == operator properly returns false when both Phone instances are not equal to one another
        /// </summary>
        /// <param name="symbol1">the symbol to initialize the first test Phone instance with</param>
        /// <param name="symbol2">the symbol to initialize the first test Phone instance with</param>
        [Theory]
        [InlineData("a", "")]
        [InlineData("", "a")]
        public void OperatorEquality_Phones_are_notEqual_returns_false(string symbol1, string symbol2)
        {
            var instance1 = new Phone(symbol: symbol1);
            var instance2 = new Phone(symbol: symbol2);

            Assert.False(instance1.Equals(instance2));

            var expected = false;
            var actual = instance1 == instance2;

            Assert.Equal(actual, expected);
        }

        /// <summary>
        /// Verifies the == operator properly returns true when both Phone instances are equal to one another
        /// </summary>
        /// <param name="symbol">the symbol to initialize the test Phone instances with</param>
        [Theory]
        [InlineData("a")]
        [InlineData("")]
        public void OperatorEquality_Phones_are_equal_returns_true(string symbol)
        {
            var instance1 = new Phone(symbol: symbol);
            var instance2 = new Phone(symbol: symbol);

            Assert.True(instance1.Equals(instance2));

            var expected = true;
            var actual = instance1 == instance2;

            Assert.Equal(actual, expected);
        }

        /// <summary>
        /// Verifies the != operator properly returns true when both Phone instances are not equal to one another
        /// </summary>
        /// <param name="symbol1">the symbol to initialize the first test Phone instance with</param>
        /// <param name="symbol2">the symbol to initialize the first test Phone instance with</param>
        [Theory]
        [InlineData("a", "")]
        [InlineData("", "a")]
        public void OperatorInequality_Phones_are_notEqual_returns_true(string symbol1, string symbol2)
        {
            var instance1 = new Phone(symbol: symbol1);
            var instance2 = new Phone(symbol: symbol2);

            Assert.False(instance1.Equals(instance2));

            var expected = true;
            var actual = instance1 != instance2;

            Assert.Equal(actual, expected);
        }

        /// <summary>
        /// Verifies the != operator properly returns false when both Phone instances are equal to one another
        /// </summary>
        /// <param name="symbol">the symbol to initialize the test Phone instances with</param>
        [Theory]
        [InlineData("a")]
        [InlineData("")]
        public void OperatorInequality_Phones_are_equal_returns_false(string symbol)
        {
            var instance1 = new Phone(symbol: symbol);
            var instance2 = new Phone(symbol: symbol);

            Assert.True(instance1.Equals(instance2));

            var expected = false;
            var actual = instance1 != instance2;

            Assert.Equal(actual, expected);
        }

    }
}