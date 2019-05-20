using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _33
{
    public static int[] array = new int[] { 3, 32, 321, 4 };

    public static void Func()
    {
        Array.Sort(array, Compare);

        string ret = "";
        for (int i = 0; i < array.Length; ++i)
        {
            ret += (array[i]);
        }
        Console.WriteLine(ret);
    }

    // 从小到大
    public static int Compare(int left, int right) // 是否left > right，返回1
    {
        int ret = 1;
        string l = left.ToString();
        string r = right.ToString();

        int ll = 0;
        int rr = 0;
        while (ll < l.Length && rr < r.Length)
        {
            if (l[ll] > r[rr])
            {
                ret = 1;
                break;
            }
            else if (l[ll] < r[rr])
            {
                ret = -1;
                break;
            }
            else
            {
                ++ll;
                ++rr;
            }
        }

        // 谁长谁小
        ret = (l.Length - r.Length > 0) ? -1 : 1;
        return ret;
    }
}