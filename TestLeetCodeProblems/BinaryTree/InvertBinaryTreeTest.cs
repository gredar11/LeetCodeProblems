using LeetCodeProblems.DFS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeProblems.DFS.InvertBinaryTree;

namespace TestLeetCodeProblems.BinaryTree
{
    public class InvertBinaryTreeTest
    {
        [Fact]
        public void TestInvertedTree()
        {
            TreeNode treeNode3_1 = new TreeNode(1);
            TreeNode treeNode3_2 = new TreeNode(3);
            TreeNode treeNode3_3 = new TreeNode(6);
            TreeNode treeNode3_4 = new TreeNode(9);
            TreeNode treeNode2_1 = new TreeNode(2,treeNode3_1, treeNode3_2);
            TreeNode treeNode2_2 = new TreeNode(7,treeNode3_3, treeNode3_4);
            TreeNode treeNode1_1 = new TreeNode(4,treeNode2_1, treeNode2_2);
            var helper = new InvertBinaryTree();
            var invertedTree = helper.InvertTree(treeNode1_1);
            Console.WriteLine();
        }
        [Fact]
        public void TestFindTargetLeafSum()
        {
            TreeNode treeNode3_1 = new TreeNode(1);
            TreeNode treeNode3_2 = new TreeNode(3);
            TreeNode treeNode3_3 = new TreeNode(6);
            TreeNode treeNode3_4 = new TreeNode(9);
            TreeNode treeNode2_1 = new TreeNode(2, treeNode3_1, treeNode3_2);
            TreeNode treeNode2_2 = new TreeNode(7, treeNode3_3, treeNode3_4);
            TreeNode treeNode1_1 = new TreeNode(4, treeNode2_1, treeNode2_2);
            var helper = new BinaryTreeLeafHasSum();
            var invertedTree = helper.HasPathSum(treeNode1_1,7);
            Console.WriteLine();
        }
    }
}
