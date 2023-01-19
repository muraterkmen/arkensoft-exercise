using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkensoft.Exercise
{

    /// <summary>
    /// iven the root of a binary tree, invert the tree, and return its root.
    /// Input: root = [4,2,7,1,3,6,9]
    /// Output: [4,7,2,9,6,3,1]
    /// 226. Invert Binary Tree
    /// leetcode.com
    /// </summary>
    public class InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return root;
            }

            TreeNode left = InvertTree(root.left);
            TreeNode right = InvertTree(root.right);

            root.left = right;
            root.right = left;

            return root;
        }

        public void PrintRightToLeft(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Console.Write(root.val + " ");

            PrintRightToLeft(root.left);
            PrintRightToLeft(root.right);

        }

        public int NumberOfLeaves(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.left == null && root.right == null)
            {
                return 1;
            }
            else
            {
                return NumberOfLeaves(root.left) + NumberOfLeaves(root.right);
            }
        }
    }
}
