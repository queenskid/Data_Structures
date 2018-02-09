using System;
using System.Collections.Generic;
using System.Text;

namespace MinAndMax
{
    class Tree
    {
        private static int TreeMin(Node root)
        {
            int temp1 = 0;
            int temp2 = 0;

            if (root.Left != null)
            {
                temp1 = TreeMin(root.Left);
            }
            if (root.Right != null)
            {
                temp2 = TreeMin(root.Right);
            }
            else
            {
                return root.Value;
            }
            if (temp1 < temp2)
            {
                return temp1;
            }
            else
            {
                return temp2;
            }

           
        }

        private static int TreeMax(Node root)
        {
            int temp1 = 0;
            int temp2 = 0;

            if (root.Left != null)
            {
                temp1 = TreeMax(root.Left);
            }
            if (root.Right != null)
            {
                temp2 = TreeMax(root.Right);
            }            
            else
            {
                return root.Value;
            }
            if (temp1 > temp2)
            {
                return temp1;
            }               
            else
            {
                return temp2;
            }
           
        }
    }
}
