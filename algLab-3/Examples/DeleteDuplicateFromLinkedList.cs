namespace algLab_3.Examples
{
    public static class DeleteDuplicateFromLinkedList
    {
        public static void PrintList<T>(this Lists.LinkedList<T>.Node<T> node)
        {
            while (node != null)
            {
                Console.Write(node.Data + " ");
                node = node.Next;
            }
        }
        public static void ShowResult()
        {
            var list = new Lists.LinkedList<int>() { 10, 12, 11, 11, 12, 11, 10 };

            Console.WriteLine("Связный лист до удаления дубликатов: ");
            list.Head.PrintList();

            // Часть 3.
            list.RemoveDuplicates<int>();
            Console.WriteLine("");
            Console.WriteLine("Связный лист после удаления дубликатов: ");
            list.Head.PrintList();
        }
    }
}
