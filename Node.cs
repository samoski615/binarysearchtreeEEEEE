﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
   public class Node
    {
       public int data;
       public Node link;
       public Node leftChild;
       public Node rightChild;

        public Node(int data)
        {
            this.data = data;
            this.leftChild = null;
            this.rightChild = null;
        }

       
    }
}
