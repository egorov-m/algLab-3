using System.Diagnostics;

namespace algLab_3.Stack
{
    public class Task2
    {
        public static double ParsingAndExecutingOperations(IStack<object> iStack, string str)
        {
            var stack = (Stack.Stack<object>) iStack;
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var commands = str.Split(' ');

            foreach (var command in commands)
            {
                if (command.Contains("1,"))
                {
                    var element = command.Split(',')[1];
                    stack.Push(element);
                }

                switch (command)
                {
                    case "2":
                        try
                        {
                            stack.Pop();
                        }
                        catch
                        {
                            Console.WriteLine("Нельзя извлечь элемент из стека, стек пуст.");
                        }
                        break;
                    case "3":
                        try
                        {
                            Console.WriteLine($"Вершина стека: {stack.Top()}");
                        }
                        catch
                        {
                            Console.WriteLine("Нельзя получить вершину стека, стек пуст.");
                        }
                        break;
                    case "4":
                        Console.WriteLine($"Коллекция пуста: {stack.IsEmpty()}");
                        break;
                    case "5":
                        stack.Print();
                        break;
                }
            }
            stopWatch.Stop();

            return stopWatch.Elapsed.TotalMilliseconds;
        }
    }
}
