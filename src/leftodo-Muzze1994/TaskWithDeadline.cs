using System;

namespace leftodo_Muzze1994
{
    class TaskWithDeadline : Task
    {
        public int daysLeft { get; set; }

        //Method for printing the completed and non-completed deadline tasks to the ListOfTasks with override to allow it to modify the virtual implementation 
        public override void print()
        {
            if (isComplete && !isArchived)
            {
                Console.WriteLine(String.Format("{0,-5} {1,-15} {2,-10} {3,-5}", Id, Title, Description, "\u221A"));
            }
            else if (!isArchived)
            {
                Console.WriteLine(String.Format("{0,-5} {1,-15} {2,-20} {3,0} {4,0}", Id, Title, Description, daysLeft, "days left"));
            }

        }

        //Method for printing the archived deadline tasks to the ListOfTasks with override to allow it to modify the virtual implementation 
        public override void printArchived()
        {
            if(isArchived)
            {
                Console.WriteLine(String.Format("{0,-5} {1,-15} {2,-10} {3,-5}", Id, Title, Description, "Archived"));
            }
        }
    }
}
