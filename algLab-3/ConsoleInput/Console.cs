using algLab_3.Examples;
using algLab_3.Lists;
using algLab_3.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace algLab_3.ConsoleInput
{
    public class Console
    {
        public static void StackPage()
        {
            System.Console.WriteLine("▀██▀─▄███▄─▀██─██▀██▀▀█");
            System.Console.WriteLine("─██─███─███─██─██─██▄█");
            System.Console.WriteLine("─██─▀██▄██▀─▀█▄█▀─██▀█");
            System.Console.WriteLine("▄██▄▄█▀▀▀─────▀──▄██▄▄█");

            System.Console.WriteLine("Про стеки");
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine("1. ");
            System.Console.WriteLine("2. Вычисление выражения в постфиксной записи");
            System.Console.WriteLine("3. Преобразовать инфиксную запись в постфиксную ");
            System.Console.WriteLine("4. Выйти в главное меню ");
            System.Console.WriteLine("-----------------------------");

            System.Console.Write("Введите порядковый номер: ");
            int value = Convert.ToInt32(System.Console.ReadLine());

            switch (value)
            {
                case 1:
                    {
                        //Чтобы можно было делать такую инициализацию { 1, 2, 3}
                        //для стека, можешь добавить конструктор с IEnumerable, по аналогии.
                        var iStack = new algLab_3.Stack.Stack<object>();

                        System.Console.Write("Введите выражение: ");
                        string examples = System.Console.ReadLine();

                        Task2.ParsingAndExecutingOperations(iStack, examples);

                        break;
                    }


                case 2:
                    {
                        System.Console.Write("Введите выражение (постфикс): ");
                        string examples = System.Console.ReadLine();
                        Stack.Task4.Calculate(examples);
                        break;
                    }


                case 3:
                    {
                        System.Console.Write("Введите запись (не забывайте про пробелы!): ");
                        string examples = System.Console.ReadLine();
                        Stack.Task5.InfixToPrefix(examples);
                        break;
                    }

                case 4:
                    {
                        System.Console.Clear();
                        MainPage();
                        break;
                    }
            }

        }

        public static void QueuePage()
        {
            System.Console.WriteLine("▀██▀─▄███▄─▀██─██▀██▀▀█");
            System.Console.WriteLine("─██─███─███─██─██─██▄█");
            System.Console.WriteLine("─██─▀██▄██▀─▀█▄█▀─██▀█");
            System.Console.WriteLine("▄██▄▄█▀▀▀─────▀──▄██▄▄█");

            System.Console.WriteLine("Про Очереди");
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine("1. ");
            System.Console.WriteLine("-----------------------------");

            System.Console.Write("Введите порядковый номер: ");
            int value = Convert.ToInt32(System.Console.ReadLine());

            switch (value)
            {
                case 1:
                    {

                        break;
                    }


                case 2:
                    {
                        System.Console.Clear();
                        MainPage();
                        break;
                    }
            }

        }



        public static void AlgorithmsList()
        {
            System.Console.WriteLine("▀██▀─▄███▄─▀██─██▀██▀▀█");
            System.Console.WriteLine("─██─███─███─██─██─██▄█");
            System.Console.WriteLine("─██─▀██▄██▀─▀█▄█▀─██▀█");
            System.Console.WriteLine("▄██▄▄█▀▀▀─────▀──▄██▄▄█");


            System.Console.WriteLine("Алгоритмы со списками");
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine("1. Обратный порядок");
            System.Console.WriteLine("2. Перенос в начало/(конец) списка последний/(первый) элемент");
            System.Console.WriteLine("3. Колличество целых чисел");
            System.Console.WriteLine("4. Удаление второго из двух одинаковых элементов");
            System.Console.WriteLine("5. Вставка самого себя");
            System.Console.WriteLine("6. ");
            System.Console.WriteLine("7. Удаление Е элементов");
            System.Console.WriteLine("8. ");
            System.Console.WriteLine("9. Дописывание к списку E");
            System.Console.WriteLine("10. Разбиение на два списка");
            System.Console.WriteLine("11. Удваивание списка");
            System.Console.WriteLine("12. Меняет местами два элемента списка");
            System.Console.WriteLine("-----------------------------");

            System.Console.Write("Введите порядковый номер: ");
            int value = Convert.ToInt32(System.Console.ReadLine());

            switch (value)
            {
                case 1:
                    {
                        
                        Thread.Sleep(3000);
                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }

                case 2:
                    {
                       
                        Thread.Sleep(3000);
                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }

                case 3:
                    {
                       
                        Thread.Sleep(3000);
                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }

                case 4:
                    {
                        
                        Thread.Sleep(3000);
                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }

                case 5:
                    {
                        System.Console.Write("Введите опорный элемент: ");
                        int supportElem = Convert.ToInt32(System.Console.ReadLine());
                        System.Console.Write("Введите данные о вставке: ");
                        int data = Convert.ToInt32(System.Console.ReadLine());

                        //надо инициализировать элемент как объект!!
                        var list = new Lists.LinkedList<object>();
                        list.InsertAfter(supportElem, data);
                        Thread.Sleep(3000);
                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }

                case 6:
                    {
                        
                        Thread.Sleep(3000);
                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }

                case 7:
                    {
                        
                        Thread.Sleep(3000);
                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }

                case 8:
                    {
                        
                        Thread.Sleep(3000);
                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }

                case 9:
                    {
                       
                        Thread.Sleep(3000);
                        System.Console.Clear();
                        ExamplePage();
                        break;
                    }

                case 10:
                    {
                        
                        Thread.Sleep(3000);
                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }

                case 11:
                    {
                        
                        Thread.Sleep(3000);
                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }

                case 12:
                    {
                        
                        Thread.Sleep(3000);
                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }
            }

        }






        public static void ExamplePage()
        {

            System.Console.WriteLine("▀██▀─▄███▄─▀██─██▀██▀▀█");
            System.Console.WriteLine("─██─███─███─██─██─██▄█");
            System.Console.WriteLine("─██─▀██▄██▀─▀█▄█▀─██▀█");
            System.Console.WriteLine("▄██▄▄█▀▀▀─────▀──▄██▄▄█");


            System.Console.WriteLine("Примеры. Динамические структуры");
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine("1. Удаление дубликатов из списка");
            System.Console.WriteLine("2. Переворачивание слов");
            System.Console.WriteLine("3. Максимальная сумма уровня дерева");
            System.Console.WriteLine("4. Дерево выражений");
            System.Console.WriteLine("5. Выйти в главное меню");
            System.Console.WriteLine("-----------------------------");

            System.Console.Write("Введите порядковый номер: ");
            int value = Convert.ToInt32(System.Console.ReadLine());

            switch (value)
            {
                case 1:
                    {
                        System.Console.Write("Введите массив через пробел: ");
                        string arrayStr = System.Console.ReadLine();
                        string[] elements = arrayStr.Split(new Char[] { ' ' });

                        DeleteDuplicateFromLinkedList.ShowResult(elements);
                        Thread.Sleep(3000);
                        System.Console.Clear();
                        ExamplePage();
                        break;
                    }

                case 2:
                    {
                        System.Console.Write("Введите предложение: ");
                        string sentence = System.Console.ReadLine();

                        ReverseWords.ShowResult(sentence);
                        Thread.Sleep(3000);
                        System.Console.Clear();
                        ExamplePage();
                        break;
                    }

                case 3:
                    {
                        //Пока не знаю как исправить ввод данных
                        MaxLevelInBinaryTree.Node.ShowMaxLevel();
                        Thread.Sleep(3000);
                        System.Console.Clear();
                        ExamplePage();
                        break;
                    }

                case 4:
                    {
                        System.Console.Write("Введите выражение: ");
                        string examples = System.Console.ReadLine();
                        ExpressionTree.ShowExpression(examples);
                        Thread.Sleep(3000);
                        System.Console.Clear();
                        ExamplePage();
                        break;
                    }

                case 5:
                    {
                        System.Console.Clear();
                        MainPage();
                        Thread.Sleep(3000);
                        System.Console.Clear();
                        ExamplePage();
                        break;
                    }
            }
        }

        public static void MainPage()
        {
            System.Console.WriteLine("▀██▀─▄███▄─▀██─██▀██▀▀█");
            System.Console.WriteLine("─██─███─███─██─██─██▄█");
            System.Console.WriteLine("─██─▀██▄██▀─▀█▄█▀─██▀█");
            System.Console.WriteLine("▄██▄▄█▀▀▀─────▀──▄██▄▄█"); 
            
            
            

            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine("1. Про стеки");
            System.Console.WriteLine("2. Про очередь");
            System.Console.WriteLine("3. Примеры");
            System.Console.WriteLine("4. Алгоритмы со списками");
            System.Console.WriteLine("-----------------------------");

            System.Console.Write("Выберите номер задания: ");
            int value = Convert.ToInt32(System.Console.ReadLine());


            switch (value)
            {
                case 1:
                    {
                        System.Console.Clear();
                        StackPage();
                        break;
                    }

                case 2:
                    {
                        System.Console.Clear();
                        QueuePage();
                        break;
                    }

                case 3:
                    {
                        System.Console.Clear();
                        ExamplePage();
                        break;
                    }

                case 4:
                    {
                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }
            }
        }
    }
}
