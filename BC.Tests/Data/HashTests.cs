using System;
using System.Collections.Generic;
using Xunit;

namespace BC.Data
{
    public class HashTests
    {
        [Fact]
        public void Contains_doesNot_contain_key_returns_false()
        {
            var key = "key";
            var value = 312;
            var item = new KeyValuePair<string, int>(key, value);
            var instance = new Hash<string, int>();

            Assert.False(instance.ContainsKey(key));

            var expected = false;
            var actual = instance.Contains(item);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Contains_doesNot_contain_value_returns_false()
        {
            var key = "key";
            var value = 312;
            var otherValue = 411;
            var item = new KeyValuePair<string, int>(key, value);
            var otherItem = new KeyValuePair<string, int>(key, otherValue);
            var instance = new Hash<string, int>();

            instance.Add(item);

            Assert.True(instance.ContainsKey(key));
            Assert.False(instance[key].Equals(otherItem.Value));

            var expected = false;
            var actual = instance.Contains(otherItem);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Contains_does_contain_item_returns_true()
        {
            var key = "key";
            var value = 312;
            var item = new KeyValuePair<string, int>(key, value);
            var instance = new Hash<string, int>();

            instance.Add(key, value);

            Assert.True(instance.ContainsKey(key));

            var expected = true;
            var actual = instance.Contains(item);

            Assert.Equal(expected, actual);
        }

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

        [Theory]
        [InlineData("a", -1)]
        [InlineData("b", 312)]
        public void ThisSet_thing_ThisGet_is_equal(string key, int value)
        {
            var instance = new Hash<string, int>();
            instance[key] = value;

            var expected = value;
            var actual = instance[key];

            Assert.Equal(expected, actual);
        }
    }
}