using System.Collections.Generic;
using System.Collections.Immutable;
using BC.System;

namespace BC.Language.Phonetics.Builders
{
    public class SyllableBuilder : IBuilder<IList<Phone>>
    {
        public static SyllableBuilder FROM_NUCLEUS(Phone nucleus) =>
            new SyllableBuilder()
            {
                Onset = new List<Phone>(),
                Rime = new List<Phone>() { nucleus }
            };

        public static SyllableBuilder FROM_NUCLEUS_AND_CODA(Phone nucleus, Phone coda) =>
            new SyllableBuilder()
            {
                Onset = new List<Phone>(),
                Rime = new List<Phone>() { nucleus, coda }
            };

        public static SyllableBuilder FROM_ONSET_CONSONANT_AND_RIME(Phone consonant, IList<Phone> rime) =>
            new SyllableBuilder()
            {
                Onset = new List<Phone>() { consonant },
                Rime = new List<Phone>(rime)
            };

        public static SyllableBuilder FROM_ONSET_CONSONANT_CLUSTER_AND_RIME(IList<Phone> consonantCluster, IList<Phone> rime) => new SyllableBuilder()
        {
            Onset = new List<Phone>(consonantCluster),
            Rime = new List<Phone>(rime)
        };

        public IList<Phone> Onset { get; set; } = new List<Phone>();

        public IList<Phone> Rime { get; set; } = new List<Phone>();

        public IList<Phone> Build()
        {
            var builder = ImmutableList.CreateBuilder<Phone>();
            builder.AddRange(Onset);
            builder.AddRange(Rime);
            return builder.ToImmutableList();
        }

    }
}