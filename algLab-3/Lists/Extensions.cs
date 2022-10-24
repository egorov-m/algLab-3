using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algLab_3.Lists
{
    public static class Extensions
    {
        /// <summary> Имя файла с тестовыми данными </summary>
        public static string FileNameTestData { get; private set; } = "input";

        /// <summary> Чтение из файла списков для объединения (Часть 4. Задание 9.) </summary>
        public static LinkedList<int> GetListFromFileTask9()
        {
            var lines = File.ReadAllLines($"{FileNameTestData}.txt");
            var list1Item = lines[0].Split(' ');
            var list2Item = lines[1].Split(' ');
            var list1 = new LinkedList<int>();
            var list2 = new LinkedList<int>();
            foreach (var item in list1Item)
            {
                list1.Add(int.Parse(item));
            }
            foreach (var item in list2Item)
            {
                list2.Add(int.Parse(item));
            }

            list1.AddLinkedList(list2);
            return list1;
        }
    }
}
