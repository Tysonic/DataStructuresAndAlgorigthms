using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorigthms
{
    public class Stacks
    {
        int max;
        int[] elements;
        int top;
        public Stacks(int size)
        {
            elements = new int[size];
            top = -1;
            max = size;

        }

        public void Push(int data)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack overflow");
                return;
            }
            elements[++top] = data;
        }
        public int Pop()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack is empty");
                return int.MinValue;
            }
            Console.WriteLine("popped {0}",elements[top]);
            return elements[top--];
        }

        public int Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return int.MinValue;
            }
            Console.WriteLine("Selected element {0}", elements[top]);
            return elements[top];
        }

        public void PrintString()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
            }
            for(var x = 0; x <=top; x++)
            {
                Console.WriteLine(elements[x]); 
            }
        }

    }
}
