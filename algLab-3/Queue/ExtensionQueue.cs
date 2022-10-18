using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algLab_3.Queue
{
    public static class ExtensionQueue
    {
        public static void Print<T>(this Queue<T> queue)
        {
            foreach (var element in queue)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
