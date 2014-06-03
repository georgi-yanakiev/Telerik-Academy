// Homework 5,6,7 -> Write a generic class GenericList<T> that keeps a list of elements of some parametric type T...

namespace GenericList
{
    using System;

    public class GenericList<T>
    {
        private const int initialCapacity = 4; // initial capacity
        private T[] arrayOfElements;
        private int currentIndex;

        //constructors
        public GenericList()
            : this(initialCapacity)
        {

        }

        public GenericList(int cap)
        {
            this.arrayOfElements = new T[cap];
        }

        // property
        public T this[int index]
        {
            get { return this.arrayOfElements[index]; }

            set { this.arrayOfElements[index] = value; }
        }

        // method for addding values
        public void Add(T element)
        {
            if (this.currentIndex >= this.arrayOfElements.Length)
            {
                T[] newArray = new T[this.arrayOfElements.Length * 2]; // define new array with double capacity
                for (int i = 0; i < this.arrayOfElements.Length; i++)
                {
                    newArray[i] = this.arrayOfElements[i];
                }

                this.currentIndex++;
                newArray[this.arrayOfElements.Length] = element;
                this.arrayOfElements = newArray; // the new array
            }
            else
            {
                this.arrayOfElements[this.currentIndex] = element;
                this.currentIndex++;
            }
        }

        // method for removing values
        public void Remove(int index)
        {
            if (index < this.arrayOfElements.Length)
            {
                T[] newArray = new T[this.arrayOfElements.Length - 1]; // new array
                bool tempRemove = true;

                for (int i = 0; i < this.arrayOfElements.Length - 1; i++)
                {
                    if (i == index)
                    {
                        tempRemove = false;
                    }

                    if (tempRemove)
                    {
                        newArray[i] = this.arrayOfElements[i];
                    }
                    else
                    {
                        newArray[i] = this.arrayOfElements[i + 1];
                    }
                }

                this.arrayOfElements = newArray;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Index is outside the array!");
            }
        }


        // method for inserting values at certain positions
        public void Insert(int index, T element)
        {
            if (index < this.arrayOfElements.Length)
            {
                T[] newArray = new T[this.arrayOfElements.Length + 1];
                bool tempRemove = true;

                for (int i = 0; i < this.arrayOfElements.Length + 1; i++)
                {
                    if (i == index)
                    {
                        tempRemove = false;
                        newArray[i] = element;
                        continue;
                    }

                    if (tempRemove)
                    {
                        newArray[i] = this.arrayOfElements[i];
                    }
                    else
                    {
                        newArray[i] = this.arrayOfElements[i - 1];
                    }
                }

                this.arrayOfElements = newArray;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Index is outside the array!");
            }
        }

        // method for maximal element in the array
        public T Max()
        {
            dynamic maxElement = int.MinValue;

            for (int i = 0; i < this.arrayOfElements.Length; i++)
            {
                if (this.arrayOfElements[i] > maxElement)
                {
                    maxElement = this.arrayOfElements[i];
                }
            }

            return maxElement;
        }

        // method for minimal element in the array
        public T Min()
        {
            dynamic minElement = int.MaxValue;
            for (int i = 0; i < this.arrayOfElements.Length; i++)
            {
                if (this.arrayOfElements[i] < minElement)
                {
                    minElement = this.arrayOfElements[i];
                }
            }

            return minElement;
        }
        // clear method
        public void Clear()
        {
            this.arrayOfElements = new T[1];
        }

        // method for finding an element by value
        public int FindByValue(T value)
        {
            int indexFound = -1;

            for (int i = 0; i < this.arrayOfElements.Length; i++)
            {
                if (this.arrayOfElements[i].Equals(value))
                {
                    indexFound = i;
                    break;
                }
            }

            return indexFound;
        }

        // printing method
        public override string ToString()
        {
            return string.Join(", ", this.arrayOfElements);
        }
    }
}