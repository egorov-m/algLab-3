using System.Text;
using algLab_3.Examples;
using algLab_3.Lists;

namespace algLab_3.ConsoleInput
{
    public class Console
    {
        /// <summary> Страница алгоритмов со стеком </summary>
        public static void StackPage()
        {
            System.Console.WriteLine(
@"Про стеки
------------------------------------------------
1. Вычисление выражения в постфиксной записи.
2. Преобразовать инфиксную запись в постфиксную.
3. Выйти в главное меню.
------------------------------------------------");
            var value = 0;
            while (value is not (1 or 2 or 3))
            {
                var top = System.Console.GetCursorPosition().Top;
                var left = System.Console.GetCursorPosition().Left;
                System.Console.Write("Введите порядковый номер: ");
                _ = int.TryParse(System.Console.ReadLine(), out value);
                System.Console.SetCursorPosition(System.Console.GetCursorPosition().Left, System.Console.GetCursorPosition().Top - 1);
                System.Console.Write(new string(' ', System.Console.BufferWidth));
                System.Console.SetCursorPosition(left, top);
            }

            switch (value)
            {
                case 1:
                    {
                        ConsoleHelper.ExecuteAlgorithm(value, Stack.Task4.Calculate, "Введите выражение (постфикс): ");
                        ConsoleHelper.ExecuteReturn(StackPage, MainPage);
                        break;
                    }
                case 2:
                    {
                        ConsoleHelper.ExecuteAlgorithm(value, Stack.Task5.InfixToPrefix, "Введите запись (не забывайте про пробелы!): ");
                        ConsoleHelper.ExecuteReturn(StackPage, MainPage);
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

        /// <summary> Страница алгоритмов со списками </summary>
        public static void AlgorithmsList()
        {
            System.Console.WriteLine(
@"Алгоритмы со списками
---------------------------------------------------------------------
1. Обратный порядок.
2. Перенос в начало/(конец) списка последний/(первый) элемент.
3. Количество различных элементов списка.
4. Удаление второго из двух одинаковых элементов.
5. Вставка самого себя.
6. Написать функцию, которая вставляет в непустой список L...
7. Удаление Е элементов.
8. Написать функцию, которая вставляет в список L новый элемент F...
9. Дописывание к списку E.
10. Разбиение на два списка.
11. Удваивание списка.
12. Меняет местами два элемента списка.
13. Выход в главное меню.
---------------------------------------------------------------------");
            var value = 0;
            while (value is not (1 or 2 or 3 or 4 or 5 or 6 or 7 or 8 or 9 or 10 or 11 or 12 or 13))
            {
                var top = System.Console.GetCursorPosition().Top;
                var left = System.Console.GetCursorPosition().Left;
                System.Console.Write("Введите порядковый номер: ");
                _ = int.TryParse(System.Console.ReadLine(), out value);
                System.Console.SetCursorPosition(System.Console.GetCursorPosition().Left, System.Console.GetCursorPosition().Top - 1);
                System.Console.Write(new string(' ', System.Console.BufferWidth));
                System.Console.SetCursorPosition(left, top);
            }

            switch (value)
            {
                case 1:
                {
                    ConsoleHelper.ExecuteOneDuplexLinkedListAlgorithm(value, (list) => list.Reverse());
                    ConsoleHelper.ExecuteReturn(AlgorithmsList, MainPage);
                    break;
                }

                case 2:
                {
                    ConsoleHelper.ExecuteOneDuplexLinkedListAlgorithm(value, (list) => list.SwapFirstAndLast());
                    ConsoleHelper.ExecuteReturn(AlgorithmsList, MainPage);
                    break;
                }

                case 3:
                {
                    ConsoleHelper.ExecuteOneDuplexLinkedListAlgorithm(value, (list) => list.UniqueElementsCount());
                    ConsoleHelper.ExecuteReturn(AlgorithmsList, MainPage);
                    break;
                }

                case 4:
                {
                    ConsoleHelper.ExecuteOneLinkedListAlgorithm(value, (list) => list.DeleteSecondRepeatNumber());
                    ConsoleHelper.ExecuteReturn(AlgorithmsList, MainPage);
                    break;
                }

                case 5:
                {
                    ConsoleHelper.ExecuteOneLinkedListAndTargetAlgorithm(value, (list, target) => list.InsertCopyListAfter(target));
                    ConsoleHelper.ExecuteReturn(AlgorithmsList, MainPage);
                    break;
                }

                case 6:
                {
                    ConsoleHelper.ExecuteOneDuplexLinkedListAndElementAlgorithm(value, (list, element) => list.InsertElementOrder(element));
                    ConsoleHelper.ExecuteReturn(AlgorithmsList, MainPage);
                    break;
                }

                case 7:
                {
                    ConsoleHelper.ExecuteOneDuplexLinkedListAndElementAlgorithm(value, (list, element) => list.DeleteAllNumbers(element));
                    ConsoleHelper.ExecuteReturn(AlgorithmsList, MainPage);
                    break;
                }

                case 8:
                {
                    ConsoleHelper.ExecuteOneDuplexLinkedListAndTwoElementAlgorithm(value, (list, target, element) => list.InsertBefore(target, element));
                    ConsoleHelper.ExecuteReturn(AlgorithmsList, MainPage);
                    break;
                }

                case 9:
                {
                    ConsoleHelper.ExecuteTwoLinkedListAlgorithm(value, (list1, list2) => list1.AddLinkedList(list2));
                    ConsoleHelper.ExecuteReturn(AlgorithmsList, MainPage);
                    break;
                }

                case 10:
                {
                    ConsoleHelper.ExecuteReturnTwoDuplexLinkedListAlgorithm(value, (list, target) => list.SplitIntoTwo(target));
                    ConsoleHelper.ExecuteReturn(AlgorithmsList, MainPage);
                    break;
                }

                case 11:
                {
                    ConsoleHelper.ExecuteOneDuplexLinkedListAlgorithm(value, (list) => list.DoublingList());
                    ConsoleHelper.ExecuteReturn(AlgorithmsList, MainPage);
                    break;
                }
                case 12:
                {
                    ConsoleHelper.ExecuteOneDuplexLinkedListAndTwoElementAlgorithm(value, (list, index1, index2) => list.SwapElement(index1, index2), true);
                    ConsoleHelper.ExecuteReturn(AlgorithmsList, MainPage);
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

        /// <summary> Страница Приводимых примеров алгоритмов </summary>
        public static void ExamplePage()
        {
            System.Console.WriteLine(
@"Примеры. Динамические структуры
----------------------------------------
1. Удаление дубликатов из списка.
2. Переворачивание слов.
3. Максимальная сумма уровня дерева.
4. Дерево выражений.
5. Выйти в главное меню.
----------------------------------------");
            var value = 0;
            while (value is not (1 or 2 or 3 or 4 or 5))
            {
                var top = System.Console.GetCursorPosition().Top;
                var left = System.Console.GetCursorPosition().Left;
                System.Console.Write("Введите порядковый номер: ");
                _ = int.TryParse(System.Console.ReadLine(), out value);
                System.Console.SetCursorPosition(System.Console.GetCursorPosition().Left, System.Console.GetCursorPosition().Top - 1);
                System.Console.Write(new string(' ', System.Console.BufferWidth));
                System.Console.SetCursorPosition(left, top);
            }

            switch (value)
            {
                case 1:
                {
                    ConsoleHelper.ExecuteOneLinkedListAlgorithm(value, (list) => list.RemoveDuplicates());
                    ConsoleHelper.ExecuteReturn(ExamplePage, MainPage);
                    break;
                    //System.Console.Write("Введите массив через пробел: ");
                    //var arrayStr = System.Console.ReadLine();
                    //var elements = arrayStr.Split(new Char[] { ' ' });
                    //DeleteDuplicateFromLinkedList.ShowResult(elements);
                    //Thread.Sleep(3000);
                    //System.Console.Clear();
                    //ExamplePage();
                }
                case 2:
                {
                    ConsoleHelper.ExecuteAlgorithm(value, (sentence) => sentence.ReversingWords(), "Введите предложение: ");
                    ConsoleHelper.ExecuteReturn(ExamplePage, MainPage);
                    break;
                    //System.Console.Write("Введите предложение: ");
                    //var sentence = System.Console.ReadLine();
                    //ReverseWords.ShowResult(sentence);
                    //Thread.Sleep(3000);
                    //System.Console.Clear();
                    //ExamplePage();
                }
                case 3:
                {
                    System.Console.WriteLine($"Выбрано действие: {value}.");
                    var elements = new Lists.LinkedList<int>();
                    ConsoleHelper.GetListIntegerNumbersFromConsoleInput(elements);
                    var three = Examples.MaxLevelInBinaryTree.MakeBinaryTree(elements.ToArray());
                    var result = MaxLevelInBinaryTree.MaxLevelSum(three);
                    System.Console.WriteLine($"Результат: {result}");
                    ConsoleHelper.ExecuteReturn(ExamplePage, MainPage);
                    break;
                    //MaxLevelInBinaryTree.Node.ShowMaxLevel();
                    //Thread.Sleep(3000);
                    //System.Console.Clear();
                    //ExamplePage();
                }
                case 4:
                {
                    ConsoleHelper.ExecuteAlgorithm(value, (sentence) => 
                        ExpressionTree.Inorder(ExpressionTree.GetExpressionTree(sentence), new StringBuilder()), "Введите выражение: ");
                    ConsoleHelper.ExecuteReturn(ExamplePage, MainPage);
                    break;
                    //System.Console.Write("Введите выражение: ");
                    //var examples = System.Console.ReadLine();
                    //ExpressionTree.ShowExpression(examples);
                    //Thread.Sleep(3000);
                    //System.Console.Clear();
                    //ExamplePage();
                    //break;
                }
                case 5:
                {
                    System.Console.Clear();
                    MainPage();
                    break;
                    //System.Console.Clear();
                    //MainPage();
                    //Thread.Sleep(3000);
                    //System.Console.Clear();
                    //ExamplePage();
                    //break;
                }
            }
        }

        /// <summary> Главная страница </summary>
        public static void MainPage()
        {
            System.Console.WriteLine(
@"-----------------------------
1. Про стеки.
2. Примеры.
3. Алгоритмы со списками.
-----------------------------");
            var value = 0;
            while (value is not (1 or 2 or 3))
            {
                var top = System.Console.GetCursorPosition().Top;
                var left = System.Console.GetCursorPosition().Left;
                System.Console.Write("Введите порядковый номер: ");
                _ = int.TryParse(System.Console.ReadLine(), out value);
                System.Console.SetCursorPosition(System.Console.GetCursorPosition().Left,
                    System.Console.GetCursorPosition().Top - 1);
                System.Console.Write(new string(' ', System.Console.BufferWidth));
                System.Console.SetCursorPosition(left, top);
            }

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
