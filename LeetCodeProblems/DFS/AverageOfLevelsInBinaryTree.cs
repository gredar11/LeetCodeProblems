using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeProblems.DFS.InvertBinaryTree;

namespace LeetCodeProblems.DFS
{
    public class AverageOfLevelsInBinaryTree
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            List<double> averageLevels = new List<double>();
            averageLevels.Add(root.val);
            List<TreeNode> currentLayer = new List<TreeNode>();
            currentLayer.Add(root);
            while (currentLayer.Count > 0)
            {
                int countOfNotNull = 0;
                double summOfLayer = 0.0;
                List<TreeNode> nextLayer = new List<TreeNode>();

                foreach (var node in currentLayer)
                {
                    if (node.left is not null)
                    {
                        countOfNotNull++;
                        summOfLayer += node.left.val;
                        nextLayer.Add(node.left);
                    }
                    if (node.right is not null)
                    {
                        countOfNotNull++;
                        summOfLayer += node.right.val;
                        nextLayer.Add(node.right);

                    }
                }
                if (countOfNotNull == 0)
                    break;
                averageLevels.Add(summOfLayer/countOfNotNull);
                currentLayer = nextLayer;
            }
            return averageLevels;
        }
    }
}
