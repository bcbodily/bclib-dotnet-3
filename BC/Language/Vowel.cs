using System;

namespace BC.Language
{
    /// <summary>
    /// A speech sound pronounced without any stricture in the vocal tract
    /// </summary>
    public struct Vowel : IEquatable<Vowel>
    {
        public VowelArticulatoryDimensions ArticulatoryDimension { get; }

        public VowelBacknesses Backness { get; }
        public VowelHeights Height { get; }

        public VowelTensenesses Tenseness { get; }

        public Vowel(VowelArticulatoryDimensions articulatoryDimension, VowelBacknesses backness, VowelHeights height, VowelTensenesses tenseness)
        {
            this.ArticulatoryDimension = articulatoryDimension;
            this.Backness = backness;
            this.Height = height;
            this.Tenseness = tenseness;
        }

        public override bool Equals(object obj) =>
            obj is Vowel other
            && other == this;

        public bool Equals(Vowel other) =>
            other == this;

        public override int GetHashCode() =>
            new { ArticulatoryDimension, Backness, Height, Tenseness }.GetHashCode();

        public static bool operator ==(Vowel lhs, Vowel rhs) =>
            lhs.ArticulatoryDimension == rhs.ArticulatoryDimension &&
            lhs.Backness == rhs.Backness &&
            lhs.Height == rhs.Height &&
            lhs.Tenseness == rhs.Tenseness;

        public static bool operator !=(Vowel lhs, Vowel rhs) =>
            lhs.ArticulatoryDimension != rhs.ArticulatoryDimension ||
            lhs.Backness != rhs.Backness ||
            lhs.Height != rhs.Height ||
            lhs.Tenseness != rhs.Tenseness;
    }
}