using algLab_3.Stack;
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
            var testStr = "10 2 ^ 95 - 4 8 * +"; // 37
            Console.WriteLine($"{testStr}: {Task4.Calculate(testStr)}");
        }
    }
}