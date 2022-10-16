using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using algLab_3.Stack;

namespace algLab_3.Tests
{
    public class Tester
    {
        private readonly Dictionary<int, double> _timeVector;
        private int _start;
        private int _end;
        private int _step;

        public static string FileNameTestData { get; private set; } = "input";

        public Tester(int start, int end, int step)
        {
            _timeVector = new Dictionary<int, double>();
            Init(start, end, step);
        }

        public Tester(int end = 25, int step = 1)
        {
            _timeVector = new Dictionary<int, double>();
            Init(1, end, step);
        }

        private void Init(int start, int end, int step)
        {
            _start = start;
            _end = end;
            _step = step;
        }

        public void Testing(bool newData = true)
        {
            if (newData || !File.Exists($"{FileNameTestData}.txt")) GenerateTestFile();
            var lines = File.ReadAllLines($"{FileNameTestData}.txt");
            var index = _start;
            foreach (var l in lines)
            {
                _timeVector.Add(index, Task2.ParsingAndExecutingOperations(new Stack.Stack<object>(), l));
                index += _step;
            }
        }

        public void WriteCsvFile(string path = "result.csv")
        {
            var csv = new StringBuilder();
            foreach (var item in _timeVector)
            {
                csv.Append($"{item.Key};{item.Value}");
                csv.Append(Environment.NewLine);
            }
            File.WriteAllText(path, csv.ToString());
        }

        public static void SetFileNameTestData(string fileName)
        {
            FileNameTestData = fileName;
        }

        private static StringBuilder GenerateInputString(int size = 5)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < size; i++)
            {
                var item = new Random().Next(1, 6);
                if (item == 1)
                {

                    sb.Append(item);
                    sb.Append(",12345");
                    sb.Append(' ');
                }

                sb.Append(item);
                sb.Append(' ');
            }

            return sb;
        }

        public void GenerateTestFile(int end, int step = 1)
        {
            Init(1, end, step);
            GenerateTestFile();
        }

        public void GenerateTestFile(int start, int end, int step = 1)
        {
            Init(start, end, step);
            GenerateTestFile();
        }

        public void GenerateTestFile()
        {
            var fs = new FileStream($"{FileNameTestData}.txt", FileMode.Create);
            using var w = new StreamWriter(fs, Encoding.UTF8);
            for (var i = _start; i < _end + 1; i += _step)
            {
                w.WriteLine(GenerateInputString(i));
            }
        }
    }
}
