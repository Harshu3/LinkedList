using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Custom_LinkedList
    {
        public Node head;

        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} is added to linkedlist", newNode.data);
            }
            else
            {
                Node temp = GetLastNode();
                temp.next = newNode;
                Console.WriteLine("{0} is added to linkedlist", newNode.data);
            }
        }

        public void Display()
        {
            if (head == null)
                Console.WriteLine("Linkedlist is empty");
            else
            {
                Node temp = head;
                Console.WriteLine("\nNodes are:");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine("\n");
            }
        }

        private Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
                temp = temp.next;
            return temp;
        }
    }

}
