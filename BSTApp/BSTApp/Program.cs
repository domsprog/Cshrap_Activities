using BST_Library;
using BST_Library.Methods.Funtions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BSTApp
{
  public  class Program
    {
        static void Main()
        {
            BST_MainClass bst = new BST_MainClass();
            bool exit = false;

            while (!exit)
            {
                
                Console.WriteLine("\n=== Binary Search Tree Application ===");
                Console.WriteLine("1. Insert Number");
                Console.WriteLine("2. Display Tree");
                Console.WriteLine("3. Traversals");
                Console.WriteLine("4. Analytics");
                Console.WriteLine("5. Exit");
                Console.Write("Choose: ");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter a number: ");
                        int value = int.Parse(Console.ReadLine());
                        bst.Insert(value);
                        break;

                    case "2":
                        Console.WriteLine("\nTree Structure:");
                        bst.DisplayTree(bst.Root);
                        break;

                    case "3":
                        Console.WriteLine("\nInorder: ");
                        bst.Inorder(bst.Root);
                        Console.WriteLine("\nPreorder: ");
                        bst.Preorder(bst.Root);
                        Console.WriteLine("\nPostorder: ");
                        bst.Postorder(bst.Root);
                       
                        break;

                    case "4":
                        Console.WriteLine($"\nMinimum: {bst.FindMin(bst.Root)}");
                        Console.WriteLine($"Maximum: {bst.FindMax(bst.Root)}");
                        Console.WriteLine($"Total Nodes: {bst.CountNodes(bst.Root)}");
                        Console.WriteLine($"Leaf Nodes: {bst.CountLeafNodes(bst.Root)}");
                        Console.WriteLine($"Height: {bst.GetHeight(bst.Root)}");
                        break;

                    case "5":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}