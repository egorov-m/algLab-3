using algLab_3.Examples;
using algLab_3.Queue;
using algLab_3.Stack;

namespace algLab_3.ConsoleInput
{
    public class Console
    {
        public static void StackPage()
        {

            System.Console.WriteLine("Про стеки");
            System.Console.WriteLine("-----------------------------");
            //System.Console.WriteLine("1. В файле input.txt записаны числа от 1 до 5 через пробел...");
            System.Console.WriteLine("1. Вычисление выражения в постфиксной записи");
            System.Console.WriteLine("2. Преобразовать инфиксную запись в постфиксную ");
            System.Console.WriteLine("3. Выйти в главное меню ");
            System.Console.WriteLine("-----------------------------");

            System.Console.Write("Введите порядковый номер: ");
            int value = Convert.ToInt32(System.Console.ReadLine());

            switch (value)
            {


                case 1:
                    {
                        System.Console.Write("Введите выражение (постфикс): ");
                        string examples = System.Console.ReadLine();
                        Stack.Task4.Calculate(examples);
                        Thread.Sleep(3000);
                        System.Console.Clear();
                        StackPage();
                        break;
                    }


                case 2:
                    {
                        System.Console.Write("Введите запись (не забывайте про пробелы!): ");
                        string examples = System.Console.ReadLine();
                        Stack.Task5.InfixToPrefix(examples);
                        Thread.Sleep(30000);
                        System.Console.Clear();
                        StackPage();
                        break;
                    }

                case 3:
                    {
                        System.Console.Clear();
                        MainPage();
                        break;
                    }
            }

        }

        //public static void QueuePage()
        //{

        //    System.Console.WriteLine("Про Очереди");
        //    System.Console.WriteLine("-----------------------------");
        //    System.Console.WriteLine("1. В файле input.txt записаны числа от 1 до 5 через пробел... ");
        //    System.Console.WriteLine("-----------------------------");

        //    System.Console.Write("Введите порядковый номер: ");
        //    var value = Convert.ToInt32(System.Console.ReadLine());

        //    switch (value)
        //    {
        //        case 1:
        //            {
        //                var iQueue = new Queue.Queue<object>();
        //                System.Console.Write("Введите выражение: ");
        //                var examples = System.Console.ReadLine();

        //                Task2Queue.ParsingAndExecutingOperations(iQueue, examples);
        //                Thread.Sleep(3000);
        //                System.Console.Clear();
        //                QueuePage();
        //                break;
        //            }


        //        case 2:
        //            {
        //                System.Console.Clear();
        //                MainPage();
        //                break;
        //            }
        //    }

        //}



