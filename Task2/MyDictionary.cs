using System;
using System.Collections;
using System.Collections.Generic;
namespace Task2
{
    class MyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        private List<KeyValuePair<TKey, TValue>> _items = new List<KeyValuePair<TKey, TValue>>();

        // Метод для додавання елемента
        public void Add(TKey key, TValue value)
        {
            _items.Add(new KeyValuePair<TKey, TValue>(key, value));
        }

        
        public TValue this[TKey key]
        {
            get
            {
                foreach (var item in _items)
                {
                    if (EqualityComparer<TKey>.Default.Equals(item.Key, key))
                        return item.Value;
                }
                throw new KeyNotFoundException("no key found"+key);
            }
        }

        
        public int Count => _items.Count;

      
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


}

