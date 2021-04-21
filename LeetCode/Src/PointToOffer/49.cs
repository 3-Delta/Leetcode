using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _49 {
    public static void Func() {
        string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
        GroupAnagrams(strs);
    }

    // string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
    public static IList<IList<string>> GroupAnagrams(string[] strs) {
        List<IList<string>> ret = new List<IList<string>>();

        StringBuilder sb = new StringBuilder();
        Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
        for (int i = 0, lengthI = strs.Length ; i < lengthI ; ++i) {
            var str = strs[i];
            int[] arr = new int[26];
            // 主要是利用这个int[26]数组将无需的string转换为有序的char出现的次数的表达
            // 然后从0到26-1便利为stringbuilder得到一个通用的string表达
            for (int j = 0, lengthJ = str.Length ; j < lengthJ ; ++j) {
                char c = str[j];
                ++arr[c - 'a'];
            }

            for (int k = 0, length = 26 ; k < length ; ++k) {
                sb.Append((char)(arr[k] + (int)'a'));
            }

            var s = sb.ToString();
            sb.Clear();
            if (!dict.TryGetValue(s, out List<int> ls)) {
                ls = new List<int>();
                dict.Add(s, ls);
            }
            ls.Add(i);
        }

        foreach (var kvp in dict) {
            IList<string> ls = new List<string>();
            ret.Add(ls);

            for (int i = 0, length = kvp.Value.Count ; i < length ; ++i) {
                ls.Add(strs[kvp.Value[i]]);
            }
        }

        return ret;
    }
}