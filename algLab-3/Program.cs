using algLab_3.Examples;
using algLab_3.Lists;
using algLab_3.Stack;
using algLab_3.Tests;
using System.Transactions;

namespace algLab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tester = new Tester(3, 300, 3);
            //tester.GenerateTestFile();
            //Thread.Sleep(5000);
            //tester.Testing(TypeTest.Stack);
            tester.TestingWithFixedLength(TypeTest.Queue, "15", 150); // Enqueue(elem), Print()
            tester.TestingWithFixedLength(TypeTest.Queue, "14", 150); // Enqueue(elem),IsEmpty()
            tester.TestingWithFixedLength(TypeTest.Queue, "45", 150); // IsEmpty(), Print()
            tester.TestingWithFixedLength(TypeTest.Queue, "12", 150); // Enqueue(elem), Dequeue()

            tester.TestingWithFixedLength(TypeTest.Queue, "152", 150); // Enqueue(elem), Print(), Dequeue()
            tester.TestingWithFixedLength(TypeTest.Queue, "132", 150); // Enqueue(elem), First(), Dequeue()
            tester.TestingWithFixedLength(TypeTest.Queue, "415", 150); // IsEmpty(), Enqueue(elem), Print()

            tester.TestingWithFixedLength(TypeTest.Queue, "113344", 150); // Enqueue(elem), Enqueue(elem), Dequeue(), Dequeue(), IsEmpty(), IsEmpty()
            tester.TestingWithFixedLength(TypeTest.Queue, "114455", 150); // Enqueue(elem), Enqueue(elem), IsEmpty(), IsEmpty(), Print(), Print()
            tester.TestingWithFixedLength(TypeTest.Queue, "444111", 150); // IsEmpty(), IsEmpty(), IsEmpty(), Enqueue(elem), Enqueue(elem), Enqueue(elem)

            tester.GetTimeVector().WriteCsvFile();


            //var testStr = "10 2 ^ 95 - 4 8 * +"; // 37
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
