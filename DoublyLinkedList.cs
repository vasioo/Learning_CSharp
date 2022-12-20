using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementingLinkedListsAndStacksAndQueues
{
   public class DoublyLinkedList
    {
        private bool IsReversed = false;
        public int Count { get; set; }
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void Reverse()
        {
            IsReversed = !IsReversed;
        }
        public void ForEach(Action<Node> action)
        {
            var node = Head;
            if (IsReversed)
            {
                node = Tail;
            }
            while (node!=null)
            {
                action(node);
                if (IsReversed)
                {
                    node = node.Previous;
                }
                else
                {
                    node = node.Next;
                }
            }
        }
        public Node[] ToArray()
        {
            Node[] array = new Node[Count];
            var node = Head;
            int index = 0;
            while (node!=null)
            {
                array[index++]=node;
                node = node.Next;
            }
            return array;
        }
        public Node RemoveFirst()
        {
            var previousHead = Head;
            var nextHead = Head.Next;
            if (nextHead != null)
            {
                nextHead.Previous = null;
            }
            Head = nextHead;
            return previousHead;
        }
        public Node RemoveLast()
        {
            var previous = Tail;
            var next = Tail.Previous;
            if (Tail != null)
            {
                next.Next = null;
            }
            Tail = next;
            return previous;
        }
        public void AddFirst(Node node)
        {
            Count++;
            if (!CheckElement(node))
            {
                Node previousHead = Head;
                Head = node;
                previousHead.Previous = Head;
                Head.Next = previousHead;
            }
        }
        public void AddLast(Node node)
        {
            Count++;
            if (!CheckElement(node))
            {
                Node previousTail = Tail;
                Tail = node;
                previousTail.Next = Tail;
                Tail.Previous = previousTail;
            }
        }
        private bool CheckElement(Node node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = node;
                return true;
            }
            return false;
        }
    }
}
