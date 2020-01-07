using System.Collections.Generic;
using System.Collections.Immutable;
using BC.System;

namespace BC.Language.Phonetics.Builders
{
    public class OnsetBuilder : IBuilder<IList<Phone>>
    {
        public OnsetBuilder FROM_CONSONANT(Phone consonant) =>
            new OnsetBuilder()
            {
                Onset = new List<Phone>() { consonant }
            };

        public OnsetBuilder FROM_CONSONANT_CLUSTER(IList<Phone> consonantCluster) =>
            new OnsetBuilder()
            {
                Onset = new List<Phone>(consonantCluster)
            };

        public IList<Phone> Onset { get; set; } = new List<Phone>();

        public IList<Phone> Build() =>
            ImmutableList.CreateRange(Onset);
    }
}