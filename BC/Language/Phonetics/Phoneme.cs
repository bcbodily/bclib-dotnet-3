using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace BC.Language.Phonetics
{
    /// <summary>
    /// A unit of sound that distinguishes one word from another
    /// </summary>
    public struct Phoneme : IEquatable<Phoneme>
    {
        /// <summary>
        /// A symbol that represents this Phoneme
        /// </summary>
        /// <value>A symbol that represents this Phoneme</value>
        public string Symbol { get; }

        /// <summary>
        /// The phones that make up this phoneme
        /// </summary>
        /// <value></value>
        public ISet<Phone> Allophones { get; }

        /// <summary>
        /// Creates a new Phoneme
        /// </summary>
        /// <param name="symbol">a symbol that represents this Phoneme</param>
        /// <param name="allophones">zero or more phones that serve as allophones for this phenome</param>
        public Phoneme(string symbol, params Phone[] allophones)
        {
            Symbol = symbol;
            Allophones = ImmutableSortedSet.Create(allophones);
        }

        /// <summary>
        /// Returns whether one Phoneme is equal to another
        /// </summary>
        /// <param name="lhs">the first Phoneme</param>
        /// <param name="rhs">the second Phoneme</param>
        /// <returns>true if the two Phonemes are equal; otherwise, false</returns>
        public static bool operator ==(Phoneme lhs, Phoneme rhs) =>
            lhs.Symbol == rhs.Symbol &&
            lhs.Allophones == rhs.Allophones;

        /// <summary>
        /// Returns whether one Phoneme is not equal to another
        /// </summary>
        /// <param name="lhs">the first Phoneme</param>
        /// <param name="rhs">the second Phoneme</param>
        /// <returns>true if the two Phonemes are not equal; otherwise, false</returns>
        public static bool operator !=(Phoneme lhs, Phoneme rhs) =>
            lhs.Symbol != rhs.Symbol ||
            lhs.Allophones != rhs.Allophones;

        /// <summary>
        /// Returns whether a Phoneme is equal to this Phoneme
        /// </summary>
        /// <param name="other">the Phoneme to compare to this Phoneme</param>
        /// <returns>true if the other Phoneme is equal to this Phoneme; otherwise, false</returns>
        public bool Equals(Phoneme other) =>
            this == other;

        /// <summary>
        /// Returns whether another object is equal to this Phoneme
        /// </summary>
        /// <param name="obj">the other object</param>
        /// <returns>true if the other object is a Phoneme equal to this Phoneme; otherwise, false</returns>
        public override bool Equals(object obj) =>
            obj is Phoneme other &&
            this == other;

        /// <summary>
        /// Gets a consistent hashcode for this Phoneme
        /// </summary>
        /// <returns>a hashcode that is consistent for this Phoneme</returns>
        public override int GetHashCode() =>
            (Symbol, Allophones).GetHashCode();

        /// <summary>
        /// Gets a string representation of this Phoneme
        /// </summary>
        /// <returns>the symbol that represents this Phoneme</returns>
        public override string ToString() =>
            Symbol;
    }
}