using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeoStudio
{
    /// <summary>
    /// Implementation of Sequence Queue using Generics
    /// </summary>
    /// <typeparam name="T">Type of the data items</typeparam>
    public class QueueSequence<T>
    {
        /// <summary>
        /// Maxsize of the queue
        /// </summary>
        private int _maxSize;

        /// <summary>
        /// Get the maxsize for the queue
        /// </summary>
        public int MaxSize
        {
            get { return _maxSize; }
        }

        /// <summary>
        /// Data domain of the queue
        /// </summary>
        private T[] _data;

        /// <summary>
        /// Fronter pointer
        /// </summary>
        private int _front;

        /// <summary>
        /// Rear pointer
        /// </summary>
        private int _rear;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="maxsize">Max size for the queue</param>
        public QueueSequence(int maxsize)
        {
            this._maxSize = maxsize;
            this._data = new T[maxsize];
            this._front = 0;
            this._rear = -1;
            this._size = 0;
        }

        /// <summary>
        /// The queue is empty or not
        /// </summary>
        /// <value>True, if the queue is empty</value>
        public bool IsEmpty
        {
            get
            {
                return (bool)(this._size == 0);
            }
        }

        /// <summary>
        /// Insert an item into the queue
        /// </summary>
        /// <param name="item">Item to be inserted.</param>
        public void EnQueue(T item)
        {
            if (this._size == this._maxSize)
            {
                throw new QueueIsFullException();
            }

            this._rear = (this._rear + 1) % this._maxSize;
            this._data[this._rear] = item;
            this._size = this._size + 1;
        }

        public void InsertQueue(T item)
        {
            if (this._size != this._maxSize)//目前队列未满
            {
                EnQueue(item);
            }
            else
            {
                DeQueue();
                EnQueue(item);
            }
        }
        
        public List<T> GetList()
        {
            List<T> result = new List<T>();
            int j = this._front;
            for (int i = 0; i < this._maxSize; i++)
            {
                j = j % this._maxSize;
                result.Add(this._data[j]);
                j++;
            }
            return result;
        }

        /// <summary>
        /// Current size of the queue
        /// </summary>
        private int _size;

        public int Size
        {
            get { return _size; }
        }

        /// <summary>
        /// Dequeue an item
        /// </summary>
        /// <returns>Item dequeued</returns>
        public T DeQueue()
        {
            if (this._size == 0)
            {
                throw new QueueIsEmptyException();
            }
            this._size = this._size - 1;
            T toReturn = this._data[this._front];
            this._front = (this._front + 1) % this._maxSize;
            return toReturn;
        }

        /// <summary>
        /// Get the front item of the queue
        /// </summary>
        /// <returns>Front item of the queue</returns>
        public T GetFront()
        {
            if (this._size == 0)
            {
                throw new QueueIsEmptyException();
            }

            return this._data[this._front];
        }

        /// <summary>
        /// Set the queue to be empty
        /// </summary>
        public void SetEmpty()
        {
            this._front = 0;
            this._rear = -1;
            this._size = 0;
        }
    }

    public class QueueIsEmptyException : Exception
    {
        public QueueIsEmptyException()
            :
            base("The queue is already empty !")
        { }
    }

    public class QueueIsFullException : Exception
    {
        public QueueIsFullException()
            :
            base("The queue is already full !")
        { }
    }




}
