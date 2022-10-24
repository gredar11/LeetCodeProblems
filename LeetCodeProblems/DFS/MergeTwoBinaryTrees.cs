using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeProblems.DFS.InvertBinaryTree;

namespace LeetCodeProblems.DFS
{
    public class MergeTwoBinaryTrees
    {
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 == null || root2 == null)
            {
                return root1 ?? root2;
            }
            Queue<TreeNode> queue1 = new Queue<TreeNode>();
            Queue<TreeNode> queue2 = new Queue<TreeNode>();
            queue1.Enqueue(root1);
            queue2.Enqueue(root2);
            TreeNode resultNode = null;
            while (queue1.Count > 0 && queue2.Count > 0)
            {
                TreeNode node1 = null;
                TreeNode node2 = null;
                node1 = queue1.Dequeue();
                node2 = queue2.Dequeue();
                resultNode = node1 ?? node2;
                if (node1 != null && node2 != null)
                {
                    queue1.Enqueue(node1.left);
                    queue2.Enqueue(node2.left);
                    queue1.Enqueue(node1.right);
                    queue2.Enqueue(node2.right);
                    resultNode.val = node1.val + node2.val;
                    resultNode.left = node1.left ?? node2.left;
                    resultNode.right = node1.right ?? node2.right;
                    continue;
                }
                if (node1 == null && node2 == null)
                {
                    continue;
                }
                if (node1 == null)
                {
                    resultNode.left = node2.left;
                    queue1.Enqueue(null);
                    queue2.Enqueue(resultNode.left);
                    resultNode.right = node2.right;
                    queue1.Enqueue(null);
                    queue2.Enqueue(resultNode.right);
                    continue;
                }
                if (node2 == null)
                {
                    resultNode.left = node1.left;
                    queue1.Enqueue(resultNode.left);
                    queue2.Enqueue(null);
                    resultNode.right = node1.right;
                    queue1.Enqueue(resultNode.right);
                    queue2.Enqueue(null);
                    continue;
                }
            }
            return root1 ?? root2;
        }
    }
}
