using System;
using System.Collections.Generic;

namespace ImplementingLinkedListsAndStacksAndQueues
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DoublyLinkedList linked = new DoublyLinkedList();

            linked.AddFirst(new Node(1));
            linked.AddFirst(new Node(2));
            linked.AddFirst(new Node(3));

            linked.AddLast(new Node(1));
            linked.AddLast(new Node(2));
            linked.AddLast(new Node(3));

            linked.ForEach(node =>
            {
                Console.WriteLine(node.Value);
            });
            Console.WriteLine("Reversed: ");
            linked.Reverse();
            linked.ForEach(node =>
            {
                Console.WriteLine(node.Value);
            });
            //foreach (var node in linked.ToArray())
            //{
            //    Console.WriteLine("In foreach");
            //    Console.WriteLine(node.Value);
            //}
        }
    }
}
