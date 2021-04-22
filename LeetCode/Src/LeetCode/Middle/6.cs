using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_6 {
    public static void Func() {
        Convert("PAYPALISHIRING", 3);
        Convert("A", 1);
    }


    public static string Convert(string s, int numRows) {
        // "A", 1  这种需要特殊处理，j += gap 否则死循环
        if (numRows <= 1) {
            return s;
        }

        StringBuilder sb = new StringBuilder();
        int i = 0;
        // 因为竖直方向上，z会缺少2行
        int gap = numRows + (numRows - 2);
        int count = s.Length;
        while (i < numRows) {
            for (int j = i ; j < count ; j += gap) {
                sb.Append(s[j]);

                // 非第一行和最后一行
                // 也就是中间行，(j + gap)是下一个index, 计算下一个之前的index
                int tIndex = (j + gap) - 2 * i;
                if (i != 0 && i != numRows - 1 && tIndex < count) {
                    sb.Append(s[tIndex]);
                }
            }

            ++i;
        }
        return sb.ToString();
    }
}