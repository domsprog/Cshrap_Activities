using BST_Library.Methods.Node;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
/*
 <Summary>

 The Analytics class gives the analytical functions on this BST project, which executes the following:
 - FindMin(TreeNode root): Finds and returns the smallest value in the tree.
 - FindMax(TreeNode root): Finds and returns the largest value in the tree.
 - CountNodes(TreeNode root): Counts and returns the total number of nodes in the tree.
 - CountLeafNodes(TreeNode root): Counts and returns the number of leaf nodes (nodes with no children).
 - GetHeight(TreeNode root): Calculates and returns the height of the tree (the longest path from root to a leaf).

</Summary>     
 */

namespace BST_Library.Methods.Funtions
{
    public class Analytics
    {
        public int FindMin(TreeNode root)
        {
            if (root == null) return int.MinValue;
            while (root.Left != null)
                root = root.Left;
            return root.Data;
        }
        public int FindMax(TreeNode root)
        {
            if (root == null) return int.MaxValue;
            while (root.Right != null)
                root = root.Right;
            return root.Data;
        }
        public int CountNodes(TreeNode root)
        {
            if (root == null) return 0;
            return 1 + CountNodes(root.Left) + CountNodes(root.Right);
        }
        public int CountLeafNodes(TreeNode root)
        {
            if (root == null) return 0;
            if (root.Left == null && root.Right == null) return 1;
            return CountLeafNodes(root.Left) + CountLeafNodes(root.Right);
        }
        public int GetHeight(TreeNode root)
        {
            if (root == null) return 0;
            int leftHeight = GetHeight(root.Left);
            int rightHeight = GetHeight(root.Right);
            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
