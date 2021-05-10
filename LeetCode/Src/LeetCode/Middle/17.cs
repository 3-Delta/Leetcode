using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;


public static class LC_17 {
    public static void Func() {

    }

    public static Dictionary<char, List<char>> dict = new Dictionary<char, List<char>>() {
        { '2', new List<char>(){'a', 'b', 'c' } },
        { '3', new List<char>(){'d', 'e', 'f' } },
        { '4', new List<char>(){ 'g', 'h', 'i' } },
        { '5', new List<char>(){'j', 'k', 'l' } },
        { '6', new List<char>(){'m', 'n', 'o' } },
        { '7', new List<char>(){ 'p', 'q', 'r', 's' } },
        { '8', new List<char>(){ 'u', 'u', 'v' } },
        { '9', new List<char>(){ 'w', 'x', 'y', 'z' } },
    };

    public static IList<string> LetterCombinations(string digits) {
        List<string> ls = new List<string>();
        if (digits.Length > 0) {
            StringBuilder sb = new StringBuilder();
            LetterCombinations(digits, 0, sb, ls);
        }
        
        return ls;
    }

    public static void LetterCombinations(string digits, int index, StringBuilder sb, List<string> ls) {
        if (index < digits.Length) {
            char key = digits[index];
            for (int i = 0, length = dict[key].Count ; i < length ; ++i) {
                sb.Append(dict[key][i]);
                LetterCombinations(digits, index + 1, sb, ls);
                sb.Remove(sb.Length - 1, 1);
            }
        }
        else {
            ls.Add(sb.ToString());
        }
    }
}