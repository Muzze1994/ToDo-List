using System;
using System.Collections.Generic;

namespace leftodo_Muzze1994
{
    public class ListOfTasks
    {
        //Method for addding a regular task to the list
        public void AddTask(string title, string description)
        {

            int id = tasks.Count + 1;
            Task task = new Task() { Title = title, Description = description, Id = id, isComplete = false, isArchived = false };
            tasks.Add(task);

        }

        //Method for adding a task with a deadline to the list
        public void AddDeadlineTask(string title, string description, int deadline)
        {

            int id = tasks.Count + 1;
            TaskWithDeadline task = new TaskWithDeadline() { Title = title, Description = description, Id = id, isComplete = false, isArchived = false, daysLeft = deadline };
            tasks.Add(task);

        }

        //Method for adding a task with a checklist
        public void AddChecklistTask()
        {

        }

        //Method for showing all tasks in the list
        public void ShowTasks()
        {

            Console.Clear();
            Console.WriteLine("Dagens uppgifter\n");
            Console.WriteLine(String.Format("{0,-5} {1,-15} {2,-10}", "Id", "Titel", "Beskrivning"));
            Console.WriteLine("----------------------------------");

            for (int i = 0; i < tasks.Count; i++)
            {
                tasks[i].print();
            }
        }
        
        //Method for showing all archived tasks in the list
        public void ShowArchivedTasks()
        {
            Console.Clear();
            Console.WriteLine("Här är dina arkiverade uppgifter\n");
            Console.WriteLine("{0,-5} {1,-15} {2,0}", "Id", "Titel", "Beskrivning");
            Console.WriteLine("----------------------------------");
            
                for (int i = 0; i < tasks.Count; i++)
                {
                    tasks[i].printArchived();
                }
            
            Console.ReadLine();

        }

        //Method for completing the tasks that the user selects from the list of tasks
        public void CompleteTask(int id)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (id == tasks[i].Id)
                {
                    tasks[i].isComplete = true;
                }
            }
        }

        //Method for archiving the completed tasks in the list
        public void ArchiveTask()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].isComplete)
                {
                    tasks[i].isArchived = true;
                }
            }
        }

        public int GetNumberOfitemsInTheList()
        {
            return tasks.Count;
        }

        //List with all of the tasks
        private List<Task> tasks = new List<Task>();
    }
}