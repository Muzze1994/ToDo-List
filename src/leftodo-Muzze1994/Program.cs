using System;

namespace leftodo_Muzze1994
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListOfTasks tasks = new ListOfTasks();
            while (true)
            {
                Menu.PrintMenu();
                int menu;
                Int32.TryParse(Console.ReadLine(), out menu);

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Skriv en titel");
                        string title = Console.ReadLine();

                        Console.WriteLine("Skriv en beskrivning");
                        string descr = Console.ReadLine();

                        tasks.AddTask(title, descr);
                        break;
                    case 2:
                        tasks.ShowTasks();
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        tasks.ShowTasks();
                        Console.WriteLine("Skriv in id på den du vill slutföra");
                        int inputId = Convert.ToInt32(Console.ReadLine());
                        tasks.CompleteTask(inputId);
                        break;
                    case 4:
                        Console.WriteLine("Skriv en titel");
                        string deadlineTitle = Console.ReadLine();

                        Console.WriteLine("Skriv en beskrivning");
                        string deadlineDescr = Console.ReadLine();

                        Console.WriteLine("Hur lång tid får uppgiften ta?");
                        int deadlineTime = Convert.ToInt32(Console.ReadLine());
                        tasks.AddDeadlineTask(deadlineTitle, deadlineDescr, deadlineTime);
                        break;
                    case 5:
                        tasks.ArchiveTask();
                        break;
                    case 6:
                        tasks.ShowArchivedTasks();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
