using static LeetCodeProblems.DFS.InvertBinaryTree;

namespace LeetCodeProblems.DFS
{
    public class BinaryTreeLeafHasSum
    {
        public static bool IsLeaf(TreeNode node) => node.left is null && node.right is null;
        public bool HasPathSumOutOfMemory(TreeNode root, int targetSum) // out of memory on leetcode
        {
            if (root is null)
                return false;
            int layer = 1;
            (TreeNode, int)[] roots = new (TreeNode, int)[1] { (root, root.val) };
            while (roots.Any(x => x.Item1 is not null))
            {
                int countOfChildren = (int)Math.Pow(2.0, layer);
                (TreeNode, int)[] children = new (TreeNode, int)[countOfChildren];
                for (int i = 0; i < countOfChildren; i += 2)
                {
                    int parentIndex = i / 2;
                    if (roots[parentIndex].Item1 is null)
                        continue;
                    if (IsLeaf(roots[parentIndex].Item1) && roots[parentIndex].Item2 == targetSum)
                    {
                        return true;
                    }
                    children[i] = (roots[parentIndex].Item1.left,
                        (roots[parentIndex].Item1.left is not null ? roots[parentIndex].Item1.left.val : 0) + roots[parentIndex].Item2);
                    children[i + 1] = (roots[parentIndex].Item1.right,
                        (roots[parentIndex].Item1.right is not null ? roots[parentIndex].Item1.right.val : 0) + roots[parentIndex].Item2);
                }
                roots = children;
                layer++;
            }
            return false;
        }
        public bool HasPathSum(TreeNode root, int targetSum) // out of memory on leetcode
        {
            if(root == null)
                return false;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (IsLeaf(node))
                {
                    if (node.val == targetSum)
                        return true;
                    continue;
                }
                if (node.left is not null)
                {
                    node.left.val += node.val;
                    queue.Enqueue(node.left);
                }
                if (node.right is not null)
                {
                    node.right.val += node.val;
                    queue.Enqueue(node.right);
                }
            }
            return false;
        }
    }
}
