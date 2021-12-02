using DataStructuresAndAlgorigthms;
using static DataStructuresAndAlgorigthms.SinglyLinkedLists;

SinglyLinkedLists singlyLinkedLists=new();
singlyLinkedLists.PushToStart(10);
singlyLinkedLists.PushToStart(14);
singlyLinkedLists.PrintItems();
Console.WriteLine("Before deleting");
singlyLinkedLists.DeleteAtEnd();
singlyLinkedLists.PrintItems();
