// Trie树用来判断前缀
public class TrieNode {
    public TrieNode[] child = new TrieNode[26]; //子节点数组长度26，0：‘a’，1：‘b’
    public bool isEnd = false; //记录当前节点是不是一个单词的结束字母
}
public class Trie {
    private readonly TrieNode root = new TrieNode();

    public Trie(string word) { this.Insert(word); }
    public void Insert(string word) {
        TrieNode currentNode = this.root;
        for (int i = 0 ; i < word.Length ; ++i) {
            char c = word[i];
            int index = c - 'a';
            if (currentNode.child[index] == null) {
                currentNode.child[index] = new TrieNode();
            }
            currentNode = currentNode.child[index];
        }
        currentNode.isEnd = true;//最后的节点为单词的最后一个单词，is_end设置为true
    }

    public bool Search(string word) {
        TrieNode ptr = this.root;
        for (int i = 0 ; i < word.Length ; ++i) {
            char c = word[i];
            int index = c - 'a';
            if (ptr.child[index] == null) {
                return false;
            }
            ptr = ptr.child[index];
        }
        return ptr.isEnd;
        // 如果所有字符都在前缀树中，那么判断最后一个字母结束标志是否为true，
        // 为true，返回true，说明单词找到，否则，false，没找到
    }

    public bool StartsWith(string prefix) {
        TrieNode ptr = this.root;//从根出发
        for (int i = 0 ; i < prefix.Length ; ++i) {
            char c = prefix[i];
            int index = c - 'a';
            if (ptr.child[index] == null) {
                return false;
            }
            ptr = ptr.child[index];
        }
        return true;
    }
}
