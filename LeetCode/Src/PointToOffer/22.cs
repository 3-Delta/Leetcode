using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 是否为出栈序列
public static class _22
{
    public static void Func()
    {
        int[] left = new int[] { 1, 2, 3, 4, 5 };
        int[] right1 = new int[] { 4, 5, 3, 2, 1 };
        int[] right2 = new int[] { 1, 2, 3, 4, 5 };
        int[] right3 = new int[] { 5, 4, 3, 2, 1 };
        int[] right4 = new int[] { 4, 3, 5, 1, 2 };

        Console.WriteLine(IsPopSequence(left, right1));
        Console.WriteLine(IsPopSequence(left, right2));
        Console.WriteLine(IsPopSequence(left, right3));
        Console.WriteLine(IsPopSequence(left, right4));

        Console.WriteLine(IsPopSequence(new int[] { 1}, new int[] { 1 }));
    }

    public static bool IsPopSequence(int[] left, int[] right)
    {
        bool ret = false;
        if (left != null && right != null && left.Length == right.Length)
        {
            Stack<int> stack = new Stack<int>();
            int leftLIndex = 0;
            ret = true;
            for (int i = 0, count = right.Length; i < count; ++i)
            {
                int t = right[i];
                if (stack.Count > 0 && stack.Peek() == t)
                {
                    stack.Pop();
                }
                else
                {
                    int targetIndex = Array.IndexOf(left, t);
                    if (targetIndex != -1 && targetIndex >= leftLIndex)
                    {
                        for (int j = leftLIndex; j <= targetIndex; ++j)
                        {
                            stack.Push(left[j]);
                        }
                        stack.Pop();
                        leftLIndex = targetIndex + 1;
                    }
                    else
                    {
                        ret = false;
                    }
                }
            }
        }
        return ret;
    }
}