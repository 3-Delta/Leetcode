using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Trie
{
    private bool isTrie;
    private int len;
    // 所有子节点，供26个
    public Trie[] tries = new Trie[26];

    public Trie()
    {
        isTrie = false;
    }
    public void Insert(string str)
    {
        if (str.Length == 0)
        {
            return;
        }
        int i = 0;
        while (i < str.Length)
        {
            if (tries[str[i] - 'a'] == null)
            {
                tries[str[i] - 'a'] = new Trie();
            }
            ++i;
        }

        isTrie = true;
        len = i;
    }
}
