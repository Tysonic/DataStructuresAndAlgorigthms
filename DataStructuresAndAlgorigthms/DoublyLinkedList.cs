using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorigthms
{
    internal class DoublyLinkedList
    {
        public Node? head;

        public class Node
        {
            public Node? next;
            public Node? prev;
            public int? data;
            public Node(int? input)
            {
                data = input;
                next = null;
                prev = null;
            }

        }
        public void PushAtStart(int? input)
        {
            Node new_node = new(input);
            if (head == null)
            {
                head = new_node;
                return;
            }
            new_node.next = head;
            head.prev = new_node;
            head = new_node;
        }
        public void PushAtEnd(int? input)
        {
            Node new_node = new(input);
            if (head == null)
            {
                head = new_node;
                return;
            }
            Node temp = head;

            while (temp.next != null)
            {
                temp=temp.next;
            }
            temp.next = new_node;
            new_node.prev = temp;
            
        }
        public void PrintList()
        {
            Node node = head;
            if (head != null)
            {

                do 
                {
                    Console.WriteLine(head.data);
                    head = head.next;
                }
                while (head != node);
            }
            Console.WriteLine(head.data);
        }
    }
}
