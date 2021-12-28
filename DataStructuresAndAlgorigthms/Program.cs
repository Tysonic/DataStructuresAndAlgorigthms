using DataStructuresAndAlgorigthms;

BinarySearchTree tree = new BinarySearchTree();
tree.Insert(tree.root,6);
tree.Insert(tree.root,4);
tree.Insert(tree.root,5);
tree.Insert(tree.root,3);
tree.Insert(tree.root,1);
tree.Insert(tree.root,2);
tree.Insert(tree.root,7);
Console.WriteLine("before deletion");
tree.Inorder(tree.root);
tree.DeleteNode(tree.root, 4);
Console.WriteLine("After deletion");
tree.Inorder(tree.root);