using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_14
{
    public static void Func()
    {
        string ret = LongestCommonPrefix(new string[3] { "flower","flow", "flight"});
        Console.Write(ret);
    }
    private static string LongestCommonPrefix(string[] strs)
    {
        string ret = "";
        if (strs.Length > 1)
        {
            int i = 0;
            bool canContinue = true;
            while (canContinue)
            {
                for (int j = 0; j < strs.Length - 1; ++j)
                {
                    if (i >= strs[j].Length || i >= strs[j + 1].Length || strs[j][i] != strs[j + 1][i])
                    {
                        canContinue = false;
                        break;
                    }
                }
                if (canContinue)
                {
                    ++i;
                }
            }
            ret = strs[0].Substring(0, i);
        }
        else if(strs.Length == 1)
        {
            ret = strs[0];
        }
        
        return ret;
    }
}