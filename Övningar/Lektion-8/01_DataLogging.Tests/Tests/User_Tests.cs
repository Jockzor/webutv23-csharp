

using _01_DataLogging.Interfaces;
using _01_DataLogging.Models;

namespace _01_DataLogging.Tests.Tests;

public class User_Tests
{
    [Fact]
    public void GenerateSecurePassword_Should_EncryptPasswordFromPassword()
    {
        // Arrange
        string password = "Bytmig123!";
        IUser user = new User()
        {
            FirstName = "Joacim",
            LastName = "Edlund",
            Email = "Mail"
        };

        // Act
        user.GenerateSecurePassword(password);

        // Assert
        Assert.NotNull(user.Password);
    }
    [Fact]
    public void ValidatePassword_Should_CheckIfPasswordIsValid_ReturnTrue()
    {
      
    }
}
