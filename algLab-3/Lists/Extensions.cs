using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algLab_3.Lists
{
    public static class Extensions
    {
        /// <summary>
        /// 3.	Написать функцию, которая определяет количество различных элементов списка, содержащего целые числа;
        /// Часть 4. Задание 3.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int CountUniqueElements<T>(this DuplexLinkedList<int> list)
        {
            var uniqueList = new DuplexLinkedList<int>();
            foreach (var item in list)
            {
                if (!uniqueList.Contains((int)item))
                {
                    uniqueList.Add((int)item);
                }
            }

            return uniqueList.Count;
        }
    }
}
