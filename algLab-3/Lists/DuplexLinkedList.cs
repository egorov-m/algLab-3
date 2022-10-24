using System.Collections;
using System.Collections.Generic;

namespace algLab_3.Lists
{
    /// <summary> Двусвязный список </summary>
    /// <typeparam name="T"> Тип элементов списка </typeparam>
    public class DuplexLinkedList<T> : IEnumerable, IEnumerable<T>
    {
        /// <summary> Узел — элемент списка </summary>
        /// <typeparam name="T"> Тип данных хранимых в списке </typeparam>
        public class Node<T>
        {
            /// <summary> Данные элемента стека </summary>
            public T Data { get; set; }
            /// <summary> Следующий элемент </summary>
            public Node<T> Next { get; set; }
            /// <summary> Предыдущий элемент </summary>
            public Node<T> Prev { get; set; }
            /// <summary> Инициализатор элемента списка </summary>
            public Node(T item) => Data = item;

            public override string ToString()
            {
                return Data != null ? Data.ToString() : "";
            }
        }

        /// <summary> Головной элемент списка </summary>
        public Node<T> Head { get; private set; }
        /// <summary> Последний элемент списка </summary>
        public Node<T> Tail { get; private set; }
        /// <summary> Количество элементов в списке </summary>
        public int Count { get; private set; }

        /// <summary> Инициализация пустого списка </summary>
        public DuplexLinkedList()
        {
            Clear();
        }

        /// <summary> Инициализация списка с начальным элементом </summary>
        /// <param name="item"> Элемент данных списка </param>
        public DuplexLinkedList(T item)
        {
            var node = new Node<T>(item);
            SetHeadAndTail(node);
        }

