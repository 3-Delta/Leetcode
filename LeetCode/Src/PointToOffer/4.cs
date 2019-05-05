using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _4
{
    private static string str = "We are Happy.";

    public static void Func()
    {
        int count = 0;
        foreach (char i in str)
        {
            if (i == ' ') { ++count; }
        }

        int capacity = str.Length + count * (3 - 1);
        char[] chars = new char[capacity];
        int j = capacity - 1;
        for (int i = str.Length - 1; i >= 0; --i)
        {
            if (str[i] != ' ')
            {
                chars[j--] = str[i];
            }
            else
            {
                chars[j--] = '0';
                chars[j--] = '2';
                chars[j--] = '%';
            }
        }

        Console.WriteLine(chars.ToArray());
        Console.WriteLine("Over!");
    }
}