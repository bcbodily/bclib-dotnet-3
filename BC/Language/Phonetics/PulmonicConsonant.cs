using System;

namespace BC.Language.Phonetics
{
    public struct PulmonicConsonant : IEquatable<PulmonicConsonant>
    {
        public PlaceOfArticulations Place { get; }

        public MannerOfArticulations Manner { get; }

        public Voicings Voicing { get; }

        public PulmonicConsonant(PlaceOfArticulations place, MannerOfArticulations manner, Voicings voicing) {
            Place = place;
            Manner = manner;
            Voicing = voicing;
        }

        public override bool Equals(object obj) =>
            obj is PulmonicConsonant other
            && other == this;

        public bool Equals(PulmonicConsonant other) =>
            other == this;

        public override int GetHashCode() =>
            (Place, Manner, Voicing).GetHashCode();

        public static bool operator ==(PulmonicConsonant lhs, PulmonicConsonant rhs) =>
            lhs.Manner == rhs.Manner &&
            lhs.Place == rhs.Place &&
            lhs.Voicing == rhs.Voicing;

        public static bool operator !=(PulmonicConsonant lhs, PulmonicConsonant rhs) =>
            lhs.Manner != rhs.Manner ||
            lhs.Place != rhs.Place ||
            lhs.Voicing != rhs.Voicing;
    }
}