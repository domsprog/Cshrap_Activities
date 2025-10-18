using System;
using BST_Library.Methods.Node;

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
