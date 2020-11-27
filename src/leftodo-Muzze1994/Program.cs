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

                //Menu för choosing what you want to do in the console application
                switch (menu)
                {
                    //Creates a task
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Du har valt att skapa en vanlig uppgift!\n");
                        Console.WriteLine("Skriv en titel");
                        string title = Console.ReadLine();

                        Console.WriteLine("Skriv en beskrivning");
                        string descr = Console.ReadLine();

                        tasks.AddTask(title, descr);
                        break;

                    //Show all tasks in the list tasks
                    case 2:
                        tasks.ShowTasks();
                        Console.ReadLine();
                        break;

                    //Completes a task that the user choose
                    //Input have to be the same as an existing task-id to complete
                    case 3:
                        Console.Clear();
                        tasks.ShowTasks();
                        Console.WriteLine("Skriv in id på den du vill slutföra");
                        try
                        {
                            int inputId = Convert.ToInt32(Console.ReadLine());
                            tasks.CompleteTask(inputId);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Vänligen skriv en siffa!");
                            Console.ReadLine();
                        }
                        break;

                    //Creates a task with a deadline
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Du har valt att skapa en uppgift med en deadline!\n");
                        Console.WriteLine("Skriv en titel");
                        string deadlineTitle = Console.ReadLine();

                        Console.WriteLine("Skriv en beskrivning");
                        string deadlineDescr = Console.ReadLine();

                        Console.WriteLine("Hur lång tid får uppgiften ta? (I dagar)");
                        try
                        {
                            int deadlineTime = Convert.ToInt32(Console.ReadLine());
                            tasks.AddDeadlineTask(deadlineTitle, deadlineDescr, deadlineTime);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Vänligen skriv siffror!");
                            Console.ReadLine();
                        }
                        break;

                    //Archives all the completed tasks and removes them from ShowTasks
                    case 5:
                        tasks.ArchiveTask();
                        break;

                    //Shows all the archived tasks 
                    case 6:
                        tasks.ShowArchivedTasks();
                        break;

                    //Exits the program
                    case 7:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
