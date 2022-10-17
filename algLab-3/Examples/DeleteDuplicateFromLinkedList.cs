using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace algLab_3.Examples
{

    class List
    {
        Node head;
        class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        void removeDuplicates()
        {
            Node ptr1 = null, ptr2 = null;
            ptr1 = head;


            while (ptr1 != null && ptr1.next != null)
            {
                ptr2 = ptr1;

                while (ptr2.next != null)
                {

                    if (ptr1.data == ptr2.next.data)
                        ptr2.next = ptr2.next.next;
                    
                    else 
                        ptr2 = ptr2.next;
                }
                ptr1 = ptr1.next;
            }
        }




        void printList(Node node)
        {
            while (node != null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }
        }

        public static void ShowResult()
        {
            List list = new List();
            list.head = new Node(10);
            list.head.next = new Node(12);
            list.head.next.next = new Node(11);
            list.head.next.next.next = new Node(11);
            list.head.next.next.next.next = new Node(12);
            list.head.next.next.next.next.next = new Node(11);
            list.head.next.next.next.next.next.next = new Node(10);

            Console.WriteLine("Связный лист до удаления одинаковых элементов: ");
            list.printList(list.head);

            list.removeDuplicates();
            Console.WriteLine("");
            Console.WriteLine("Связный лист после удаления одинаковых элементов: ");
            list.printList(list.head);
        }
    }
}
