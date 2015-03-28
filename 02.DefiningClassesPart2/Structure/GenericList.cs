using System;
using System.Linq;
using System.Text;

namespace Structure
{
    public class GenericList<T>
    {
        private T[] array;
        private int index;
        public T this[int i]
        {
            get
            {
                return array[i];
            }
        }

        public GenericList() { }
        public GenericList(int capacity)
        {
            array = new T[capacity];
            index = 0;
        }
        
        // Problem 6
        
        public void Add(T element)
        {
            if (index > array.Length - 1)
            {
                Array.Resize<T>(ref array, array.Length * 2);
            }

            array[index] = element;
            index++;
        }

        public void RemoveAt(int position)
        {
            array = array.Where((source, i) => i != position).ToArray();
            index--;
        }

        public void InsertAt(int position, T element)
        {
            if (position == index)
            {
                Add(element);
            }
            else if (position > index)
            {
                throw new IndexOutOfRangeException("Not correct index!");
            }
            else
            {
                if (index > array.Length - 1)
                {
                    Array.Resize<T>(ref array, array.Length * 2);
                }

                for (int i = index; i >= position; i--)
                {
                    array[i] = array[i - 1];
                }

                array[position] = element;
                index++;
            }
        }

        public void Clear()
        {
            Array.Clear(array, 0, array.Length - 1);
            index = 0;
        }

        public int Find(T element)
        {
            return array.ToList().FindIndex(e => Object.Equals(e, element)); ;
        }

       
        //Problem 7
        
        public T Min()
        {
            return array.Min();
        }

        public T Max()
        {
            return array.Max();
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            Console.WriteLine("GenericList size: {0}\nItems: {1}\n Values:", array.Length, index);
            for (int i = 0; i < index; i++)
            {
                str.Append(array[i] + " ");
            }
            return str.ToString();
        }
    }
}
