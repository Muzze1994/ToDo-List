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
            // arrange
            var tasks = new ListOfTasks();
            tasks.AddTask("Titel", "Descr");
            tasks.AddTask("Titel2", "Descr2");
            // act
            tasks.CompleteTask(1);

            // assert
            Assert.True(tasks.GetIsCompleteBoolFromTask(1));
        }

        [Fact]
        public void TestMarkAsArchived()
        {
            // arrange
            var tasks = new ListOfTasks();
            tasks.AddTask("Titel", "Descr");

            // act
            tasks.CompleteTask(1);
            tasks.ArchiveTask();

            // assert
            Assert.True(tasks.GetIsArchivedBoolFromTask());
        }
        [Fact]
        public void TestAddDeadlineTask()
        {
            // arrange
            var tasks = new ListOfTasks();

            // act  
            tasks.AddDeadlineTask("Title", "Descr", 4);

            // assert
            Assert.Equal(1, tasks.GetNumberOfitemsInTheList());
        }

    }
}
