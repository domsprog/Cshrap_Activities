using System;
using BST_Library.Methods.Node;

/* <Summary>

 The BST class is responsible for creating and managing a Binary Search Tree (BST).
 It keeps track of the root node and allows adding new values to the tree.
 The Insert method adds data by placing each value in the correct position based on BST rules 
 (smaller values go to the left, larger ones to the right).
 The DisplayTree method neatly prints the tree structure in the console, 
 showing how the nodes are connected.

</Summary>
*/

namespace BST_Library.Methods.Funtions
{
    public class BST
    {
        public TreeNode Root;
        public void Insert(int data)
        {
            Root = InsertRec(Root, data);
        }
         public TreeNode InsertRec(TreeNode root, int data)
        {
            if (root == null)
            {
                root = new TreeNode(data);
                return root;
            }
            if (data < root.Data)
                root.Left = InsertRec(root.Left, data);
            else if (data > root.Data)
                root.Right = InsertRec(root.Right, data);
            return root;
        }
        public void DisplayTree(TreeNode root, string indent ="",  bool isLeft = true ) 
        { 
            if (root != null) 
            { 
                Console.WriteLine(indent + (isLeft ? "├── " : "└── ") + root.Data); 
                DisplayTree(root.Left, indent + (isLeft ? "│   " : "    "), true); 
                DisplayTree(root.Right, indent + (isLeft ? "│   " : "    "), false);
            }
        }
    }
}
