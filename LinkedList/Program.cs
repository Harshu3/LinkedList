using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked list Problem!");
            Console.WriteLine("Program to add nodes in sequence in linkedlist");
            Custom_LinkedList linkedList = new Custom_LinkedList();
            linkedList.AddFirst(70);
            linkedList.AddFirst(30);
            linkedList.AddFirst(56);
            linkedList.Display();
        }
    }
}