        public static void AlgorithmsList()
        {


            System.Console.WriteLine("Алгоритмы со списками");
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine("1. Обратный порядок");
            System.Console.WriteLine("2. Перенос в начало/(конец) списка последний/(первый) элемент");
            System.Console.WriteLine("3. Колличество целых чисел");
            System.Console.WriteLine("4. Удаление второго из двух одинаковых элементов");
            System.Console.WriteLine("5. Вставка самого себя");
            System.Console.WriteLine("6. Написать функцию, которая вставляет в непустой список L...");
            System.Console.WriteLine("7. Удаление Е элементов");
            System.Console.WriteLine("8. Написать функцию, которая вставляет в список L новый элемент F...");
            System.Console.WriteLine("9. Дописывание к списку E");
            System.Console.WriteLine("10. Разбиение на два списка");
            System.Console.WriteLine("11. Удваивание списка");
            System.Console.WriteLine("12. Меняет местами два элемента списка");
            System.Console.WriteLine("13. Выход в главное меню");
            System.Console.WriteLine("-----------------------------");

            System.Console.Write("Введите порядковый номер: ");
            var value = Convert.ToInt32(System.Console.ReadLine());

            switch (value)
            {
                case 1:
                    {
                        //true
                        var list = new Lists.DuplexLinkedList<int> { 3, 5, 12, 7 };

                        System.Console.Write("ДО: ");
                        foreach (var i in list)
                            System.Console.Write(i + " ");
                        System.Console.ReadKey();

                        System.Console.WriteLine();

                        System.Console.Write("ПОСЛЕ:");
                        list.Reverse();


                        System.Console.ReadKey();
                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }

                case 2:
                    {
                        //true
                        var list = new Lists.DuplexLinkedList<int>();
                        list.Add(3);
                        list.Add(5);
                        list.Add(12);
                        list.Add(7);
                        System.Console.Write("ДО: ");
                        foreach (var i in list)
                            System.Console.Write(i + " ");
                        System.Console.ReadKey();
                        System.Console.WriteLine();


                        list.SwapFirstAndLast();


                        System.Console.Write("ПОСЛЕ:");
                        foreach (var i in list)
                            System.Console.Write(i + " ");

                        System.Console.ReadKey();
                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }

                case 3:
                    {
                        //true
                        var list = new Lists.DuplexLinkedList<int> { 4, 3, 4, 12, 7 };

                        System.Console.Write("МАССИВ:");
                        foreach(var i in list)
                            System.Console.Write(i + " ");

                        System.Console.WriteLine();



                        System.Console.ReadKey();

                        System.Console.Write("РЕЗУЛЬТАТ:");
                        list.UniqueElementsCount();

                        System.Console.ReadKey();
                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }

                case 4:
                    {
                        //true
                        var list = new Lists.LinkedList<int> { 4, 3, 4, 7 };

                        System.Console.Write("ДО:");
                        foreach (var i in list)
                            System.Console.Write(i + " ");
                        System.Console.ReadKey();

                        System.Console.WriteLine();

                        list.DeleteSecondRepeatNumber();

                        System.Console.Write("ПОСЛЕ:");
                        foreach (var i in list)
                            System.Console.Write(i + " ");

                        System.Console.ReadKey();
                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }

                case 5:
                    {
                        //true
                        var list = new Lists.LinkedList<int> { 4, 3, 4, 5, 7 };

                        System.Console.Write("ДО:");
                        foreach (var i in list)
                            System.Console.Write(i + " ");
                        System.Console.ReadKey();

                        System.Console.WriteLine();

                        System.Console.Write("ПОСЛЕ:");
                        list.InsertCopyListAfter(4);
                        foreach (var i in list) System.Console.Write(i + " ");
                        System.Console.ReadKey();

                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }

                case 6:
                    {
                        var list = new Lists.DuplexLinkedList<int> { 4, 3, 4, 5, 7 };

                        System.Console.Write("ДО:");
                        foreach (var i in list)
                            System.Console.Write(i + " ");
                        System.Console.ReadKey();

                        System.Console.WriteLine();

                        System.Console.Write("ПОСЛЕ:");
                        Lists.Extensions.InsertElementOrder(list, 6);
                        foreach (var i in list) System.Console.Write(i + " ");
                        System.Console.ReadKey();

                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }

                case 7:
                    {
                        //true
                        var list = new Lists.DuplexLinkedList<int> { 4, 3, 4, 7 };

                        System.Console.Write("ДО:");
                        foreach (var i in list)
                            System.Console.Write(i + " ");
                        System.Console.ReadKey();

                        System.Console.WriteLine();

                        System.Console.Write("ПОСЛЕ:");
                        list.ContainsAllNumbers(4);

                        foreach (var i in list)
                            System.Console.Write(i + " ");
                        System.Console.ReadKey();
                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }

                case 8:
                    {
                        //true
                        var list = new Lists.DuplexLinkedList<int> { 4, 3, 4, 7 };

                        System.Console.Write("ДО:");
                        foreach (var i in list)
                            System.Console.Write(i + " ");
                        System.Console.ReadKey();

                        System.Console.WriteLine();

                        System.Console.Write("ПОСЛЕ:");
                        list.InsertBefore(4, 3);

                        foreach (var i in list)
                            System.Console.Write(i + " ");
                        System.Console.ReadKey();
                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }

                case 9:
                    {
                        //true
                        var list = new Lists.LinkedList<int> { 4, 3, 4, 7 };
                        var list2 = new Lists.LinkedList<int>
                        { 14, 13, 14, 17 };

                        System.Console.Write("ДО:");
                        foreach (var i in list)
                            System.Console.Write(i + " ");
                        System.Console.ReadKey();

                        list.AddLinkedList(list2);

                        System.Console.WriteLine();

                        System.Console.Write("ПОСЛЕ:");
                        foreach (var i in list)
                            System.Console.Write(i + " ");
                        System.Console.ReadKey();

                        System.Console.Clear();
                        ExamplePage();
                        break;
                    }

                case 10:
                    {
                        //true
                        var list = new Lists.DuplexLinkedList<int> { 4, 3, 4, 7, 3, 4, 7 };

                        System.Console.Write("ДО:");
                        foreach (var i in list)
                            System.Console.Write(i + " ");
                        System.Console.ReadKey();

                        System.Console.WriteLine();

                        System.Console.Write("ПОСЛЕ:");
                        list.SplitIntoTwo(3);

                        System.Console.ReadKey();
                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }

                case 11:
                    {
                        //true
                        var list = new Lists.DuplexLinkedList<int> { 4, 3, 4, 7 };
                        System.Console.Write("ДО:");
                        foreach (var i in list)
                            System.Console.Write(i + " ");
                        System.Console.ReadKey();

                        System.Console.WriteLine();

                        System.Console.Write("ПОСЛЕ:");
                        list.DoublingList(list);
                        System.Console.ReadKey();
                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }

                case 12:
                    {
                        //true
                        var list = new Lists.DuplexLinkedList<int> { 4, 3, 4, 7, 3, 4, 7 };

                        System.Console.Write("ДО:");
                        foreach (var i in list)
                            System.Console.Write(i + " ");
                        System.Console.ReadKey();

                        list.SwapElement(2, 4);

                        System.Console.WriteLine();

                        System.Console.Write("ПОСЛЕ:");
                        foreach (var i in list)
                            System.Console.Write(i + " ");
                        System.Console.ReadKey();
                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }

                case 13:
                    {
                        System.Console.Clear();
                        MainPage();
                        break;
                    }
            }
        }

