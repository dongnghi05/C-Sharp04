using System;
using System.Collections.Generic;

namespace Generics
{
    public class MyStack<T>
    {
        List<T> lst = new List<T>();
        public int Count()
        {
            return lst.Count;
        }
        public T Pop()
        {
            T value = lst[lst.Count - 1];
            lst.RemoveAt(lst.Count - 1);
            return value;
        }
        public void Push(T item)
        {
            lst.Add(item);
        }
    }
}
