using algLab_3.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algLab_3.Examples
{
    class ReverseWords
    {
        public static void reverseWords(string str)
        {
            algLab_3.Stack.Stack<char> stack = new algLab_3.Stack.Stack<char>();

            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i] != ' ')
                    stack.Push(str[i]);

                else
                {
                    while (stack.Count > 0)
                        Console.Write(stack.Pop());
                    
                    Console.Write(" ");
                }
            }

            while (stack.Count > 0)
                Console.Write(stack.Pop());
            
        }

        public static void ShowResult()
        {
            string str = "Мишаня";
            reverseWords(str);
        }
    }
}

