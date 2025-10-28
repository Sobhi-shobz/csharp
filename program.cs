using System;
using System.Collections.Generic;

class ToDoListApp
{
    static List<string> tasks = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- To-Do List Menu ---");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Remove Task");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    RemoveTask();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Enter a new task: ");
        string task = Console.ReadLine();
        tasks.Add(task);
        Console.WriteLine("✅ Task added!");
    }

    static void ViewTasks()
    {
        Console.WriteLine("\n📋 Your Tasks:");
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks yet.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }

    static void RemoveTask()
    {
        ViewTasks();
        Console.Write("Enter task number to remove: ");
        int index;
        if (int.TryParse(Console.ReadLine(), out index) && index > 0 && index <= tasks.Count)
        {
            tasks.RemoveAt(index - 1);
            Console.WriteLine("🗑️ Task removed!");
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
}
