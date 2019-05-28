using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _21
{
    public class MinStack
    {
        public int Min()
        {
            {
                int ret = 0;
                if (stackMin.Count > 0)
                {
                    ret = stackMin.Peek();
                }
                Console.WriteLine(ret);
                return ret;
            }
        }
        public Stack<int> stack1 = new Stack<int>();
        public Stack<int> stackMin = new Stack<int>();

        public void Push(int value)
        {
            stack1.Push(value);
            if (stackMin.Count > 0)
            {
                int top = stackMin.Peek();
                if (top > value)
                {
                    stackMin.Push(value);
                }
                else
                {
                    stackMin.Push(top);
                }
            }
            else
            {
                stackMin.Push(value);
            }
        }
        public int Pop()
        {
            stack1.Pop();
            return stackMin.Pop();
        }
    }
    public static void Func()
    {
        MinStack minStack = new MinStack();
        minStack.Min();
        minStack.Push(3);
        minStack.Min();
        minStack.Push(4);
        minStack.Min();
        minStack.Push(2);
        minStack.Min();
        minStack.Push(1);
        minStack.Min();
        minStack.Pop();
        minStack.Min();
        minStack.Pop();
        minStack.Min();
        minStack.Push(0);
        minStack.Min();
    }
}