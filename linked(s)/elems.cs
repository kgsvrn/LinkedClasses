using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace linked_s_
{

    public class LinkedList<T> : IEnumerable<T>
    {
        public class Node<T>
        {
         
            public Node<T> Next = null;
          
            public T Data;
        }

        private Node<T> root = null;

        public Node<T> First { get { return root; } }

        public Node<T> Last
        {
            get
            {
                Node<T> curr = root;
                if (curr == null)
                    return null;
                while (curr.Next != null)
                    curr = curr.Next;
                return curr;
            }
        }

        public T PrintLast { get { return Last.Data; }  }
        public T PrintFirst { get { return First.Data; } }

        public void Append(T value)
        {
            Node<T> n = new Node<T> { Data = value };
            if (root == null)
                root = n;
            else
                Last.Next = n;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = root;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }


}
    

