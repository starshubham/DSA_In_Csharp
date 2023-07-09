using System;

namespace BinaryTreeProject
{
    class Node
    {
        public Node lchild;
        public char info;
        public Node rchild;

        public Node(char ch)
        {
            info = ch;
            lchild = null;
            rchild = null;
        }
    }
}
