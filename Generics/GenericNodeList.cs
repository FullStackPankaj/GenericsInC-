using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
   public class GenericNodeList<T>
    {
        //Constructor
        private Node Head;
        public GenericNodeList()
        {
            Head = null;
        }

        //private Node Class
        private class Node
        {
            public Node(T t)
            {

            }

            public Node Next { get; set; }
            public T Data { get; set; }
        }
        public void AddHead(T genericInput)
        {
            Node myNode = new Node(genericInput);
            myNode.Next = Head;
            Head = myNode;

        }
        public IEnumerator<T> GetEnumerator()
        {
            Node current = Head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }


    }
}
