using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList<int> unidirectional_list = new SinglyLinkedList<int>();
            unidirectional_list.PushBack(2);
            unidirectional_list.PushBack(3);
            unidirectional_list.PushBack(4);
            unidirectional_list.PushBack(5);
            Console.WriteLine(unidirectional_list.Find(3));
            Console.WriteLine(unidirectional_list.Find(2));
            Console.WriteLine(unidirectional_list.Find(5));
            Console.WriteLine(unidirectional_list.Find(0));
            unidirectional_list.PrintList();
            unidirectional_list.PopElement(3);
            unidirectional_list.PrintList();
            unidirectional_list.PopElement(2);
            unidirectional_list.PrintList();
            unidirectional_list.PopElement(4);
            unidirectional_list.PrintList();

        }
    }
}
