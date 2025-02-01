using System;
using System.Collections.Generic;

/*
Agregar una tarea: El usuario puede agregar una nueva tarea a la lista.
Mostrar todas las tareas: El usuario puede ver todas las tareas en la lista.
Marcar una tarea como completada: El usuario puede marcar una tarea específica como completada.
Eliminar una tarea: El usuario puede eliminar una tarea de la lista.
Salir: El usuario puede salir de la aplicación.
*/
class Program
{
    static List<string> tasks = new List<string>();
    static List<bool> completed = new List<bool>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("\n1. Add task");
            Console.WriteLine("2. Show tasks");
            Console.WriteLine("3. Leave task as completed");
            Console.WriteLine("4. Delete task");
            Console.WriteLine("5. Go out");
            Console.Write("Seleccione una opción: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ShowTasks();
                    break;
                case "3":
                    MakeTaskCompleted();
                    break;
                case "4":
                    DeleteTask();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Bad option. Try again.");
                    break;
            }

            static void AddTask()
            {
                Console.WriteLine("Write the name of the task");
                string taskName = Console.ReadLine();
                tasks.Add(taskName);
                completed.Add(false);
                Console.WriteLine($"Task {taskName} added correctly");
            }

            static void ShowTasks()
            {
                if (tasks.Count == 0) { Console.WriteLine("Empty lists of tasks"); }
           
                for (int i = 0; i < tasks.Count; i++)
                {
                    string status = completed[i] ? "[Complete]" : "[Pending]";
                    Console.WriteLine($"{i + 1}. {status} {tasks[i]}");
                }
            }

            static void MakeTaskCompleted()
            {
                ShowTasks();

                Console.Write("Seleccione una opción: ");
                string selectedTask = Console.ReadLine();
                if( int.TryParse(Console.ReadLine(), out int taskNumber) 
                    && taskNumber > 0 
                    && taskNumber <= tasks.Count)
                {
                    completed[taskNumber - 1] = true;
                    Console.WriteLine("Task completed");
                } else
                {
                    Console.WriteLine("Bad task number");
                }
            }

            static void DeleteTask() 
            {
                ShowTasks();
                Console.Write("Seleccione una opción: ");
                string selectedTask = Console.ReadLine();

            }
        }

    }
}