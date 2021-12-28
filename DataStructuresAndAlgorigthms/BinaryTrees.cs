namespace DataStructuresAndAlgorigthms
{
    public class BinaryTrees 
    {
        public TreeNode? root;
        public class TreeNode
        {
            public int key;
            public TreeNode? left;
            public TreeNode? right;
            public TreeNode(int key)
            {
                left = null;
                right = null;
                this.key = key;
            }
        }

        public void Insert(TreeNode node, int val)
        {

            if (node == null)
            {
                root = new TreeNode(val);
                return;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(node);
            while(queue.Count > 0)
            {
                 node = queue.Dequeue();
                if (node.left == null)
                {
                    node.left=new TreeNode(val);
                    break;
                }
                else
                {
                    queue.Enqueue(node.left);
                }
                if(node.right == null)
                {
                    node.right = new TreeNode(val);
                    break;
                }
                else
                {
                    queue.Enqueue(node.right);
                }
            }
        }

        public void BFT(TreeNode node)
        {
            if (node == null) return;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(node);
            while(q.Count>0)
            {
                TreeNode temp = q.Dequeue();
                Console.WriteLine(temp.key);
                if(temp.left != null)
                {
                    q.Enqueue(temp.left);
                }
                if(temp.right != null)
                {
                    q.Enqueue(temp.right);
                }
                
            }
        }

        public void Inorder(TreeNode? node)
        {
            if(node == null) return;
            Inorder(node.left);
            Console.WriteLine(node.key);
            Inorder(node.right);
        }
        public void Preorder(TreeNode? node)
        {
            if (node == null) return;
            
            Inorder(node.right);
            Console.WriteLine(node.key);
            Inorder(node.left);
            
        }

        public void Delete(TreeNode? root, int key)
        {
            if(root == null) return;
            if(root.left ==null && root.right == null)
            {
                if (root.key == key)
                {
                    root = null;
                    return;
                }
                else return;
            };
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            TreeNode temp = null, delNode = null;
            while (queue.Count > 0)
            {
                temp = queue.Dequeue();
                if(temp.key == key)
                {
                    delNode = temp;
                }
                if (temp.left != null)
                {
                    queue.Enqueue(temp.left);
                }
                if (temp.right != null)
                {
                    queue.Enqueue(temp.right);
                }
            }
            if(delNode != null && temp!=null)
            {
                int x = temp.key;
                DeleteDeepest(root, temp);
                delNode.key = x;
            }
        }

        private void DeleteDeepest(TreeNode root, TreeNode temp)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                TreeNode tempNode = queue.Dequeue();
                if (tempNode == temp)
                {
                    tempNode = null;
                    return;
                }
                if (tempNode.left != null)
                {

                    if (tempNode.left == temp)
                    {
                        tempNode.left = null;
                        return;
                    }
                    else { queue.Enqueue(tempNode.left); }
                }
                if (tempNode.right != null)
                {
                    if (tempNode.right == temp)
                    {
                        tempNode.right = null;
                        return;
                    }
                    else queue.Enqueue(tempNode.right);
                }
            }
        }
    }
}
