using System;
using System.Collections;
using System.Collections.Generic;

namespace BeautifulWeight.Kitchen
{
    public class NonEmptyList<T> : IEnumerable<T>
    {
        private List<T> _list;

        public NonEmptyList(T firstElement) : this()
        {
            if (firstElement == null)
            {
                throw new ArgumentException("First element cannot be null");
            }
            _list.Add(firstElement);
        }

        public NonEmptyList()
        {
            _list = new List<T>();
        }

        public int Count
        {
            get
            {
                CheckState();
                return ((IList<T>)_list).Count;
            }
        }

        private void CheckState()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("NonEmptyList is empty");
        }

        public void Add(T item)
        {
            ((IList<T>)_list).Add(item);
        }


        public bool Remove(T item)
        {
            CheckState();
            if (_list.Count == 1)
                throw new InvalidOperationException("Cannot remove last element from this list");
            else
                return ((IList<T>)_list).Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            CheckState();
            return ((IEnumerable<T>)_list).GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            CheckState();
            return ((IEnumerable<T>)_list).GetEnumerator();
        }
    }

}