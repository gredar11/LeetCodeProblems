using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeProblems.DFS.InvertBinaryTree;

namespace LeetCodeProblems.DFS
{
    public class SubtreeOfAnotherTree
    {
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            Queue<TreeNode> mainqueue = new Queue<TreeNode>();
            mainqueue.Enqueue(root);
            while(mainqueue.Count > 0)
            {
                TreeNode node = mainqueue.Dequeue();
                if (NodesAreEqual(node, subRoot))
                {
                    return true;
                }
                if(node is null)
                {
                    continue;
                }
                mainqueue.Enqueue(node.left);
                mainqueue.Enqueue(node.right);
            }
            return false;
        }
        public bool NodesAreEqual(TreeNode node1, TreeNode node2)
        {
            if(node1 == null && node2 == null)
            {
                return true;
            }
            bool oneIsNull = node1 == null ^ node2 == null;
            if (oneIsNull)
            {
                return false;
            }
            return node1.val == node2.val && NodesAreEqual(node1.left, node2.left) && NodesAreEqual(node1.right, node2.right);
        }
    }
}
