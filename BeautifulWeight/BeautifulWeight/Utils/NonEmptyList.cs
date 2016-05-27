using System;
using System.Collections;
using System.Collections.Generic;

namespace BeautifulWeight.Kitchen
{
    class NonEmptyList<T> : IList<T>
    {
        private List<T> _list;

        public NonEmptyList(T firstElement)
        {
            if (firstElement == null)
            {
                throw new ArgumentException("First element cannot be null");
            }
            _list = new List<T>();
            _list.Add(firstElement);
        }

        public T this[int index]
        {
            get
            {
                return ((IList<T>)_list)[index];
            }

            set
            {
                ((IList<T>)_list)[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return ((IList<T>)_list).Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return ((IList<T>)_list).IsReadOnly;
            }
        }

        public void Add(T item)
        {
            ((IList<T>)_list).Add(item);
        }

        public void Clear()
        {
            ((IList<T>)_list).Clear();
        }

        public bool Contains(T item)
        {
            return ((IList<T>)_list).Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ((IList<T>)_list).CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IList<T>)_list).GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return ((IList<T>)_list).IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            ((IList<T>)_list).Insert(index, item);
        }

        public bool Remove(T item)
        {
            if (_list.Count == 1)
                throw new InvalidOperationException("Cannot remove last element from this list");
            else
                return ((IList<T>)_list).Remove(item);
        }

        public void RemoveAt(int index)
        {
            if (_list.Count == 1)
                throw new InvalidOperationException("Cannot remove last element from this list");
            else
                ((IList<T>)_list).RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IList<T>)_list).GetEnumerator();
        }
    }

}