using System;
using System.Collections;
using System.Collections.Generic;

namespace BC.Data
{
    public class Hash<TKey, TValue> // : System.Collections.Generic.IDictionary<TKey, TValue>
    {
        private const int TABLE_SIZE = 64;
        private const int INITIAL_BUCKET_SIZE = 8;
        private (TKey[] keys, TValue[] values)[] Table { get; } = new (TKey[], TValue[])[TABLE_SIZE];

        public TValue this[TKey key]
        {
            get
            {
                var bucket = GetBucket(key);
                var index = GetIndexOfKeyInBucket(bucket, key);
                if (index < 0)
                    throw new KeyNotFoundException();

                return bucket.values[index];
            }

            set => Add(key, value);
        }

        public ICollection<TKey> Keys => throw new NotImplementedException();

        public ICollection<TValue> Values => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(TKey key, TValue value)
        {
            AddToBucket(GetBucket(key), key, value);
        }


        public void Add(KeyValuePair<TKey, TValue> item)
        {
            AddToBucket(GetBucket(item.Key), item.Key, item.Value);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            if (ContainsKey(item.Key))
            {
                return this[item.Key].Equals(item.Value);
            }
            return false;
        }

        public bool ContainsKey(TKey key)
        {
            var bucket = GetBucket(key);
            var keysTable = bucket.keys;
            if (keysTable == null)
                return false;
            for (int i = 0; i < keysTable.Length; i++)
            {
                if (key.Equals(keysTable[i]))
                    return true;
            }
            // else
            return false;
        }

        // public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        // {
        //     throw new NotImplementedException();
        // }

        // public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        // {
        //     throw new NotImplementedException();
        // }

        public bool Remove(TKey key)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            throw new NotImplementedException();
        }

        // IEnumerator IEnumerable.GetEnumerator()
        // {
        //     throw new NotImplementedException();
        // }

        private void AddToBucket((TKey[] keys, TValue[] values) bucket, TKey key, TValue value)
        {
            var openSpaceIndex = GetNextOpenBucketSpace(bucket);
            bucket.keys[openSpaceIndex] = key;
            bucket.values[openSpaceIndex] = value;
        }

        /// <summary>
        /// Gets the bucket for a given key
        /// </summary>
        /// <param name="key">the key that will determine the bucket to return</param>
        /// <returns>the bucket associated with the key</returns>
        private (TKey[] keys, TValue[] values) GetBucket(TKey key)
        {
            var index = GetBucketIndex(key);
            if (index > Table.Length)
                throw new ArgumentException("crazy");

            if (Table[index].keys == null)
            {
                InitializeBucket(index);
            }

            return Table[index];
        }

        private void InitializeBucket(int index)
        {
            Table[index].keys = new TKey[INITIAL_BUCKET_SIZE];
            Table[index].values = new TValue[INITIAL_BUCKET_SIZE];
        }

        private int GetIndexOfKeyInBucket((TKey[] keys, TValue[] values) bucket, TKey key)
        {
            for (int i = 0; i < bucket.keys.Length; i++)
            {
                if (key.Equals(bucket.keys[i])) return i;
            }
            return -1;
        }
        private int GetBucketIndex(TKey key) => Math.Abs(key.GetHashCode() % TABLE_SIZE);

        private int GetNextOpenBucketSpace((TKey[] keys, TValue[] values) bucket)
        {
            var openSpaceIndex = 0;
            while (bucket.keys[openSpaceIndex] != null)
            {
                openSpaceIndex++;
            }
            return openSpaceIndex;
        }

    }
}