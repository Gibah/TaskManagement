using TaskManagement;

class Program
{
    static void Main()
    {
        var taskManager = new TaskManager();

        while (true)
        {
            Console.WriteLine("Choose one option:");
            Console.WriteLine("1. Add a Task");
            Console.WriteLine("2. List tasks");
            Console.WriteLine("3. Finish a task");
            Console.WriteLine("4. End");
            Console.WriteLine("Options: ");

            var choice = Console.ReadLine();

            switch (choice) 
            {
                case "1":
                    Console.Write("Task Description");
                    var description = Console.ReadLine();
                    taskManager.AddTask(description);
                    break;
                case "2":
                    taskManager.ListTasks();
                    break;
                case "3":
                    Console.Write("ID of a task to finish: ");
                    if (int.TryParse(Console.ReadLine(), out int id) && id > 0)
                    {
                        taskManager.CompleteTask(id);
                    }
                    else
                    {
                        Console.WriteLine("Invalid ID. Insert a positive number.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Finishing program...");
                    return;
                default:
                    Console.WriteLine("Invalid Option. Please, choose an option between 1 to 4.");
                    break;
            }
        }
    }
}