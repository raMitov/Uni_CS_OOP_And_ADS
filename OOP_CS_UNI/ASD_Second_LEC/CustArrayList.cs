using System;

namespace ASD_Second_LEC
{
    public class CustArrayList<T>
    {
        private T[] _items;
        private int _count;
        private const int defCapacity = 4;
        public int Count => _count;

        public CustArrayList(int capacity = defCapacity)
        {
            _items = new T[capacity];
            _count = 0;
        }

        public void Add(T item)
        {
            Resize(_items.Length + 1);
            _items[_count] = item;
            _count++;
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

        public void removeAt(int index)
        {
            if (index < 0 || index >= _count)
                throw new ArgumentOutOfRangeException(nameof(index), "Invalid index");
            for (int i = index; i < _count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }
            _count--;
            _items[_count] = default;
        }

        public T get(int index)
        {
            if (index < 0 || index >= _count)
                throw new ArgumentOutOfRangeException(nameof(index), "Invalid index");
            for (int i = 0; i < _count; i++)
            {
                if (index == i)
                {
                    return _items[i];
                }
            }
            return default;
        }

        public void printList()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_items[i]);
            }
        }

        public void insert(int index, T item)
        {
            
        }
    }
    
}
