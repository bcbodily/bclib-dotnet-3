using System;

namespace BC.Language.Phonetics
{
    /// <summary>
    /// A speech sound pronounced without any stricture in the vocal tract
    /// </summary>
    public struct Vowel : IEquatable<Vowel>
    {
        /// <summary>
        /// The backness of the vowel
        /// </summary>
        /// <value></value>
        public VowelBacknesses Backness { get; }

        /// <summary>
        /// The height of the vowel
        /// </summary>
        /// <value></value>
        public VowelHeights Height { get; }

        /// <summary>
        /// The roundedness of the vowel
        /// </summary>
        /// <value></value>
        public VowelRoundednesses Roundedness { get; }

        /// <summary>
        /// Creates a new Vowel with specified height, backness, and roundedness
        /// </summary>
        /// <param name="height">the height of the vowel</param>
        /// <param name="backness">the backness of the vowel</param>
        /// <param name="roundedness">the roundedness of the vowel</param>
        public Vowel(VowelHeights height, VowelBacknesses backness, VowelRoundednesses roundedness)
        {
            this.Backness = backness;
            this.Height = height;
            this.Roundedness = roundedness;
        }

        public override bool Equals(object obj) =>
            obj is Vowel other
            && other == this;

        public bool Equals(Vowel other) =>
            other == this;

        public override int GetHashCode() =>
            (Height, Backness, Roundedness).GetHashCode();

        public static bool operator ==(Vowel lhs, Vowel rhs) =>
            lhs.Roundedness == rhs.Roundedness &&
            lhs.Backness == rhs.Backness &&
            lhs.Height == rhs.Height;

        public static bool operator !=(Vowel lhs, Vowel rhs) =>
            lhs.Roundedness != rhs.Roundedness ||
            lhs.Backness != rhs.Backness ||
            lhs.Height != rhs.Height;
    }
}