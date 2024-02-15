using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class ToDoItemTests
{
    [TestMethod]
    public void ToDoItem_CompletedDate_NotSet_ByDefault()
    {
        // Arrange
        var toDoItem = new ToDoItem();

        // Assert
        Assert.IsNull(toDoItem.CompletedDate);
    }

    [TestMethod]
    public void ToDoItem_SetCompletedDate_Successfully()
    {
        // Arrange
        var toDoItem = new ToDoItem();
        var completedDate = DateTime.Now;

        // Act
        toDoItem.CompletedDate = completedDate;

        // Assert
        Assert.AreEqual(completedDate, toDoItem.CompletedDate);
    }

    [TestMethod]
    public void ToDoItem_CompleteToDoItem_Successfully()
    {
        // Arrange
        var toDoItem = new ToDoItem();

        // Act
        toDoItem.Complete();

        // Assert
        Assert.IsNotNull(toDoItem.CompletedDate);
    }

    [TestMethod]
    public void ToDoItem_GetToDoItem_ReturnsCorrectId()
    {
        // Arrange
        var toDoItem = new ToDoItem { Id = 1 };

        // Act
        var id = toDoItem.Id;

        // Assert
        Assert.AreEqual(1, id);
    }
}
