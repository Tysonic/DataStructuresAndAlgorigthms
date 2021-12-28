using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorigthms
{
    public class Scratch
    {
            public StackNode head;
            public class StackNode
            {
                public char data;
                public StackNode next;
                public StackNode(char d)
                {
                    data = d;
                    next = null;
                }
            }
            public void Push(char d)
            {
                StackNode new_node = new StackNode(d);
                if (head == null)
                {
                    head = new_node;
                    return;
                }
                new_node.next = head;
                head = new_node;
            }
            public char Pop()
            {
                StackNode node = head;
                head = head.next;
                return node.data;
            }
        public string isBalanced(string s)
        {
            string ret = "YES";
            Scratch stack = new Scratch();
            var val = String.Join(" ", s);
            for (int x = 0; x < val.Length; x++) {
                if (val[x] == '[' || val[x] == '{' || val[x] == '(') stack.Push(val[x]);
                else if (val[x] == '}' && stack.head.data == '{') stack.Pop();
                else if (val[x] == ']' && stack.head.data == '[') stack.Pop();
                else if (val[x] == ')' && stack.head.data == '(') stack.Pop();
                else return "NO";
            };
            
            return ret;
        }
    }
    
}
