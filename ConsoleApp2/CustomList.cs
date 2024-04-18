using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class CustomList<T> : IEnumerable<T>
    {
        private List<T> items;

        public CustomList()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Find(Predicate<T> match)
        {
            return items.Find(match);
        }

        public List<T> FindAll(Predicate<T> match)
        {
            return items.FindAll(match);
        }

        public bool Remove(T item)
        {
            return items.Remove(item);
        }

        public int RemoveAll(Predicate<T> match)
        {
            return items.RemoveAll(match);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
