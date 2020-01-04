using Xunit;

namespace BC.Language.Phonetics
{
    public class VowelTests
    {
        /// <summary>
        /// Verifies Backness returns the backness specified in the constructor
        /// </summary>
        /// <param name="backness">The backness that will be tested with</param>
        [Theory]
        [InlineData(VowelBacknesses.Back)]
        [InlineData(VowelBacknesses.Central)]
        [InlineData(VowelBacknesses.Front)]
        [InlineData(VowelBacknesses.NearBack)]
        [InlineData(VowelBacknesses.NearFront)]
        public void Backness_is_specified_backness(VowelBacknesses backness)
        {
            VowelHeights height = VowelHeights.Close;
            VowelRoundednesses roundedness = VowelRoundednesses.Rounded;

            var expected = backness;
            var actual = new Vowel(roundedness: roundedness, backness: backness, height: height).Backness;

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies Height returns the height specified in the constructor
        /// </summary>
        /// <param name="height">The height that will be tested with</param>
        [Theory]
        [InlineData(VowelHeights.Close)]
        [InlineData(VowelHeights.CloseMid)]
        [InlineData(VowelHeights.Mid)]
        [InlineData(VowelHeights.NearClose)]
        [InlineData(VowelHeights.NearOpen)]
        [InlineData(VowelHeights.Open)]
        [InlineData(VowelHeights.OpenMid)]
        public void Height_is_specified_height(VowelHeights height)
        {
            VowelBacknesses backness = VowelBacknesses.Front;
            VowelRoundednesses roundedness = VowelRoundednesses.Rounded;

            var expected = height;
            var actual = new Vowel(roundedness: roundedness, backness: backness, height: height).Height;

            Assert.Equal(expected, actual);
        }


        /// <summary>
        /// Verifies Roundedness returns the roundedness specified in the constructor
        /// </summary>
        /// <param name="roundedness">The roundedness that will be tested with</param>
        [Theory]
        [InlineData(VowelRoundednesses.Rounded)]
        [InlineData(VowelRoundednesses.Unrounded)]
        public void Roundedness_is_specified_roundedness(VowelRoundednesses roundedness)
        {
            VowelBacknesses backness = VowelBacknesses.Front;
            VowelHeights height = VowelHeights.Close;

            var expected = roundedness;
            var actual = new Vowel(roundedness: roundedness, backness: backness, height: height).Roundedness;

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies Equals(), when all members are the same (but the instances are different), properly returns false
        /// </summary>
        [Fact]
        public void Equals_other_all_members_are_same_returns_true()
        {
            VowelRoundednesses roundedness = VowelRoundednesses.Rounded;
            VowelBacknesses backness = VowelBacknesses.Front;
            VowelHeights height = VowelHeights.Close;

            Vowel other = new Vowel(roundedness: roundedness, backness: backness, height: height);
            Vowel instance = new Vowel(roundedness: roundedness, backness: backness, height: height);

            bool expected = true;
            bool actual = instance.Equals(other);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies Equals(), when Roundedness is different, properly returns false
        /// </summary>
        [Fact]
        public void Equals_other_Roundedness_is_different_returns_false()
        {
            VowelRoundednesses roundedness1 = VowelRoundednesses.Rounded;
            VowelRoundednesses roundedness2 = VowelRoundednesses.Unrounded;
            VowelBacknesses backness = VowelBacknesses.Front;
            VowelHeights height = VowelHeights.Close;

            Vowel other = new Vowel(roundedness: roundedness2, backness: backness, height: height);
            Vowel instance = new Vowel(roundedness: roundedness1, backness: backness, height: height);

            Assert.NotEqual(other.Roundedness, instance.Roundedness);

            bool expected = false;
            bool actual = instance.Equals(other);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies Equals(), when Backness is different, properly returns false
        /// </summary>
        [Fact]
        public void Equals_other_Backness_is_different_returns_false()
        {
            VowelRoundednesses roundedness = VowelRoundednesses.Rounded;
            VowelBacknesses backness1 = VowelBacknesses.Front;
            VowelBacknesses backness2 = VowelBacknesses.Back;
            VowelHeights height = VowelHeights.Close;

            Vowel other = new Vowel(roundedness: roundedness, backness: backness2, height: height);
            Vowel instance = new Vowel(roundedness: roundedness, backness: backness1, height: height);

            Assert.NotEqual(other.Backness, instance.Backness);

            bool expected = false;
            bool actual = instance.Equals(other);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies Equals(), when Height is different, properly returns false
        /// </summary>
        [Fact]
        public void Equals_other_Height_is_different_returns_false()
        {
            VowelRoundednesses roundedness = VowelRoundednesses.Rounded;
            VowelBacknesses backness = VowelBacknesses.Front;
            VowelHeights height1 = VowelHeights.Close;
            VowelHeights height2 = VowelHeights.CloseMid;

            Vowel other = new Vowel(roundedness: roundedness, backness: backness, height: height2);
            Vowel instance = new Vowel(roundedness: roundedness, backness: backness, height: height1);

            Assert.NotEqual(other.Height, instance.Height);

            bool expected = false;
            bool actual = instance.Equals(other);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies GetHashCode(), when all members are the same, properly returns the same hash code for both values
        /// </summary>
        [Fact]
        public void GetHashCode_other_all_members_are_same_returns_same_code()
        {
            VowelRoundednesses roundedness = VowelRoundednesses.Rounded;
            VowelBacknesses backness = VowelBacknesses.Front;
            VowelHeights height = VowelHeights.Close;

            Vowel other = new Vowel(roundedness: roundedness, backness: backness, height: height);
            Vowel instance = new Vowel(roundedness: roundedness, backness: backness, height: height);

            var expected = other.GetHashCode();
            var actual = instance.GetHashCode();

            Assert.Equal(expected, actual);
        }
    }
}
