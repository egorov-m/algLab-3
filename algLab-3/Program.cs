using algLab_3.Examples;
using algLab_3.Stack;
using algLab_3.Tests;
using System.Transactions;

namespace algLab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var tester = new Tester(1, 5000, 10);
            //tester.Testing();
            //tester.WriteCsvFile();
            // var testStr = "10 2 ^ 95 - 4 8 * +"; // 37
            //Console.WriteLine($"{testStr}: {Task4.Calculate(testStr)}");

            //var memoryTester = new OutOfMemoryTester();
            //var stack = new Stack.Stack<string>();
            //var result = memoryTester.Testing(stack.Push);
            //Console.WriteLine(result.Item1);
            //Console.WriteLine(result.Item2);
            //memoryTester.GetMemoryVector().WriteCsvFile("memoryResult.csv");
            //Console.WriteLine("Запись в CSV завершена.");

            //var cyclicDuplexLinkedList = new Lists.CyclicDuplexLinkedList<int>();
            //cyclicDuplexLinkedList.Add(1);
            //cyclicDuplexLinkedList.Add(2);
            //cyclicDuplexLinkedList.Add(3);
            //cyclicDuplexLinkedList.Add(4);
            //cyclicDuplexLinkedList.Add(5);
            //foreach (var item in cyclicDuplexLinkedList)
            //{
            //    Console.WriteLine(item);
            //}
            //cyclicDuplexLinkedList.Delete(5);
            //Console.WriteLine();
            //foreach (var item in cyclicDuplexLinkedList)
            //{
            //    Console.WriteLine(item);
            //}
            //DeleteDuplicateFromLinkedList.ShowResult();

            ConsoleInput.Console.MainPage();

        }
    }
}