using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            //LinkedList list = new LinkedList();
            //list.AddNodeToChildBranch(1);
            //list.AddNodeToChildBranch(2);
            //list.AddNodeToChildBranch(3);
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.AddToList(1);
            binaryTree.AddToList(2);
            binaryTree.AddToList(3);
            binaryTree.AddToList(4);

        }
    }
}
