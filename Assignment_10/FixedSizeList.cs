using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_10
{
    public class FixedSizeList<T>
    {
        private readonly T[] _items;
        private int _count;

        public int Capacity { get; }

        public int Count => _count;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero.", nameof(capacity));
            }

            Capacity = capacity;
            _items = new T[capacity];
            _count = 0;
        }

        public void Add(T item)
        {
            if (_count >= Capacity)
            {
                throw new InvalidOperationException($"Cannot add item. The list has reached its maximum capacity of {Capacity}.");
            }

            _items[_count] = item;
            _count++;
        }
        public T Get(int index)
        {
            if (index < 0 || index >= _count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of bounds. Current count is {_count}.");
            }

            return _items[index];
        }
    }
}
