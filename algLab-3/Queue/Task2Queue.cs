using algLab_3.Stack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algLab_3.Queue
{
    public class Task2Queue
    {
        public static double ParsingAndExecutingOperations(IQueue<object> iQueue, string str)
        {
            var queue = (Queue.Queue<object>)iQueue;
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var commands = str.Split(' ');

            foreach (var command in commands)
            {
                if (command.Contains("1,"))
                {
                    var element = command.Split(',')[1];
                    queue.Enqueue(element);
                }

                switch (command)
                {
                    case "2":
                        try
                        {
                            queue.Enqueue(10);
                        }
                        catch
                        {
                            Console.WriteLine("Нельзя извлечь элемент, так как очередь пустая.");
                        }
                        break;
                    case "3":
                        try
                        {
                            Console.WriteLine($"Первый элемент очереди: {queue.First()}");
                        }
                        catch
                        {
                            Console.WriteLine("Нельзя получить первый элемент, так как очередь пустая.");
                        }
                        break;
                    case "4":
                        Console.WriteLine($"Коллекция пуста: {queue.IsEmpty()}");
                        break;
                    case "5":
                        queue.Print();
                        break;
                }
            }
            stopWatch.Stop();

            return stopWatch.Elapsed.TotalMilliseconds;
        }
    }
}
