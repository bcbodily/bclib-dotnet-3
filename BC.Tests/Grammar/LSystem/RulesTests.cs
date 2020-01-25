using Xunit;

namespace BC.Grammar.LSystem
{
    /// <summary>
    /// Unit tests for Rule
    /// </summary>
    public class RulesTests
    {
        /// <summary>
        /// Verifies that Rule.Equals(Rule), when the other rule has all members equal, properly returns true
        /// </summary>
        /// <param name="predecessor">the string that will serve as the predecessor for both Rule values</param>
        /// <param name="successor">the string that will serve as the successor for both Rule values</param>
        [Theory]
        [InlineData("p", "s")]
        [InlineData("", "")]
        public void Equals_AllMembers_are_equal_return_true(string predecessor, string successor)
        {
            var lhs = new Rule(predecessor: predecessor, successor: successor);
            var rhs = new Rule(predecessor: predecessor, successor: successor);

            Assert.Equal(lhs.Predecessor, rhs.Predecessor);
            Assert.Equal(lhs.Successor, rhs.Successor);

            var expected = true;
            var actual = lhs.Equals(rhs);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies Rule.Equals(Object), when the other instance is an equal Rule, properly returns true
        /// </summary>
        /// <param name="predecessor">the string that will serve as the predecessor for both Rule values</param>
        /// <param name="successor">the string that will serve as the successor for both Rule values</param>
        [Theory]
        [InlineData("p", "s")]
        public void Equals_other_is_Rule_and_equal_returns_true(string predecessor, string successor)
        {
            var instance = new Rule(predecessor: predecessor, successor: successor);
            object other = new Rule(predecessor: predecessor, successor: successor);

            Assert.IsType<Rule>(other);
            Assert.Equal(instance, other);

            var expected = true;
            var actual = instance.Equals(other);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies Rule.Equals(Object), when the other instance is a non-equal Rule, properly returns false
        /// </summary>
        /// <param name="predecessor1">the string that will serve as the predessor for the first Rule value</param>
        /// <param name="successor1">the string that will serve as the successor for the first Rule value</param>
        /// <param name="predecessor2">the string that will serve as the predessor for the second Rule value</param>
        /// <param name="successor2">the string that will serve as the successor for the second Rule value</param>
        [Theory]
        [InlineData("a", "b", "a", "c")]
        [InlineData("", "", "", "a")]
        public void Equals_other_is_Rule_andNot_equal_returns_false(string predecessor1, string successor1, string predecessor2, string successor2)
        {
            var instance = new Rule(predecessor: predecessor1, successor: successor1);
            object other = new Rule(predecessor: predecessor2, successor: successor2);

            Assert.IsType<Rule>(other);
            Assert.NotEqual(instance, other);

            var expected = false;
            var actual = instance.Equals(other);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies Rule.Equals(Object), when the other instance is not a Rule, properly returns false
        /// </summary>
        [Fact]
        public void Equals_other_isNot_Rule_returns_false()
        {
            var instance = new Rule();
            var other = new object();

            Assert.IsNotType<Rule>(other);

            var expected = false;
            var actual = instance.Equals(other);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies Rule.Equals(Rule), when the other Rule has a predecessor that is not equal, properly returns false
        /// </summary>
        /// <param name="predecessor1">the string that will serve as the predecessor for the first Rule value</param>
        /// <param name="predecessor2">the string that will serve as the predecessor for the second Rule value</param>
        /// <param name="successor">the string that will serve as the successor for both Rule values</param>
        [Theory]
        [InlineData("p1", "p2", "")]
        [InlineData("", "p", "")]
        [InlineData("p", "", "")]
        public void Equals_Predecessors_areNot_equals_returns_false(string predecessor1, string predecessor2, string successor)
        {
            var lhs = new Rule(predecessor: predecessor1, successor: successor);
            var rhs = new Rule(predecessor: predecessor2, successor: successor);

            Assert.NotEqual(lhs.Predecessor, rhs.Predecessor);

            var expected = false;
            var actual = lhs.Equals(rhs);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies Rule.Equals(Rule), when the other Rule has a successor that is not equal, properly returns false
        /// </summary>
        /// <param name="predecessor">the string that will serve as the predecessor for both Rule values</param>
        /// <param name="successor1">the string that will serve as the successor for the first Rule value</param>
        /// <param name="successor2">the string that will serve as the successor for the second Rule values</param>
        [Theory]
        [InlineData("", "s1", "s2")]
        [InlineData("", "", "s")]
        [InlineData("", "s", "")]
        public void Equals_Successors_areNot_equals_returns_false(string predecessor, string successor1, string successor2)
        {
            var lhs = new Rule(predecessor: predecessor, successor: successor1);
            var rhs = new Rule(predecessor: predecessor, successor: successor2);

            Assert.NotEqual(lhs.Successor, rhs.Successor);

            var expected = false;
            var actual = lhs.Equals(rhs);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies the equality operator, when the operands are equal, properly returns true
        /// </summary>
        /// <param name="predecessor">the string that will serve as the predessor for both Rule values</param>
        /// <param name="successor">the string that will serve as the successor for both Rule values</param>
        [Theory]
        [InlineData("a", "b")]
        [InlineData("", "")]
        [InlineData("b", "a")]
        public void EqualityOperator_Phonemes_are_equal_returns_true(string predecessor, string successor)
        {
            var lhs = new Rule(predecessor: predecessor, successor: successor);
            var rhs = new Rule(predecessor: predecessor, successor: successor);

            Assert.Equal(lhs, rhs);

            var expected = true;
            var actual = lhs == rhs;

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies the equality operator, when the operands are not equal, properly returns false
        /// </summary>
        /// <param name="predecessor1">the string that will serve as the predessor for the first Rule value</param>
        /// <param name="successor1">the string that will serve as the successor for the first Rule value</param>
        /// <param name="predecessor2">the string that will serve as the predessor for the second Rule value</param>
        /// <param name="successor2">the string that will serve as the successor for the second Rule value</param>
        ///
        [Theory]
        [InlineData("a", "b", "a", "c")]
        [InlineData("", "", "", "a")]
        public void EqualityOperator_Phonemes_areNot_equal_returns_false(string predecessor1, string successor1, string predecessor2, string successor2)
        {
            var lhs = new Rule(predecessor: predecessor1, successor: successor1);
            var rhs = new Rule(predecessor: predecessor2, successor: successor2);

            Assert.NotEqual(lhs, rhs);

            var expected = false;
            var actual = lhs == rhs;

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies the inequality operator, when the operands are equal, properly returns false
        /// </summary>
        /// <param name="predecessor">the string that will serve as the predessor for both Rule values</param>
        /// <param name="successor">the string that will serve as the successor for both Rule values</param>
        [Theory]
        [InlineData("a", "b")]
        [InlineData("", "")]
        [InlineData("b", "a")]
        public void InequalityOperator_Phonemes_are_equal_returns_false(string predecessor, string successor)
        {
            var lhs = new Rule(predecessor: predecessor, successor: successor);
            var rhs = new Rule(predecessor: predecessor, successor: successor);

            Assert.Equal(lhs, rhs);

            var expected = false;
            var actual = lhs != rhs;

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies the inequality operator, when the operands are not equal, properly returns true
        /// </summary>
        /// <param name="predecessor1">the string that will serve as the predessor for the first Rule value</param>
        /// <param name="successor1">the string that will serve as the successor for the first Rule value</param>
        /// <param name="predecessor2">the string that will serve as the predessor for the second Rule value</param>
        /// <param name="successor2">the string that will serve as the successor for the second Rule value</param>
        ///
        [Theory]
        [InlineData("a", "b", "a", "c")]
        [InlineData("", "", "", "a")]
        public void InequalityOperator_Phonemes_areNot_equal_returns_true(string predecessor1, string successor1, string predecessor2, string successor2)
        {
            var lhs = new Rule(predecessor: predecessor1, successor: successor1);
            var rhs = new Rule(predecessor: predecessor2, successor: successor2);

            Assert.NotEqual(lhs, rhs);

            var expected = true;
            var actual = lhs != rhs;

            Assert.Equal(expected, actual);
        }

    }
}