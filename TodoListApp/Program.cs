using System;
using System.Collections.Generic;

namespace ToDoListApp
{
    class Program
    {
        // List to store tasks
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            string userInput;

            // Loop until the user chooses to exit
            do
            {
                // Clear the console and display the menu
                Console.Clear();
                Console.WriteLine("To-Do List App");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Remove Task");
                Console.WriteLine("3. Display Tasks");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice (1-4):");

                // Read user input
                userInput = Console.ReadLine();

                // Perform actions based on user's choice
                switch (userInput)
                {
                    case "1":
                        AddTask();  // Call method to add a task
                        break;
                    case "2":
                        RemoveTask();  // Call method to remove a task
                        break;
                    case "3":
                        DisplayTasks();  // Call method to display all tasks
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");  // Exit message
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");  // Handle invalid input
                        break;
                }

                // Pause before returning to the menu (if not exiting)
                if (userInput != "4")
                {
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                }

            } while (userInput != "4");  // Continue until the user chooses to exit
        }

        // Method to add a task to the list
        static void AddTask()
        {
            Console.WriteLine("Enter the task to add:");
            string task = Console.ReadLine();

            // Check if the input is not empty or whitespace
            if (!string.IsNullOrWhiteSpace(task))
            {
                tasks.Add(task);  // Add the task to the list
                Console.WriteLine("Task added successfully.");
            }
            else
            {
                Console.WriteLine("Task cannot be empty.");  // Handle empty input
            }
        }

        // Method to remove a task from the list
        static void RemoveTask()
        {
            // Display current tasks
            DisplayTasks();

            Console.WriteLine("Enter the task number to remove:");

            // Parse the user input to determine which task to remove
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1);  // Remove the task (adjusted for zero-based index)
                Console.WriteLine("Task removed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");  // Handle invalid task number input
            }
        }

        // Method to display all tasks in the list
        static void DisplayTasks()
        {
            // Check if there are no tasks in the list
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
            }
            else
            {
                Console.WriteLine("To-Do List:");

                // Loop through the list and display each task with its number
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");  // Display task with 1-based index
                }
            }
        }
    }
}
