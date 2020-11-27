using System;

namespace leftodo_Muzze1994
{
    public class Task
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public int Id { get; set; }
        public bool isComplete { get; set; }
        public bool isArchived { get; set; }

        //Method for printing the completed and the non-completed regular tasks to the ListOfTasks with virtual to allow it to be overriden on a derived class
        public virtual void print()
        {
            if (isComplete && !isArchived)
            {
                Console.WriteLine(String.Format("{0,-5} {1,-15} {2,-10} {3,-5}", Id, Title, Description, "\u221A"));
            }
            else if (!isArchived)
            {
                Console.WriteLine(String.Format("{0,-5} {1,-15} {2,-10}", Id, Title, Description));
            }
        }

        //Method for printing the archived regular tasks to the ListOfTasks with virtual to allow it to be overriden on a derived class
        public virtual void printArchived()
        {
            if (isArchived)
            {
                Console.WriteLine(String.Format("{0,-5} {1,-15} {2,-10} {3,-5}", Id, Title, Description, "Archived"));
            }
        }
        

    }
}