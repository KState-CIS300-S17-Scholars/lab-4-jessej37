using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    class SeiveList : IEnumerable<int>
    {
        Node head, tail;

        public SeiveList(int b)
        {
            BuildList(b);
        }

        public void BuildList(int bound)
        {
            head = new Node(2);
            Node last = head;

            for(int i = 2; i < bound; i++)
            {
                Node current = new Node(i);
                last.next = current;
                last = current;
            }

            tail = new Node(bound);
            last.next = tail;
        }

        public void FindPrimes()
        {
            Node current = head;
            while(current.data <= Math.Sqrt(tail.data))
            {
                Node before = current, during = current.next;

                do
                {
                    if (during.data % current.data == 0)
                    {
                        before.next = during.next;
                        during = during.next;
                    }
                    else
                    {
                        before = before.next;
                        during = during.next;
                    }
                }
                while (during != null);

                current = current.next;
            }
            

        }

        public IEnumerator<int> GetEnumerator()
        {
            return new SeiveEnumerator(head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new SeiveEnumerator(head);
        }

        class SeiveEnumerator : IEnumerator<int>
        {
            Node current;

            public SeiveEnumerator(Node c)
            {
                current = new Node(1337, c);
            }

            public int Current
            {
                get
                {
                    return current.data;
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return current.data;
                }
            }

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                if(current == null)
                {
                    return false;
                }
                else
                {
                    current = current.next;
                    return (current != null);
                }
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }

        class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }

            public Node(int d, Node n)
            {
                data = d;
                next = n;
            }

        }
    }
}
