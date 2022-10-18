using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.DFS
{
    public class InvertBinaryTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public TreeNode InvertTree(TreeNode root)
        {
            var newRoot = root;
            int layer = 0;
            TreeNode[] roots = new TreeNode[1] {root};
            while(roots.All(x => x is null))
            {
                int countOfNodes = (int)Math.Pow(2.0, layer);
                int

            }
        }
    }
}
