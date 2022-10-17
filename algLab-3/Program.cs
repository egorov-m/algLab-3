using algLab_3.Tests;

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
            //var testStr = "( 7 - 10 / 2 ) * ( 8 / 4 + 4 )";
            //Console.WriteLine($"{testStr}   |   {Task5.InfixToPrefix(testStr)}");

            var memoryTester = new OutOfMemoryTester();
            var stack = new Stack.Stack<string>();
            var result = memoryTester.Testing(stack.Push);
            Console.WriteLine(result.Item1);
            Console.WriteLine(result.Item2);
            memoryTester.GetMemoryVector().WriteCsvFile("memoryResult.csv");
            Console.WriteLine("Запись в CSV завершена.");
        }
    }
}