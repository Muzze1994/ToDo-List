using System;
using System.Collections.Generic;
using Xunit;

namespace leftodo_Muzze1994.Tests
{
    public class TaskTests
    {
        [Fact]
        public void TestTheAddTaskMethod()
        {
            // arrange
            var tasks = new ListOfTasks();
            string title = "Title";
            string desc = "Description";

            // act  
            tasks.AddTask(title, desc);

            // assert
            Assert.Equal(1, tasks.GetNumberOfitemsInTheList());
        }

        [Fact]
        public void TestMarkAsCompleted()
        {
            //arrange
            var tasks = new ListOfTasks();
            tasks.AddTask("Titel", "Descr");
            //act
            tasks.CompleteTask(1);

            //assert
            //Assert.True();
        }

        [Fact]
        public void TestArchiveCompletedTasks()
        {
            //arrange
            List<Task> tasks = new List<Task>();
            var listTask = new ListOfTasks();
            var task = new Task() { Description = "Hej", isComplete = false, Id = 1 };
            tasks.Add(task);

            //act
            listTask.CompleteTask(1);
            listTask.ArchiveTask();

            //assert
            //Assert.True(task.isArchived);

        }

    }
}
