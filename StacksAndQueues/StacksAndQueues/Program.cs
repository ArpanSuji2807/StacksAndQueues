using System;
namespace StacksAndQueues;
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to stacks and queues program");
        LinkedListStacks list = new LinkedListStacks();
        bool check = true;
        Console.WriteLine("1.Stack Creation");
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
                    Console.WriteLine("Enter a valid choice");
                    break;
                    default:break;
            }
        }
    }
}