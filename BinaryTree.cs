using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        Node start;
        Node tail;
        Node leftChild;
        Node rightChild;

        public void AddToList(int data)
        {
            Node node = new Node(data);
            if (start == null)
            {
                start = node;
                tail = node;
            }
            if (leftChild == null)
            {
                leftChild = node;
                tail = node;
            }
            else if (rightChild == null)
            {
                rightChild = node;
                tail = node;
            }
            else
            {
                tail.link = node;
                tail = node;
            }


            
        }


        public void SearchBinaryTree(int data)
        {
            Node node = new Node(data);
            while (start == null)
            {
                if (data < 51)
                {
                    AddToList(data);
                }
            }
        }
    }
}
