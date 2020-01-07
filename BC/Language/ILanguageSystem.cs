using System.Collections.Generic;
using BC.Language.Phonetics;

namespace BC.Language
{
    public interface ILanguageSystem
    {
        IList<Phone> Phones { get; }

        bool IsConsonant(Phone phone);
        bool IsVowel(Phone phone);
    }
}