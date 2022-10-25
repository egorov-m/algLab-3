namespace algLab_3.Examples
{
    public static class ReverseWords
    {
        public static void ReversingWords(this string str)
        {
            var stack = new Stack.Stack<char>();

            for (var i = 0; i < str.Length; ++i)
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

        public static void ShowResult(string word)
        {
            ReversingWords(word);
        }
    }
}

