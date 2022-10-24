using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeProblems.DFS.InvertBinaryTree;

namespace LeetCodeProblems.DFS
{
    public class MinAndMaxDepthOfBinaryTree
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            List<TreeNode> currentLayer = new List<TreeNode>();
            currentLayer.Add(root);
            int depth = 1;
            while (currentLayer.Count > 0)
            {
                List<TreeNode> nextLayer = new List<TreeNode>();
                foreach (var node in currentLayer)
                {
                    if (node.left == null && node.right == null)
                    {
                        return depth;
                    }
                    if (node.left is not null)
                    {
                        nextLayer.Add(node.left);
                    }
                    if (node.right is not null)
                    {
                        nextLayer.Add(node.right);
                    }
                }
                depth++;
                currentLayer = nextLayer;
            }
            return depth;
        }
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            List<TreeNode> currentLayer = new List<TreeNode>();
            currentLayer.Add(root);
            int depth = 1;
            while (currentLayer.Count > 0)
            {
                List<TreeNode> nextLayer = new List<TreeNode>();
                foreach (var node in currentLayer)
                {
                    if (node.left is not null)
                    {
                        nextLayer.Add(node.left);
                    }
                    if (node.right is not null)
                    {
                        nextLayer.Add(node.right);
                    }
                }
                if (nextLayer.Count == 0)
                    return depth;
                depth++;
                currentLayer = nextLayer;
            }
            return depth;
        }
    }
}