        /// <summary> Инициализировать список с начальной коллекцией </summary>
        /// <param name="collection"> Начальная коллекция </param>
        public DuplexLinkedList(IEnumerable<T> collection)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));
            foreach (var obj in collection)
                Add(obj);
        }

        /// <summary> Добавить элемент данных в список </summary>
        /// <param name="item"> Элемент данных списка </param>
        public void Add(T item)
        {
            var node = new Node<T>(item);
            Add(node);
        }

        /// <summary> Добавить элемент в список </summary>
        /// <param name="node"> Элемент списка </param>
        public void Add(Node<T> node)
        {
            if (IsEmpty)
            {
                SetHeadAndTail(node);
                return;
            }
            Tail.Next = node;
            node.Prev = Tail;
            Tail = node;
            Count++;
        }

        /// <summary> Удалить первое вхождение данных в список </summary>
        /// <param name="data"> Удаляемые данные </param>
        public void Delete(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data)) // Если этот был первый элемент
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        current.Prev.Next = current.Next;
                        if (current.Next != null)
                        {
                            current.Next.Prev = current.Prev;
                        }
                        Count--;
                        return;
                    }

                    current = current.Next;
                }
            }
        }

        /// <summary> Удалить элемент список </summary>
        /// <param name="item"> Удаляемый элемент </param>
        public void Delete(Node<T> item)
        {
            if (Head != null)
            {
                if (Head.Equals(item)) // Если этот был первый элемент
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head;

                while (current != null)
                {
                    if (current.Equals(item))
                    {
                        current.Prev.Next = current.Next;
                        if (current.Next != null)
                        {
                            current.Next.Prev = current.Prev;
                        }
                        Count--;
                        return;
                    }

                    current = current.Next;
                }
            }
        }

        /// <summary>
        /// 10.	Функция разбивает список целых чисел на два списка по первому вхождению заданного числа. Если этого числа в списке нет, второй список будет пустым, а первый не изменится;
        /// Часть 4. Задание 10.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public DuplexLinkedList<T> SplitIntoTwo(T target)
        {
            var list2 = new DuplexLinkedList<T>();
            var current = Head;
            var flag = false;

            while (current != null)
            {
                if (!flag)
                {
                    if (current.Data.Equals(target))
                    {
                        flag = true;
                        list2.Add(current);
                        Delete(current);
                    }
                }
                else
                {
                    list2.Add(current);
                    Delete(current);
                }

                current = current.Next;
            }
            foreach (var i in list2) Console.Write(i + " ");

            return list2;
        }

        /// <summary>
        /// Элементы списка в обратном порядке;
        /// Часть 4. Задание 1.
        /// </summary>
        /// <returns> Новый список </returns>
        public DuplexLinkedList<T> Reverse()
        {
            var result = new DuplexLinkedList<T>();

            var current = Tail;
            while (current != null)
            {
                result.Add(current.Data);
                current = current.Prev;
            }

            foreach(var i in result)
                Console.Write(i + " ");
            return result;
        }

        /// <summary>
        /// 2.	Написать функцию, которая переносит в начало (в конец) непустого списка L его последний (первый) элемент;
        /// Часть 4. Задание 2.
        /// </summary>
        public void SwapFirstAndLast()
        {
            if (Count < 2) return;
            var currentHead = Head;
            var currentTail = Tail;
            Head.Prev = currentTail.Prev;
            Tail.Next = currentHead.Next;
            currentTail.Prev.Next = Head;
            currentHead.Next.Prev = Tail;
            Head = currentTail;
            Tail = currentHead;
            Head.Prev = null;
            Tail.Next = null;
        }

        /// <summary>
        /// 12.	Функция меняет местами два элемента списка, заданные пользователем;
        /// Часть 4. Задание 12.
        /// </summary>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        public void SwapElement(Node<T> item1, Node<T> item2)
        {
            if (Count < 2) return;
            Node<T> tmp;
            tmp = item1.Prev;
            item1.Prev = item2.Prev;
            item2.Prev = tmp;

            tmp = item1.Next;
            item1.Next = item2.Next;
            item2.Next = tmp;

            item1.Prev.Next = item2;
            item2.Prev.Next = item1;

            item2.Next.Prev = item1;
            item1.Next.Prev = item2;
        }
         
        /// <summary> Добавить элемент в начало списка </summary>
        /// <param name="data"> Новые данные </param>
        public void AddFirst(T data)
        {
            var node = new Node<T>(data);
            if (IsEmpty)
            {
                SetHeadAndTail(node);
                return;
            }

            var temp = Head;
            node.Next = temp;
            Head = node;
            temp.Prev = node;
            Count++;
        }

        /// <summary> Добавить элемент в конец списка </summary>
        /// <param name="data"> Новые данные </param>
        public void AddLast(T data)
        {
            var node = new Node<T>(data);
            if (IsEmpty)
            {
                SetHeadAndTail(node);
                return;
            }
            var temp = Tail;
            node.Next = Tail;
            Tail = node;
            temp.Prev = node;
            Count++;
        }

        /// <summary> Проверить что указанные данные содержатся </summary>
        /// <param name="data"> Данные </param>
        public bool Contains(int data)
        {
            var current = Head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        /// <summary>
        /// Написать функцию, которая определяет количество различных элементов списка, содержащего целые числа
        /// Часть 4. Задание 3.
        /// </summary>
        /// <returns> Новый список </returns>
        public bool ContainsSecond(T item)
        {
            var count = 0;
            var current = Head;
            while(current != null)
            {
                if (current.Data.Equals(item))
                {
                    count++;
                    if(count == 2)
                    {
                        Delete(item);
                        break;
                    }
                }
                current = current.Next;
            }
            return false;
        }

        /// <summary>
        /// Написать функцию, которая удаляет из списка L второй из двух одинаковых элементов.
        /// Часть 4. Задание 4.
        /// </summary>
        /// <returns> Новый список </returns>
        public bool RemoveLast(T data)
        {
            var current = Tail;
            while(current != null)
            {
                if (current.Data.Equals(data))
                    break;
                current = current.Next;
            }
            if(current != null)
            {
                if (current.Next != null)
                    current.Next.Prev = current.Prev;

                else
                    Tail = current.Prev;

                if (current.Prev != null)
                    current.Prev.Next = current.Next;

                else
                    Head = current.Next;

                Count--;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Написать функцию, которая удаляет из списка L все элементы Е, если таковые имеются. 
        /// Часть 4. Задание 7.
        /// </summary>
        /// <returns> Новый список </returns>
        public bool ContainsAllNumbers(T data)
        {
            var current = Head;
            while(current != null)
            {
                if (current.Data.Equals(data))
                {
                    Delete(data);
                }
                    
                current = current.Next;
            }
            return false;
        }

        /// <summary>
        /// Функция удваивает список, т.е. приписывает в конец списка себя самого. 
        /// Часть 4. Задание 11.
        /// </summary>
        /// <returns> Новый список </returns>
        public DuplexLinkedList<T> DoublingList(DuplexLinkedList<T> list)
        {
            var list2 = new DuplexLinkedList<T>();
            foreach(var i in list)
                list2.Add(i);
            foreach (var item in list2)
            {
                list.Add(item);
            }
           
            foreach(var i in list)
                Console.Write(i + " ");
            return list;
        }

        /// <summary>
        /// 8.	Написать функцию, которая вставляет в список L новый элемент F перед первым вхождением элемента Е, если Е входит в L;
        /// Часть 4. Задание 8.
        /// </summary>
        /// <param name="target"> Опорный элемент </param>
        /// <param name="data"> Данные </param>
        public void InsertBefore(T target, T data)
        {
            if (Head != null)
            {
                var current = Head;
                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        var node = new Node<T>(data);

                        
                        node.Prev = current.Prev;
                        node.Next = current;
                        if (current.Prev != null)
                        {
                            current.Prev.Next = node;
                            current.Prev = node;
                        }
                        else
                        {
                            current.Prev = node;
                            Head = node;
                        }

                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
            else
            {
                SetHeadAndTail(new Node<T>(data));
            }
        }


        /// <summary> Установить головной и последний элемент списка </summary>
        /// <param name="node"> Элемент списка </param>
        private void SetHeadAndTail(Node<T> node)
        {
            Head = node;
            Tail = node;
            Count = 1;
        }

        /// <summary> Пустой ли список </summary>
        public bool IsEmpty => Count == 0;

        /// <summary> Очистка списка </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        /// <summary> Перечислитель, осуществляет итерационный переход по списку </summary>
        /// <returns> IEnumerator — проход по коллекции </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary> Перечислитель, осуществляет итерационный переход по списку </summary>
        /// <returns> IEnumerator — проход по коллекции </returns>
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary> Перечислитель, осуществляет итерационный переход по списку </summary>
        /// <returns> IEnumerator — проход по коллекции </returns>
        private IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
