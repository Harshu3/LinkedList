using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked list Problem!");
            Console.WriteLine("Program to remove first node from linkedlist");
            Custom_LinkedList linkedList = new Custom_LinkedList();
            linkedList.AddLast(56);
            linkedList.AddLast(30);
            linkedList.AddLast(70);
            linkedList.Display();
            linkedList.RemoveFirst();
            linkedList.Display();
        }
    }
}