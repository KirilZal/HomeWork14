using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    class MyList<T> : IEnumerable<T>
    {
        private readonly List<T> _list = new List<T>();

        public void Add(T item)
        {
            _list.Add(item);
        }
        public T this[int index]
        {
            get { return _list[index]; }
        }
        public int Count { get { return _list.Count; } }
        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
       
        
        

    }

}
