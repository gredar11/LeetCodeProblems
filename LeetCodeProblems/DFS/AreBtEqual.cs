using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeProblems.DFS.InvertBinaryTree;

namespace LeetCodeProblems.DFS
{
    public class AreBtEqual
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            Queue<TreeNode[]> queue = new Queue<TreeNode[]>();
            queue.Enqueue(new TreeNode[] { p, q });
            while(queue.Count > 0)
            {
                var pair = queue.Dequeue();
                bool oneIsNull = pair[0] is null ^ pair[1] is null;
                if (pair[0] is null && pair[1] is null)
                {
                    continue;
                }
                if (oneIsNull || pair[0].val != pair[1].val)
                {
                    return false;
                }
                queue.Enqueue(new TreeNode[] { pair[0].left, pair[1].left });
                queue.Enqueue(new TreeNode[] { pair[0].right, pair[1].right });
            }
            return true;
        }
    }
}
