using BST_Library.Methods.Node;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* <Summary>

 The DFS class provides different ways to traverse and explore the Binary Search Tree (BST).
 It contains methods that visit each node in various orders to display or process the tree data.

  InOrderTraversal: Visits the left subtree, then the root, then the right subtree 
   (shows the values in sorted order for a BST).
   
  PreOrderTraversal: Visits the root first, then the left and right subtrees 
   (useful for copying or saving the tree structure).
   
  PostOrderTraversal: Visits the left and right subtrees first, then the root 
   (commonly used for deleting or freeing the tree).
   
  LevelOrder: Visits all nodes level by level using a queue 
   (also known as Breadth-First Search, helps visualize the tree’s structure).

</Summary>
*/ 


namespace BST_Library.Methods.Funtions
{
    public class DFS
    {
        // === Inorder Traversal (Left → Root → Right)
        public void InOrderTraversal(TreeNode node)
        {
            if (node == null) return;
            InOrderTraversal(node.Left);
            Console.Write(node.Data + " ");
            InOrderTraversal(node.Right);
        }

        // === Preorder Traversal (Root → Left → Right)
        public void PreOrderTraversal(TreeNode node)
        {
            if (node == null) return;
            Console.Write(node.Data + " ");
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }

        // === Postorder Traversal (Left → Right → Root)
        public void PostOrderTraversal(TreeNode node)
        {
            if (node == null) return;
            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.Write(node.Data + " ");
        }

    

        // === Level Order Traversal (Breadth-First Search)
        public void LevelOrder(TreeNode node)
        {
            if (node == null) return;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                TreeNode current = queue.Dequeue();
                Console.Write(current.Data + " ");

                if (current.Left != null) queue.Enqueue(current.Left);
                if (current.Right != null) queue.Enqueue(current.Right);
            }
        }
    }
}
