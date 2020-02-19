using System;
using Xunit;

namespace BC.Data
{
    public class HashTests
    {
        [Fact]
        public void Add_then_ContainsKey_is_true()
        {
            string key = "key";
            int value = 312;

            var instance = new Hash<string, int>();

            Assert.False(instance.ContainsKey(key));

            instance.Add(key, value);

            var expected = true;
            var actual = instance.ContainsKey(key);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("key")]
        [InlineData("")]
        public void newInstance_ContainsKey_is_false(string key)
        {
            Assert.False(new Hash<string, int>().ContainsKey(key));
        }

        [Theory]
        [InlineData("a", -1)]
        [InlineData("b", 312)]
        public void This_does_contain_key_returns_associated_value(string key, int value)
        {
            var instance = new Hash<string, int>();
            instance.Add(key, value);

            var expected = value;
            var actual = instance[key];

            Assert.Equal(expected, actual);
        }
    }
}