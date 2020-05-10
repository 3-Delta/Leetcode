using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_236
{
    public static void Func()
    {
        
    }

    public class Wrapper
    {
        public TreeNode node = null;
        public bool hasTraveled = false;

        public Wrapper() { }
        public Wrapper(TreeNode node, bool hasTraveled)
        {
            this.node = node;
            this.hasTraveled = hasTraveled;
        }
    }
    public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        /*
            从根节点开始遍历整棵二叉树，用哈希表记录每个节点的父节点指针。
            从 p 节点开始不断往它的祖先移动，并用数据结构记录已经访问过的祖先节点。
            同样，我们再从 q 节点开始不断往它的祖先移动，如果有祖先已经被访问过，即意味着这是 p 和 q 的深度最深的公共祖先，即 LCA 节点。
        */
        Dictionary<TreeNode, Wrapper> hash = new Dictionary<TreeNode, Wrapper>();
        Travel(root, null, hash);

        TreeNode node = null;
        while (p != null)
        {
            // 记录走向root节点的路径
            hash[p].hasTraveled = true;
            p = hash[p].node;
        }
        while (q != null)
        {
            // 如果之前p走过
            if (hash[q].hasTraveled)
            {
                node = q;
                break;
            }
            else
            {
                q = hash[q].node;
            }
        }
        return node;
    }

    // 获取每个树节点的parnet信息，类似形成一个交叉链表的结构
    public static void Travel(TreeNode root, TreeNode parent, Dictionary<TreeNode, Wrapper> hash)
    {
        if (root != null)
        {
            Wrapper warpper = new Wrapper(parent, false);
            hash.Add(root, warpper);
            Travel(root.left, root, hash);
            Travel(root.right, root, hash);
        }
    }
}