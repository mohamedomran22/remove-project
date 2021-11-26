using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> MoList = new LinkedList<string>();

            LinkedListNode<string> MoNode = MoList.AddFirst("x1");
            MoList.AddFirst("x2");
            MoList.AddFirst("x3");
            MoList.AddBefore(MoNode, "x4");
            MoList.AddLast("losted");

            Console.WriteLine("before removing linked list:  ");

            foreach (var item in MoList)
            {
                Console.Write(item + ",");
            }

            MoList.RemoveFirst();
            MoList.RemoveLast();
            MoList.Remove("x4");
            MoList.Remove("x1");

            Console.WriteLine();
            Console.WriteLine("After removing linked list: ");

            foreach (var item in MoList)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
