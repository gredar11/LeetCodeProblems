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
            int layer = 1;
            TreeNode[] roots = new TreeNode[1] {root};
            while(roots.Any(x => x is not null))
            {
                int countOfChildren = (int)Math.Pow(2.0, layer);
                TreeNode[] children = new TreeNode[countOfChildren];
                for(int i = 0; i < countOfChildren; i+=2)
                {
                    int parentIndex = i / 2;
                    if (roots[parentIndex] is null)
                        continue;
                    var temp = roots[parentIndex].left; // left
                    roots[parentIndex].left = roots[parentIndex].right;
                    roots[parentIndex].right = temp;
                    children[i] = roots[parentIndex].left;
                    children[i+1] = roots[parentIndex].right;
                }
                roots = children;
                layer++;
            }
            return root;
        }
    }
}
