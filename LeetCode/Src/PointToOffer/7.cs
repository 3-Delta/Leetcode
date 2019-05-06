using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _7
{
    private static Stack<int> stack1 = new Stack<int>();
    private static Stack<int> stack2 = new Stack<int>();

    private static Queue<int> queue1 = new Queue<int>();
    private static Queue<int> queue2 = new Queue<int>();

    public static void Func()
    {
        
    }
    public static void Enqueue(int value)
    {
        stack1.Push(value);
    }
    public static int Dequeue()
    {
        int ret = -1;
        if (stack2.Count <= 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Peek());
                stack1.Pop();
            }
        }

        if (stack2.Count <= 0)
        {
            throw new Exception("Error!");
        }
        else
        {
            ret = stack2.Peek();
            stack2.Pop();
        }

        return ret;
    }

    public static void Push(int value)
    {

    }
    public static int Push()
    {
        int ret = -1;
        return ret;
    }
}