using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorigthms
{
    internal class LLStacks
    {
       public LLStackNode? head;
        public class LLStackNode
        {
            public int data;
            public LLStackNode? next;
            public LLStackNode(int input)
            {
                next = null;
                data = input;
            }
        }

        public void Push(int input)
        {
            LLStackNode new_node = new LLStackNode(input);
            new_node.next = head;
            head = new_node;
        }
        public int Pop()
        {
            if (head == null) return int.MinValue;
            LLStackNode node = head;
            head=head.next;
            return node.data;
        }
        public void PrintStacks()
        {
            if (head == null) Console.WriteLine("Stack is empty");
            LLStackNode temp = head;
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        public string ClearStack()
        {
            head = null;
            return "Cleared stack";
        }
    }
}
