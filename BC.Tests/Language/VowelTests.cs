using System;
using Xunit;

namespace BC.Language
{
    public class VowelTests
    {
        /// <summary>
        /// Verifies Equals(), when all members are the same (but the instances are different), properly returns false
        /// </summary>
        [Fact]
        public void Equals_other_all_members_are_same_returns_true()
        {
            VowelArticulatoryDimensions articulatoryDimension = VowelArticulatoryDimensions.Front;
            VowelBacknesses backness = VowelBacknesses.Front;
            VowelHeights height = VowelHeights.Close;
            VowelTensenesses tenseness = VowelTensenesses.Tense;

            Vowel other = new Vowel(articulatoryDimension: articulatoryDimension, backness: backness, height: height, tenseness: tenseness);
            Vowel instance = new Vowel(articulatoryDimension: articulatoryDimension, backness: backness, height: height, tenseness: tenseness);

            Assert.NotSame(other, instance);

            bool expected = true;
            bool actual = instance.Equals(other);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies Equals(), when ArticulatoryDimension is different, properly returns false
        /// </summary>
        [Fact]
        public void Equals_other_ArticulatoryDimension_is_different_returns_false()
        {
            VowelArticulatoryDimensions articulatoryDimension1 = VowelArticulatoryDimensions.Front;
            VowelArticulatoryDimensions articulatoryDimension2 = VowelArticulatoryDimensions.Raised;
            VowelBacknesses backness = VowelBacknesses.Front;
            VowelHeights height = VowelHeights.Close;
            VowelTensenesses tenseness = VowelTensenesses.Tense;

            Vowel other = new Vowel(articulatoryDimension: articulatoryDimension2, backness: backness, height: height, tenseness: tenseness);
            Vowel instance = new Vowel(articulatoryDimension: articulatoryDimension1, backness: backness, height: height, tenseness: tenseness);

            Assert.NotEqual(other.ArticulatoryDimension, instance.ArticulatoryDimension);

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
            VowelArticulatoryDimensions articulatoryDimension = VowelArticulatoryDimensions.Front;
            VowelBacknesses backness1 = VowelBacknesses.Front;
            VowelBacknesses backness2 = VowelBacknesses.Back;
            VowelHeights height = VowelHeights.Close;
            VowelTensenesses tenseness = VowelTensenesses.Tense;

            Vowel other = new Vowel(articulatoryDimension: articulatoryDimension, backness: backness2, height: height, tenseness: tenseness);
            Vowel instance = new Vowel(articulatoryDimension: articulatoryDimension, backness: backness1, height: height, tenseness: tenseness);

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
            VowelArticulatoryDimensions articulatoryDimension = VowelArticulatoryDimensions.Front;
            VowelBacknesses backness = VowelBacknesses.Front;
            VowelHeights height1 = VowelHeights.Close;
            VowelHeights height2 = VowelHeights.CloseMid;
            VowelTensenesses tenseness = VowelTensenesses.Tense;

            Vowel other = new Vowel(articulatoryDimension: articulatoryDimension, backness: backness, height: height2, tenseness: tenseness);
            Vowel instance = new Vowel(articulatoryDimension: articulatoryDimension, backness: backness, height: height1, tenseness: tenseness);

            Assert.NotEqual(other.Height, instance.Height);

            bool expected = false;
            bool actual = instance.Equals(other);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies Equals(), when Tenseness is different, properly returns false
        /// </summary>
        [Fact]
        public void Equals_other_Tenseness_is_different_returns_false()
        {
            VowelArticulatoryDimensions articulatoryDimension = VowelArticulatoryDimensions.Front;
            VowelBacknesses backness = VowelBacknesses.Front;
            VowelHeights height = VowelHeights.Close;
            VowelTensenesses tenseness1 = VowelTensenesses.Tense;
            VowelTensenesses tenseness2 = VowelTensenesses.Lax;

            Vowel other = new Vowel(articulatoryDimension: articulatoryDimension, backness: backness, height: height, tenseness: tenseness2);
            Vowel instance = new Vowel(articulatoryDimension: articulatoryDimension, backness: backness, height: height, tenseness: tenseness1);

            Assert.NotEqual(other.Tenseness, instance.Tenseness);

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
            VowelArticulatoryDimensions articulatoryDimension = VowelArticulatoryDimensions.Front;
            VowelBacknesses backness = VowelBacknesses.Front;
            VowelHeights height = VowelHeights.Close;
            VowelTensenesses tenseness = VowelTensenesses.Tense;

            Vowel other = new Vowel(articulatoryDimension: articulatoryDimension, backness: backness, height: height, tenseness: tenseness);
            Vowel instance = new Vowel(articulatoryDimension: articulatoryDimension, backness: backness, height: height, tenseness: tenseness);

            Assert.NotSame(other, instance);

            var expected = other.GetHashCode();
            var actual = instance.GetHashCode();

            Assert.Equal(expected, actual);
        }
    }
}
