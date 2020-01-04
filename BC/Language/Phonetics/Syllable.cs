using System;

namespace BC.Language.Phonetics
{
    public struct Syllable : IEquatable<Syllable>
    {
        public Onset? Onset { get; }

        public Rime Rime { get; }

        public bool Equals(Syllable other) =>
            other == this;

        public override bool Equals(object obj) =>
            obj is Syllable other
            && other == this;

        public override int GetHashCode() =>
            (Onset, Rime).GetHashCode();

        public static bool operator ==(Syllable lhs, Syllable rhs) =>
            lhs.Onset.Equals(rhs.Onset) &&
            lhs.Rime.Equals(rhs.Rime);

        public static bool operator !=(Syllable lhs, Syllable rhs) =>
            !lhs.Onset.Equals(rhs.Onset) ||
            !lhs.Rime.Equals(rhs.Rime);
    }
}