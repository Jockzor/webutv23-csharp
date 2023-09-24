

using _01_DataLogging.Interfaces;
using _01_DataLogging.Models;
using _01_DataLogging.Services;
using Moq;

namespace _01_DataLogging.Tests.Tests;

public class UserManager_Tests
{
    [Fact]
    public void CreateUser_Should_CreateNewUserAndAddToList_ReturnCreatedUser()
    {
        // Arrange
        Mock<IFileManager> mockFileManager = new Mock<IFileManager>();
        IDataLogger logger = new DataLogger("log.txt", mockFileManager.Object);

        string password = "Bytmig123!";
        IUser user = new User
        {
            FirstName = "Joacim",
            LastName = "Edlund",
            Email = "Mail"
        };

        IUserManager userManager = new UserManager(logger);
        // Act
        IUser result = userManager.CreateUser(user, password);
        // Assert
        Assert.NotNull(result);
        Assert.IsAssignableFrom<IUser>( result);
    }
}
