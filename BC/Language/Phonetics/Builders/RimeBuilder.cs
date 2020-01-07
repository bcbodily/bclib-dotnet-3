using System.Collections.Generic;
using System.Collections.Immutable;
using BC.System;

namespace BC.Language.Phonetics
{
    public class RimeBuilder : IBuilder<IList<Phone>>
    {
        public Phone Nucleus { get; set; }

        public Phone? Coda { get; set; }

        public IList<Phone> Build()
        {
            var builder = ImmutableList.CreateBuilder<Phone>();
            builder.Add(Nucleus);
            if (Coda.HasValue)
                builder.Add(Coda.Value);
            return builder.ToImmutableList();
        }
    }
}