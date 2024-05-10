using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public partial class CustomList<Type>
    {
        private int _count;
        private int _capacity;
        public int Count { get { return _count; } }
        public int Capacity { get { return _capacity; } }
        public Type[] _array; // int[] _array
        public Type this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }
        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _array = new Type[Capacity]; // _array = new int[size]
        }
        public CustomList(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new Type[Capacity];
        }
        public void Add(Type element)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            _array[_count] = element;
            _count++;
        }

        public void GrowSize()
        {
            _capacity *= 2;
            Type[] temp = new Type[Capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }

        //Insert at specific index position
        // 1,2,4,5
        // 1,2,3,4,5
        public void Insert(int position, Type element)
        {
            _capacity = _capacity + 1 + 4; //extra element so we dont need to use grow size
            Type[] temp = new Type[_capacity];

            for (int i = 0; i < _count + 1; i++)
            {
                if (i < position)
                {
                    temp[i] = _array[i];
                    i++; //to put all elements that before position
                }

                else if (i == position)
                {
                    temp[i] = element;
                }

                else
                {
                    temp[i] = _array[i - 1]; //assinging the previous original index value to after inserted position
                }
            }
            _count++; // increase count after insertion
            _array = temp; // assign temp to original array
        }

        // adding another list to current list or adding range of element to current list after last position
        //1,2,3,4,5 insert 6,7,8 in this list
        //1,2,3,4,5
        //1,2,3,4,5,6,7,8
        public void AddRange(CustomList<Type> elements)
        {
            _capacity = _count + elements.Count + 4;
            Type[] temp = new Type[_capacity];
            int position = _count - 1;
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            int k = 0;
            for (int i = _count; i < _count + elements.Count; i++)
            {
                temp[i] = elements[k];
                k++;
            }
            _array = temp; //assign to orirginal array
            _count = _count + elements.Count; //increase original count after insertion
        }
        //1,2,3,4,5 - insert at position 2 -- list of values 20,30,40
        // 1,2,
        // 1,2,20,30,40
        // 1,2,20,30,40,3,4,5

        public void InsertRange(int position, CustomList<Type> elements)
        {
            _capacity = _count + elements.Count + 4; //extra elements to prevent calling grow size
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < position; i++)
            {
                temp[i] = _array[i];
            }
            int j = 0;
            for (int i = position; i < position + elements.Count; i++)
            {
                temp[i] = elements[j];
                j++;
            }
            int k = position; //gets the element whic was previously there
            for (int i = position + elements.Count; i < _count + elements.Count; i++)
            {
                temp[i] = _array[k];
                k++;
            }
            _array = temp;
            _count = _count + elements.Count;
        }


        public bool Contains(Type element)
        {
            bool temp = false;
            foreach (Type data in _array)
            {
                if (data.Equals(element))
                {
                    temp = true;
                    break;
                }
            }
            return temp;
        }

        // 1,2,3,4,5 - remove at poistion 2
        // 1,2,4,5 - replace index 2 with i+1 elements
        public void RemoveAt(int position)
        {
            for (int i = 0; i < _count - 1; i++) //count - 1 because we removed one element
            {
                if (i >= position)
                {
                    _array[i] = _array[i + 1];
                }
            }
        }

        public int IndexOf(Type element)
        {
            int index = -1;
            for (int i = 0; i < _count; i++)
            {
                if (element.Equals(_array[i]))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public bool Remove(Type element)
        {
            int position = IndexOf(element);
            if (position >= 0)
            {
                RemoveAt(position);
                return true;
            }
            return false;
        }

        // 1,3,4,2,5
        // 1,2,3,4,5
        public void Sort(Type elements)
        {
            for (int i = 0; i < _count; i++)
            {
                for (int j = 0; i < _count; i++)
                {
                    if (IsGreater(_array[j], _array[j + 1]))
                    {
                        Type temp = _array[j + 1];
                        _array[j + 1] = _array[j];
                        _array[j] = temp;
                    }
                }
            }
        }

        public bool IsGreater(Type value1, Type value2)
        {
            int result = Comparer<Type>.Default.Compare(value1, value2);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        // 1,2,3,4,5
        // 5,4,3,2,2
        public void Reverse()
        {
            Type[] temp = new Type[_capacity];
            int j = 0;
            for (int i = _count - 1; i >= 0; i--)
            {
                temp[j] = _array[i];
                j++;
            }
            _array = temp;
        }
    }

}