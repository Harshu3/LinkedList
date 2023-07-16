using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked list Problem!");
            Console.WriteLine("Program to appending linkedlist");
            Custom_LinkedList linkedList = new Custom_LinkedList();
            linkedList.Append(56);
            linkedList.Append(30);
            linkedList.Append(70);
            linkedList.Display();
        }
    }
}