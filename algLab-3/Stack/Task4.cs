using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algLab_3.Stack
{
    public class Task4
    {
        public static double Calculate(string str)
        {
            var commands = str.Split(' ');
            var stack = new Stack<double>();
            foreach (var item in commands)
            {
                IOperation oper;
                if (!CheckIsOperator(item, out oper))
                {
                    stack.Push(double.Parse(item));
                }

                if (CheckIsOperator(item, out oper))
                {
                    var x = stack.Pop();
                    var result = 0.0;
                    if (oper is IBinaryOperation binaryOperation)
                    {
                        var y = stack.Pop();
                        result = binaryOperation.Calculate(y, x);
                        stack.Push(result);
                    }

                    if (oper is IUnaryOperation unaryOperation)
                    {
                        result = unaryOperation.Calculate(x);
                        stack.Push(result);
                    }
                }
            }

            return Math.Round(stack.Pop(), 3);
        }

        private static bool CheckIsOperator(string item, out IOperation result)
        {
            switch (item.ToLower())
            {
                case "+":
                    result = new Addition();
                    break;
                case "-":
                    result = new Subtraction();
                    break;
                case "*":
                    result = new Multiplication();
                    break;
                case "/":
                    result = new Dividing();
                    break;
                case "^":
                    result = new ElevationToRank();
                    break;
                case "ln":
                    result = new NaturalLagorithm();
                    break;
                case "cos":
                    result = new Cos();
                    break;
                case "sin":
                    result = new Sin();
                    break;
                case "sqrt":
                    result = new Sqrt();
                    break;
                default:
                    result = null;
                    return false;
            }

            return true;
        }

        public interface IOperation
        {
            string OperationName { get; }
        }

        public interface IBinaryOperation : IOperation
        {
            double Calculate(double x, double y);
        }

        public interface IUnaryOperation : IOperation
        {
            double Calculate(double x);
        }

        private class Addition : IBinaryOperation
        {
            string IOperation.OperationName => "+";
            public double Calculate(double x, double y) => x + y;
        }

        private class Subtraction : IBinaryOperation
        {
            string IOperation.OperationName => "-";
            public double Calculate(double x, double y) => x - y;
        }

        private class Multiplication : IBinaryOperation
        {
            string IOperation.OperationName => "*";
            public double Calculate(double x, double y) => x * y;
        }

        private class Dividing : IBinaryOperation
        {
            string IOperation.OperationName => "/";
            public double Calculate(double x, double y) => x / y;
        }

        private class ElevationToRank : IBinaryOperation
        {
            string IOperation.OperationName => "^";
            public double Calculate(double x, double y) => Math.Pow(x, y);
        }

        private class NaturalLagorithm : IUnaryOperation
        {
            string IOperation.OperationName => "ln";
            public double Calculate(double x) => Math.Log(x, Math.E);
        }

        private class Cos : IUnaryOperation
        {
            string IOperation.OperationName => "cos";
            public double Calculate(double x) => Math.Cos(x);
        }

        private class Sin : IUnaryOperation
        {
            string IOperation.OperationName => "sin";
            public double Calculate(double x) => Math.Sin(x);
        }

        private class Sqrt : IUnaryOperation
        {
            string IOperation.OperationName => "sqrt";
            public double Calculate(double x) => Math.Sqrt(x);
        }
    }
}
