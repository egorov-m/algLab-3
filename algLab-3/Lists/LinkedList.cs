using System.Collections;
using System.Collections.Generic;

namespace algLab_3.Lists
{
    /// <summary> Односвязный список </summary>
    /// <typeparam name="T"> Тип данных хранимых в списке </typeparam>
    public class LinkedList<T> : IEnumerable<T>
    {
        /// <summary> Узел — элемент списка </summary>
        /// <typeparam name="T"> Тип данных хранимых в списке </typeparam>
        public class Node<T>
        {
            /// <summary> Данные в элементе списка </summary>
            public T Data { get; set; }
            /// <summary> Следующий элемент списка </summary>
            public Node<T> Next { get; set; }
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
        public LinkedList()
        {
            Clear();
        }


        /// <summary>
        /// Удаление дубликатов с помощью односвязного списка;
        /// Часть 3.
        /// </summary>
        /// <typeparam name="T"> Тип данных хранимых в списке </typeparam>
        public void RemoveDuplicates<T>()
        {
            var ptr1 = Head;
            var ptr2 = ptr1;


            while (ptr1 != null && ptr1.Next != null)
            {
                ptr2 = ptr1;

                while (ptr2 != null && ptr2.Next != null)
                {

                    if (ptr1.Data.Equals(ptr2.Next.Data))
                        ptr2.Next = ptr2.Next.Next;
                    
                    else 
                        ptr2 = ptr2.Next.Next;
                }
                ptr1 = ptr1.Next;
            }
        }



        /// <summary> Инициализация списка с начальным элементом </summary>
        /// <param name="item"> Элемент данных списка </param>
        public LinkedList(T item)
        {
            var node = new Node<T>(item);
            SetHeadAndTail(node);
        }

        /// <summary> Инициализировать список с начальной коллекцией </summary>
        /// <param name="collection"> Начальная коллекция </param>
        public LinkedList(IEnumerable<T> collection)
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
            if (Tail != null)
            {
                Tail.Next = node;
                Tail = node;
                Count++;
            }
            else
            {
                SetHeadAndTail(node);
            }
        }

        /// <summary> Добавление элемента на голову списка </summary>
        /// <param name="data"> Добавляемые данные </param>
        public void AppendHead(T data)
        {
            var node = new Node<T>(data)
            {
                Next = Head
            };
            Head = node;
            Count++;
        }

        /// <summary>
        /// Написать функцию, которая удаляет из списка L второй из двух одинаковых элементов.
        /// Часть 4. Задание 4.
        /// </summary>
        public void DeleteSecondRepeatNumber()
        {
            var current = Head;
            Node<T> prev = null;
            var elements = new Lists.DuplexLinkedList<T>();
            while (current != null)
            {
                if (!elements.Contains(current.Data))
                {
                    elements.Add(current.Data);
                    prev = current;
                }
                else
                {
                    if (current.Next == null) Tail = prev;
                    prev.Next = current.Next;
                    Count--;
                }

                current = current.Next;
            }
        }

        /// <summary>
        /// 5. Написать функцию вставки списка самого в себя вслед за первым вхождением числа х;
        /// Часть 4. Задание 5.
        /// </summary>
        /// <param name="target"> Опорный элемент </param>
        /// <param name="data"> Данные для вставки </param>
        public void InsertAfter(T target, T data)
        {
            if (Head != null)
            {
                var current = Head;
                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        var node = new Node<T>(data);
                        node.Next = current.Next;
                        Head.Next = node;
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

        /// <summary>
        /// 9.	Функция дописывает к списку L список E. Оба списка содержат целые числа. В основной программе считать их из файла;
        /// Часть 4. Задание 9.
        /// </summary>
        /// <param name="list"></param>
        public void AddLinkedList(LinkedList<T> list)
        {
            foreach (var item in list)
            {
                Add(item);
            }
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

                var current = Head.Next;
                var prev = Head;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        prev.Next = current.Next;
                        Count--;
                        return;
                    }

                    prev = current;
                    current = current.Next;
                }
            }
            else
            {
                SetHeadAndTail(new Node<T>(data));
            }
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

        /// <summary> Установить головной и последний элемент списка </summary>
        /// <param name="node"> Элемент списка </param>
        private void SetHeadAndTail(Node<T> node)
        {
            Head = node;
            Tail = node;
            Count = 1;
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
