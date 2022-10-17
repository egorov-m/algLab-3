using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algLab_3.Examples
{
    class Node
    {
        public char data;
        public Node left, right;
        public Node(char data)
        {
            this.data = data;
            left = null;
            right = null;
        }
    }
    class ExpressionTree
    {
        public static bool isOperator(char ch)
        {
            if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == '^')
                return true;

            return false;
        }

        static Node expressionTree(String postfix)
        {
            algLab_3.Stack.Stack<Node> stack = new algLab_3.Stack.Stack<Node>();
            Node t1, t2, temp;

            for (int i = 0; i < postfix.Length; i++)
            {
                if (!isOperator(postfix[i]))
                {
                    temp = new Node(postfix[i]);
                    stack.Push(temp);
                }
                else
                {
                    temp = new Node(postfix[i]);

                    t1 = stack.Pop();
                    t2 = stack.Pop();

                    temp.left = t2;
                    temp.right = t1;

                    stack.Push(temp);
                }

            }
            temp = stack.Pop();
            return temp;
        }
        static void inorder(Node root)
        {
            if (root == null) return;

            inorder(root.left);
            Console.Write(root.data);
            inorder(root.right);
        }

        public static void ShowExpression()
        {
            String postfix = "ABC*+D/";

            Node r = expressionTree(postfix);
            inorder(r);
        }
    }
}