        public static void ExamplePage()
        {
            System.Console.WriteLine("Примеры. Динамические структуры");
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine("1. Удаление дубликатов из списка");
            System.Console.WriteLine("2. Переворачивание слов");
            System.Console.WriteLine("3. Максимальная сумма уровня дерева");
            System.Console.WriteLine("4. Дерево выражений");
            System.Console.WriteLine("5. Выйти в главное меню");
            System.Console.WriteLine("-----------------------------");

            System.Console.Write("Введите порядковый номер: ");
            var value = Convert.ToInt32(System.Console.ReadLine());

            switch (value)
            {
                case 1:
                    {
                        System.Console.Write("Введите массив через пробел: ");
                        var arrayStr = System.Console.ReadLine();
                        var elements = arrayStr.Split(new Char[] { ' ' });

                        DeleteDuplicateFromLinkedList.ShowResult(elements);
                        Thread.Sleep(3000);
                        System.Console.Clear();
                        ExamplePage();
                        break;
                    }

                case 2:
                    {
                        System.Console.Write("Введите предложение: ");
                        var sentence = System.Console.ReadLine();

                        ReverseWords.ShowResult(sentence);
                        Thread.Sleep(3000);
                        System.Console.Clear();
                        ExamplePage();
                        break;
                    }

                case 3:
                    {
                        MaxLevelInBinaryTree.Node.ShowMaxLevel();
                        Thread.Sleep(3000);
                        System.Console.Clear();
                        ExamplePage();
                        break;
                    }

                case 4:
                    {
                        System.Console.Write("Введите выражение: ");
                        var examples = System.Console.ReadLine();
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

            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine("1. Про стеки");
            System.Console.WriteLine("2. Примеры");
            System.Console.WriteLine("3. Алгоритмы со списками");
            System.Console.WriteLine("-----------------------------");

            System.Console.Write("Выберите номер задания: ");
            var value = Convert.ToInt32(System.Console.ReadLine());


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
                        ExamplePage();
                        break;
                    }

                case 3:
                    {
                        System.Console.Clear();
                        AlgorithmsList();
                        break;
                    }
            }
        }
    }
}
