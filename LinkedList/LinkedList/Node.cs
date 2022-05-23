using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
     class Node
     {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
     }
    internal class List
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        public void InsertFirst(int data)
        {
            Node Node = new Node(data);
            if (this.head == null)
            {
                head = Node;
            }
            else
            {
                Node.next = head;
                head = Node;
            }
        }

        public void InsertInBetween(int position, int data)
        {
            Node Node = new Node(data);
            if (position == 1)
            {
                Node.next = this.head;
                head = Node;
            }
            else if (position < 1)
            {
                Console.WriteLine(" Value less than 1! Invalid Position.");
            }
            else if (position > 0)
            {
                Node temp = head;
                while (position >= 0)
                {
                    if (position == 2)
                    {
                        Node.next = temp.next;
                        temp.next = Node;
                        break;
                    }
                    temp = temp.next;
                    position--;
                }

            }
        }
        public void Pop()
        {
            Console.WriteLine("Poped element is: {0}", head.data);
            this.head = this.head.next;
            Display();
        }
        public void PopLast()
        {
            Node temp = this.head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
            Console.WriteLine("After deleting last element ");
            Display();
        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}