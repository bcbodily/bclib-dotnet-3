using System.Collections.Generic;
using System.Collections.Immutable;
using BC.System;

namespace BC.Language.Phonetics.Builders
{
    public class NucleusBuilder : IBuilder<IList<Phone>>
    {
        public static NucleusBuilder FROM_VOWEL(Phone vowel) =>
            new NucleusBuilder()
            {
                Nucleus = new List<Phone>() { vowel }
            };

        public static NucleusBuilder FROM_CONSONANT_CLUSTER(IList<Phone> consonantCluster) =>
            new NucleusBuilder()
            {
                Nucleus = new List<Phone>(consonantCluster)
            };

        public IList<Phone> Nucleus { get; set; } = new List<Phone>();

        public IList<Phone> Build()
        {
            var builder = ImmutableList.CreateBuilder<Phone>();
            builder.AddRange(Nucleus);
            return builder.ToImmutableList();
        }
    }
}