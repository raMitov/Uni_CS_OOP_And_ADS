using System;

namespace ASD_Second_LEC
{
    public class CustStack<T>
    {
        private T[] _items;
        private int _count;
        private const int defCapacity = 4;
        public int Count => _count;

        public CustStack(int capacity = defCapacity)
        {
            _items = new T[capacity];
            _count = 0;
        }

        public T Pop()
        {
            if (_count > 0) throw new InvalidOperationException("Stack is empty");
            T item = _items[_count];
            _items[_count] = default(T);
            if(_count > 0 && _count < _items.Length / 4) Resize(_items.Length / 2);
            return item;
        }

        public void push(T item)
        {
            if(_count == _items.Length) Resize(_items.Length * 2);
            _items[_count++] = item;
        }

        public T Peek()
        {
            if(_count == 0) throw new InvalidOperationException("Stack is empty");
            return _items[_count - 1];
        }
        private void Resize(int newSize)
        {
            T[] newItems = new T[newSize];
            for (int i = 0; i < _count; i++)
            {
                newItems[i] = _items[i];
            }
            _items = newItems;
        }
    }
}