﻿using algLab_3.Examples;
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
            // var testStr = "10 2 ^ 95 - 4 8 * +"; // 37
            //Console.WriteLine($"{testStr}: {Task4.Calculate(testStr)}");
            //var testStr = "( 7 - 10 / 2 ) * ( 8 / 4 + 4 )";
            //Console.WriteLine($"{testStr}   |   {Task5.InfixToPrefix(testStr)}");

            //var task = new Examples.DeleteDuplicateFromLinkedList();
            //Examples.List.ShowResult();
            //Examples.ReverseWords.ShowResult();
            //Examples.MaxLevelInBinaryTree.Node.ShowMaxLevel();
            Examples.ExpressionTree.ShowExpression();
        }
    }
}