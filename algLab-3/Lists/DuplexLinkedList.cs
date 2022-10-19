using System.Collections;

namespace algLab_3.Lists
{
    /// <summary> Двусвязный список </summary>
    /// <typeparam name="T"> Тип элементов списка </typeparam>
    public class DuplexLinkedList<T> : IEnumerable<T>
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

            return result;
        }

        /// <summary>
        /// Написать функцию, которая переносит в начало (в конец) непустого списка L его последний (первый) элемент;
        /// Часть 4. Задание 2.
        /// </summary>
        /// <returns> Новый список </returns>
        
        public void AddFirst(Node<T> node)
        {
            var temp = Head;

            node.Next = temp;
            Head = node;
            if (Count == 0)
            {
                SetHeadAndTail(node);
                return;
            }
                
            else
                temp.Prev = node;
            Count++;
        }

        public void AddLast(Node<T> node)
        {
            var temp = Tail;

            node.Next = Tail;
            Tail = node;
            if (Count == 0)
            {
                SetHeadAndTail(node);
                return;
            }

            else
                temp.Prev = node;
            Count++;
        }


        /// <summary>
        /// Написать функцию, которая определяет количество различных элементов списка, содержащего целые числа
        /// Часть 4. Задание 3.
        /// </summary>
        /// <returns> Новый список </returns>
        
        public bool ContainsSecond(T item)
        {
            int count = 0;
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
        /// Написать функцию вставки списка самого в себя вслед за первым вхождением числа х.
        /// Часть 4. Задание 5.
        /// </summary>
        /// <returns> Новый список </returns>


        public void IntoMyself(Node<T> data)
        {
            if (Head == null)
                Head = data;

            else
            {
                Tail.Next = data;
                data.Prev = Tail;
                Add(data);
            }

            Tail = data;
            Count++;
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
                    Delete(data);
                current = current.Next;
            }
            return false;
        }

        /// <summary>
        /// Функция удваивает список, т.е. приписывает в конец списка себя самого. 
        /// Часть 4. Задание 11.
        /// </summary>
        /// <returns> Новый список </returns>

        public void DoublingList(DuplexLinkedList<int> linkedList)
        {
            foreach(var i in linkedList)
                Console.WriteLine(i);
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

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>) GetEnumerator();
        }
    }
}
