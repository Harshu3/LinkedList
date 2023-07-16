using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked list Problem!");
            Console.WriteLine("Program to insert node into linkedlist");
            Custom_LinkedList linkedList = new Custom_LinkedList();
            linkedList.AddLast(56);
            linkedList.AddLast(70);
            linkedList.Display();
            linkedList.Insert(2, 30);
            Console.WriteLine("After 30 node is added into linkedlist");
            linkedList.Display();
        }
    }
}