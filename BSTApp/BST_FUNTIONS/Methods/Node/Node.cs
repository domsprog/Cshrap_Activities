using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
