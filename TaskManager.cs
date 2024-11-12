using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{

    public class TaskManager
    {
        private List<Task> tasks = new List<Task>();
        private int nextId = 1;

        public void AddTask(string description)
        {
            if (string.IsNullOrWhiteSpace(description) || description.Length < 3)
            {
                Console.WriteLine("Description is invalid. The description must have at least 3 characters");
                return;
            }

            var task = new Task(nextId++, description);
            tasks.Add(task);
            Console.WriteLine("Task added successfully.");
        }

        public void ListTasks()
        {
            Console.WriteLine("Your tasks: ");
            if (tasks.Count == 0) 
            {
                Console.WriteLine("Any Task found");
            }
            else
            {
                foreach (var task in tasks)
                {
                    Console.WriteLine(task);
                }
            }
        }

        public void CompleteTask(int id)
        {
            var task = tasks.Find(t => t.Id == id);
            if (task == null)
            {
                Console.WriteLine("Task don't found. Check the ID and try again.");
                return;
            }

            task.MarkAsCompleted();
            Console.WriteLine("Tasks selected as Done");
        }
    }
}
