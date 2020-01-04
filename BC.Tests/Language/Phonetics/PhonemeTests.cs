using System.Collections.Generic;
using Xunit;

namespace BC.Language.Phonetics
{
    public class PhonemeTests
    {
        /// <summary>
        /// Verifies Phoneme.Phones properly returns a list of Phones that is equal to the Phones specified in the constructor
        /// </summary>
        /// <param name="symbols">symbols to use to create Phones to specify in the constructor</param>
        [Theory]
        [InlineData("a", "b", "c")]
        [InlineData("c", "b", "a")]
        [InlineData("")]
        public void Phones_is_equalTo_specified_phones(params string[] symbols)
        {
            string symbol = "Phoneme";
            Phone[] phones = new Phone[symbols.Length];
            for (int i = 0; i < symbols.Length; i++)
            {
                phones[i] = new Phone(symbols[i]);
            }
            var phonesList = new List<Phone>();
            foreach (Phone phone in phones)
            {
                phonesList.Add(phone);
            }

            var instance = new Phoneme(symbol: symbol, phones: phones);

            var expected = phonesList;
            var actual = instance.Phones;

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies Symbol returns the symbol specified in the constructor
        /// </summary>
        /// <param name="symbol">the symbol argument to pass to the constructor</param>
        [Theory]
        [InlineData("a")]
        [InlineData("")]
        [InlineData("123")]
        public void Symbol_is_specified_symbol(string symbol)
        {
            var expected = symbol;
            var actual = new Phoneme(symbol: symbol).Symbol;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("a")]
        [InlineData("")]
        [InlineData("123")]
        public void EqualityOperator_Phonemes_are_equal_returns_true(string symbol)
        {
            var lhs = new Phoneme(symbol: symbol);
            var rhs = new Phoneme(symbol: symbol);

            Assert.Equal(lhs, rhs);

            var expected = true;
            var actual = lhs == rhs;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("a", "b")]
        [InlineData("", "\n")]
        [InlineData("123", "124")]
        public void InqualityOperator_Phonemes_areNot_equal_returns_true(string symbol1, string symbol2)
        {
            var lhs = new Phoneme(symbol: symbol1);
            var rhs = new Phoneme(symbol: symbol2);

            Assert.NotEqual(lhs, rhs);

            var expected = true;
            var actual = lhs != rhs;

            Assert.Equal(expected, actual);
        }
    }
}