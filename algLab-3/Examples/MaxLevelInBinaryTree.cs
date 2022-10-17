using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algLab_3.Examples
{
    public class MaxLevelInBinaryTree
    {
        public class Node
        {
            public int data;
            public Node left, right;

            public Node(int data)
            {
                this.data = data;
                this.left = null;
                this.right = null;
            }

            static int maxLevelSum(Node root)
            {
                if (root == null)
                    return 0;

                int result = root.data;

                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(root);
                while (queue.Count != 0)
                {
                    int count = queue.Count;

                    int sum = 0;
                    while (count-- > 0)
                    {

                        Node temp = queue.Dequeue();

                        sum = sum + temp.data;

                        if (temp.left != null)
                            queue.Enqueue(temp.left);
                        if (temp.right != null)
                            queue.Enqueue(temp.right);
                    }
                    result = Math.Max(sum, result);
                }
                return result;
            }


            public static void ShowMaxLevel()
            {
                Node root = new Node(1);
                root.left = new Node(2);
                root.right = new Node(3);
                root.left.left = new Node(4);
                root.left.right = new Node(5);
                root.right.right = new Node(8);
                root.right.right.left = new Node(6);
                root.right.right.right = new Node(7);

                Console.WriteLine("Максимальная сумма равна " + maxLevelSum(root));
            }
        }
    }
}
