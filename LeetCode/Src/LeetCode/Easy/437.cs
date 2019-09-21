using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

public static class LC_437
{
    /*
     路径的开头可以不是根节点，结束也可以不是叶子节点，是不是有点复杂？
    如果问题是这样：找出以根节点为开始，任意节点可作为结束，且路径上的节点和为 sum 的路径的个数；
    是不是前序遍历一遍二叉树就可以得到所有这样的路径？是的；
    如果这个问题解决了，那么原问题可以分解成多个这个问题；
    是不是和数线段是同一个问题，只不过线段变成了二叉树；
    在解决了以根节点开始的所有路径后，就要找以根节点的左孩子和右孩子开始的所有路径，三个节点构成了一个递归结构；
    递归真的好简单又好难；

    作者：li-xin-lei
    链接：https://leetcode-cn.com/problems/path-sum-iii/solution/leetcode-437-path-sum-iii-by-li-xin-lei/
    来源：力扣（LeetCode）
    著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
*/
    public static void Func()
    {
    }

    public static int PathSum(TreeNode root, int sum)
    {
        if (root == null) return 0;
        // 以根为起点的所有路径总和
        // + 以左子树为根节点的所有路径总和
        // + 以右子树为根节点的所有路径总和
        return Paths(root, sum) + PathSum(root.left, sum) + PathSum(root.right, sum);
    }
    private static int Paths(TreeNode root, int sum)
    {
        if (root == null) { return 0; }
        int res = 0;
        if (root.val == sum) { res += 1; }
        // 这里巧妙的是：利用sum减法计算
        res += Paths(root.left, sum - root.val);
        res += Paths(root.right, sum - root.val);
        return res;
    }
}