using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Print();
            var a = list[5];
            Console.WriteLine();
            Console.WriteLine(a);
            list.Delete(4);
            Console.WriteLine();
            list.Print();
            Console.WriteLine();
            list.AppendFirst(9);
            list.Print();
            Console.ReadKey();
        }
    }
}
