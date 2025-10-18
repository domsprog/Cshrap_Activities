using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/* <Summary>

 The TreeNode class represents a single node in a Binary Search Tree (BST).
 Each node holds an integer value (Data) and has two possible child nodes: Left and Right.

 - Data: Stores the value of the current node.
 - Left: Points to the left child node (contains smaller values).
 - Right: Points to the right child node (contains larger values).
 - ToString(): Returns the node’s data as a string for easy display.
 - Constructor: Initializes a new TreeNode with the given data and sets its child nodes to null.

</Summary>
*/ 

namespace BST_Library.Methods.Node
{
    public  class TreeNode
    {
        public int Data;
        public TreeNode? Left;
        public TreeNode? Right; 
        public override string ToString()
        {
            return Data.ToString();
        }
        public  TreeNode(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
