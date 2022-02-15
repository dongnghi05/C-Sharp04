using System;
using System.Collections.Generic;

namespace Generics
{
    public class MyList<T>
    {
        List<T> lst = new List<T>();
        public void Add(T element)
        {
            lst.Add(element);
        }
        public T Remove(int index)
        {
            lst.RemoveAt(index);
            return lst[index];
        }
        public bool Containts (T element)
        {
            if (lst.Contains(element))
                return true;
            return false;
        }
        public void Clear()
        {
            lst.Clear();
        }
        public void InsertAt(T element, int index)
        {
            lst.Insert(index, element);
        }
        public void DeleteAt(int index)
        {
            lst.RemoveAt(index);
        }
        public T Find(int index)
        {
            return lst[index];
        }
    }
    
}
