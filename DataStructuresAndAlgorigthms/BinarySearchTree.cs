using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorigthms
{
    public class BinarySearchTree
    {
        public Node root;
        
        public class Node
        {
            public int data;
            public Node right;
            public Node left;

            public Node(int input)
            {
                data = input;
            }
        }
        public void Inorder(Node temp)
        {
            if (temp == null) return;
            Inorder(temp.left);
            Console.WriteLine(temp.data);
            Inorder(temp.right);
        }

        public void Insert(Node temp, int val)
        {
            if (temp == null) 
            { 
                root = new Node(val);
                return; 
            }

            if (temp.data > val)
            {
                if (temp.left == null)
                {
                    temp.left = new Node(val);
                }
                else
                {
                    Insert(temp.left, val);
                }
            }
            else if(temp.data < val)
            {
                if(temp.right == null)
                {
                    temp.right = new Node(val);
                }
                else
                {
                    Insert(temp.right,val);
                }
            }
        }
        public Node DeleteNode(Node root, int X)
        {
            if (root == null)
                return root;
            if (X < root.data)
                root.left = DeleteNode(root.left, X);
            else if (X > root.data)
                root.right = DeleteNode(root.right, X);
            else
            {
                if (root.left == null)
                    return root.right;
                else if (root.right == null)
                    return root.left;
                root.data = MinValue(root.right);

                root.right = DeleteNode(root.right, root.data);
            }
            return root;
        }
        int MinValue(Node root)
        {
            int minv = root.data;
            while (root.left != null)
            {
                minv = root.left.data;
                root = root.left;
            }
            return minv;
        }
    }
    
}
