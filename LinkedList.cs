using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList<T> : IList<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
        private int _count;

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (_head == null)
            {
                _head = node;
            }
            else
            {
                _tail.Next = node;
            }
            _tail = node;

            _count++;
        }

        public void Print()
        {
            var node = _head;

            while(node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }          
        }

        public T this[int index] 
        { 
            get 
            {
                if (index < 0 || index > _count)
                {
                    throw new IndexOutOfRangeException();                   
                }

                var current = _head;

                for (var i = 0; i < index ; i++)
			    {			 
                    if(current.Next == null )
                    {
                         throw new IndexOutOfRangeException();
                    }

                    current = current.Next;
                }
                 return current.Data;
            }
        }

        public void Delete(T data)
        {
             Node<T> _previous = null;
             Node<T> _current = _head;

             while (_current != null)
             {
                 if (_current.Data.Equals(data))
                 {
                     if (_previous != null)
                     {
                         _previous.Next = _current.Next;

                         if (_current.Next == null)
                         {
                             _tail = _previous;
                         }
                     }
                     else
                     {
                         _head = _head.Next;

                         if (_head == null)
                         {
                             _tail = null;
                         }
                     }
                     _count--;
                 }

                 _previous = _current;
                 _current = _current.Next;
             }
        }

        public void AppendFirst(T data)
        {
            var node = new Node<T>(data);

            node.Next = _head;
            _head = node;

            if (_count == 0)
            {
                _tail = _head;
            }
            _count++;
        }
    }
}
