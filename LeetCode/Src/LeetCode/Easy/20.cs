using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_20
{
    public static void Func()
    {
    }

    // 最终结果是：判断stack中元素是否为0
    // 如果匹配，stack会出栈
    // 不匹配则继续入栈
    public static bool Match(string s)
    {
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; ++i)
        {
            if (stack.Count > 0)
            {
                char top = stack.Peek();
                if (!IsMatch(top, s[i]))
                {
                    stack.Push(s[i]);
                }
                else
                {
                    stack.Pop();
                }
            }
            else
            {
                stack.Push(s[i]);
            }
        }
        return stack.Count <= 0;
    }

    private static bool IsMatch(char left, char right)
    {
        if (left == '(' && right == ')') return true;
        if (left == '[' && right == ']') return true;
        if (left == '{' && right == '}') return true;
        return false;
    }
}