using System.Collections.Generic;
using Xunit;

namespace BC.Language.Phonetics.Builders
{
    public class SyllableBuilderTests
    {
        [Fact]
        public void builderTest()
        {
            var onset = new Phone("c");
            var nucleus = new Phone("a");
            var coda = new Phone("t");

            var actual = new SyllableBuilder()
            {
                Onset = new List<Phone> { onset },
                Rime = new List<Phone> { nucleus, coda },
            }.Build();

            var expected = new List<Phone> { onset, nucleus, coda };

            Assert.Equal(expected, actual);

        }
    }
}