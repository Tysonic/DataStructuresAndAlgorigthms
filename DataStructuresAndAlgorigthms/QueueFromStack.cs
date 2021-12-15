using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorigthms
{
    internal class QueueFromStack
    {
        LLStacks stacks1 = new LLStacks();
        LLStacks stacks2 = new LLStacks();

        public void EnQueue(int input)
        {
            while (stacks1.head != null)
            {
                stacks2.Push(stacks1.Pop());
            }
            stacks2.Push(input);
            while(stacks2.head != null)
            {
                stacks1.Push(stacks2.Pop());
            }
        }

        public void DeQueue()
        {
            if (stacks1.head != null) return;
                stacks1.Pop();
            
        }
        public void PrintQueue()
        {
            stacks1.PrintStacks();
        }
    }
}
