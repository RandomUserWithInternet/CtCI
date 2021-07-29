using System;

namespace Linked_List
{
    public class LinkedList
    {
        Node head; 
        public class Node
        {
            public int data;
            public Node next; 
            public Node(int d) { 
                data = d;
                next = null;
            }
        }
        public void printList()
        {
            Node n = head;
            while (n != null)
            {
                Console.Write(n.data + " ");
                n = n.next;
            }
            Console.WriteLine(" ");
        }

        public void DeleteDuplicates(Node current)
        {
            Node temp = current;
            while(current.next != null)
            {
                if (current.next.data == temp.data)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }
            

            if(temp.next != null)
            {
                DeleteDuplicates(temp.next);
            }
        }
        public static void Main(String[] args)
        {
            LinkedList llist = new LinkedList();
            llist.head = new Node(6);
            Node second = new Node(3);
            Node third = new Node(1);
            Node fourth = new Node(3);

            llist.head.next = second;
            second.next = third;
            third.next = fourth; 
            llist.printList();
            llist.DeleteDuplicates(llist.head);
            llist.printList();
        }
    }
}
