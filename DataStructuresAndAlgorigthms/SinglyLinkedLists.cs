using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorigthms
{
    public class SinglyLinkedLists
    {
        public Node? head;
        public class Node
        {
            public int data;
            public Node? next;
           public Node(int d)
            {
               data= d;
                next=null;
            }
        }

        public void PushToStart(int data)
        {
            Node? node = new(data);
            node.next = head;
            head = node;
        }

        public void PushToEnd(int data)
        {
            Node? node= new(data);
            Node? last= head;
            if (last == null)
            {
                head = node;
                return;
            }
            while (last.next != null)
            {
                last = last.next;
            }
            last.next = node;
        }

        public void PushToPosition(int data, int position)
        {
            int count = 0;
            Node node = new(data);
            Node? position_node = head;

            if (position == 0)
            {
                node.next = head;
                head = node;
                return;
            }
            if (head == null) return;
            while (count <= position && position_node != null)
            {

                if (count + 1 == position)
                {
                    node.next = position_node.next;
                    position_node.next = node;
                }
                position_node = position_node.next;
                count++;

            }
            if (position < 0 || position > count) Console.WriteLine(string.Format("Postision {0} is out of bound",position)); 
        }
        public void PushAfterPosition(int data, int position)
        {
            int count=0;
            Node node = new(data);
            Node? position_node = head;
            if (head == null) return;
            if (position == 0)
            {
                node.next = head.next;
                head.next= node;
                return;
            }
            while (count<=position && position_node!=null)
            {
                
                if (count == position)
                {
                    node.next = position_node.next;
                    position_node.next= node;
                }
                position_node = position_node.next;
                count++;

            }
            if (position < 0 || position > count) Console.WriteLine(string.Format("Postision {0} is out of bound", position));
        }
        public void DeleteAtStart()
        {
            if(head == null) return;
            head = head.next;
        }
        public void DeleteAtEnd()
        {
            Node? last = head;
            if (last == null) return;
            if (last.next == null) head = null;
            while(last.next != null && last.next.next!=null)
            {
                last = last.next;
            }
            last.next = null;

        }
        public void PrintItems()
        {
            Node? print = head;
            while (print != null)
            {
                Console.WriteLine(print.data);
                print = print.next;
            }
        }
        public bool FindLoop(Node h)
        {
            HashSet<Node> s = new();
            while (h != null)
            {
                if (s.Contains(h)) return true;
                s.Add(h);
                h = h.next;
            }
            return false;

        }
        public void FindAndRemoveLoop(Node h)
        {
            if (h == null || h.next == null) return;
            Node slow = h, fast=h;
            slow=slow.next;
            fast=fast.next.next;
            while (fast != null && fast.next!=null)
            {
                if (fast == slow)
                {
                        slow = h;
                        while (slow.next != fast.next)
                        {
                            slow = slow.next;
                            fast = fast.next;
                        }

                        /* since fast->next is the looping point */
                        fast.next = null; /* remove loop */
                    
                    return; }
                fast = fast.next.next;
                slow = slow.next;
            }
        }
       
    }
    
}
