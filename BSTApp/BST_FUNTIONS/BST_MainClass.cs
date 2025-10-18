using System;
using BST_Library.Methods.Node;
using BST_Library.Methods.Funtions;

/*
 <Summary>

 This class serve as a class wapper for the other classes in the BST_Library
 it connects the BST, DFS, and Analytics classes to provide
 a unified interface for Binary Search Tree operations.

This handles insertion, display, traversals (inorder, preorder, postorder),
and various analytics (finding min/max, counting nodes/leaf nodes, height calculation).

</Summary>     
 */
namespace BST_Library
{
    public class BST_MainClass
    {
        public TreeNode Root;
        private BST bst = new BST();
        private DFS dfs = new DFS();
        private Analytics analytics = new Analytics();

        //This method calls the InsertRec method from the BST class
        public void Insert(int value)
        {
            Root = bst.InsertRec(Root, value);
        }

        // This method calls the DisplayTree method from the BST class
        public void DisplayTree(TreeNode root)
        {
            bst.DisplayTree(root);
        }

        // This method calls the traversals functions from the DFS class
        public void Inorder(TreeNode root) => dfs.InOrderTraversal(root);
        public void Preorder(TreeNode root) => dfs.PreOrderTraversal(root);
        public void Postorder(TreeNode root) => dfs.PostOrderTraversal(root);

        // This method calls the analytics funtions from the Analytics class
        public int FindMin(TreeNode root) => analytics.FindMin(root);
        public int FindMax(TreeNode root) => analytics.FindMax(root);
        public int CountNodes(TreeNode root) => analytics.CountNodes(root);
        public int CountLeafNodes(TreeNode root) => analytics.CountLeafNodes(root);
        public int GetHeight(TreeNode root) => analytics.GetHeight(root);
    }
}       
