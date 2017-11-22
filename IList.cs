using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    interface IList<T>
    {
        void Add(T data);

        T this[int index] { get; }

        void Print();

        void Delete(T data);

        void AppendFirst(T data);
    }
}
