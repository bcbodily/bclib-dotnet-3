using System.Collections.Generic;
using System.Collections.Immutable;
using BC.System;

namespace BC.Language.Phonetics.Builders
{
    public class CodaBuilder : IBuilder<IList<Phone>>
    {
        public static CodaBuilder FROM_CONSONANT(Phone consonant) =>
            new CodaBuilder()
            {
                Consonant = consonant
            };


        public Phone Consonant { get; set; }

        public IList<Phone> Build()
        {
            var builder = ImmutableList.CreateBuilder<Phone>();
            builder.Add(Consonant);
            return builder.ToImmutableList();
        }


    }
}