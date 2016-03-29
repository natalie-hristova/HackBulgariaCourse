using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsApp
{
    class LambdaExpressions<T> : IList<T>
    {
        public event EventHandler CollectionChanged;
        private readonly List<T> list = new List<T>();
        public T this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return list.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T item)
        {
            EventHandler handler = CollectionChanged;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
                Console.WriteLine("Added item :{0}", item);
            }
            list.Add(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(T item)
        {
            return (list.Contains(item));
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return list.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            list.Insert(index, item);
        }

        public bool Remove(T item)
        {
            if (list.Contains(item))
            {
                return true;
            }
            else
                return false;
        }

        public void RemoveAt(int index)
        {
            EventHandler handler = CollectionChanged;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
            list.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
