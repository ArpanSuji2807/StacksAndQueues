using System;
namespace StacksAndQueues;
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to stacks and queues program");
        LinkedListStacks list = new LinkedListStacks();
        LinkedListQueue queue = new LinkedListQueue();
        bool check = true;
        Console.WriteLine("1.Stack Creation\n2.Peek And Pop stacks\n3.Queue creation\n4.Dequeue linked list");
        while(check)
        {
            Console.WriteLine("Take an option to execute: ");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    list.Push(56);
                    list.Push(30);
                    list.Push(70);
                    list.Display();
                    break;
                case 2:
                    list.Push(56);
                    list.Push(30);
                    list.Push(70);
                    list.IsEmpty();
                    list.Display();
                    break ;
                case 3:
                    queue.Enqueue(56);
                    queue.Enqueue(30);
                    queue.Enqueue(70);
                    queue.Display();
                    break;
                case 4:
                    queue.Enqueue(56);
                    queue.Enqueue(56);
                    queue.Enqueue(56);
                    queue.Dequeue();
                    queue.Display();
                    break;
                case 5:
                    Console.WriteLine("Enter a valid choice");
                    break;
                    default:break;
            }
        }
    }
}