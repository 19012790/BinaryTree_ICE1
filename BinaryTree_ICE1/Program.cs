using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree_ICE1
{
    class Program //program class created
    {
        static void Main(string[] args) //main method
        {
            Node root = new Node(12); //nodes created
            Node n1 = new Node(34);
            Node n2 = new Node(23);
            Node n3 = new Node(34);
            Node n4 = new Node(4);
            Node n5 = new Node(84);

            root.left = n1;
            root.right = n2;
            n1.left = n3;
            n2.left = n4;
            n2.right = n5;

            Node nodeToFind = BinarySearchTree.Search(root, 54);
            Console.WriteLine(nodeToFind.value); //prints out node to find value

            Node newRoot = BinarySearchTree.Insert(root, 96);
            Console.WriteLine(newRoot.right.right.right.value); //prints out new root right value
            Console.WriteLine("Test phase done"); //prints out that test phase is complete
            BinarySearchTree.InOrderTraversal(newRoot);
            Console.WriteLine("traversal in order done"); //prints out traversal in order complete
            BinarySearchTree.PostOrderTraversal(newRoot);
            Console.WriteLine("traversal post order done");//prints out traversal post order complete
            BinarySearchTree.PreOrderTraversal(newRoot);
            Console.WriteLine("traversal pre order done");//prints out traversal pre order complete
            Console.ReadLine();
        }

        class Node //node class created
        {
            public int value; //value type int created
            public Node left; // left node created
            public Node right; //right node created

            public Node(int value)  
            {
                this.value = value;
            }
        }

        class BinarySearchTree //binary search tree class created
        {
            public static Node Search(Node root, int value) //node search method created
            {
                if (root == null) //if statment that compares root with null
                {
                    return new Node(-1); //returns a new node
                }
                if (root.value == value) //if statement that compares root value with value
                {
                    return root; //returns root
                }
                else if (value < root.value)  //else statment created that checks if value is less than root value 
                {
                  
                    root = Search(root.left, value); //searches the left child if value is less than root value
                }
                else if (value > root.value) //if value is greather than root value
                {
                   
                    root = Search(root.right, value); //then search the right child
                }

                return root; //returns root
            }

            public static Node Insert(Node root, int value) //node insert method
            {
                if (root.value == value) 
                {
                    return root; 

                }
                else if (value < root.value) 
                {
                    if (root.left != null)
                    {
                        root.left = Insert(root.left, value);
                    }
                    else
                    {
                        
                        Node newNode = new Node(value);
                        root.left = newNode;

                    }
                }
                else if (value > root.value)
                {
                    if (root.right != null)
                    {
                        root.right = Insert(root.right, value);
                    }
                    else
                    {
                        
                        Node newNode = new Node(value);
                        root.right = newNode;

                    }
                }

                return root;
            }

            public static void InOrderTraversal(Node root)
            {
                if (root.left != null)
                {
                    InOrderTraversal(root.left);
                }
                Console.WriteLine(root.value);

                if (root.right != null)
                {
                    InOrderTraversal(root.right);
                }
            }

            public static void PostOrderTraversal(Node root)
            {
                if (root.left != null)
                {
                    PostOrderTraversal(root.left);
                }

                if (root.right != null)
                {
                    PostOrderTraversal(root.right);
                }

                Console.WriteLine(root.value);
            }

            public static void PreOrderTraversal(Node root)
            {
                Console.WriteLine(root.value);

                if (root.left != null)
                {
                    PreOrderTraversal(root.left);
                }

                if (root.right != null)
                {
                    PreOrderTraversal(root.right);
                }
            }
        }
    }
}
     