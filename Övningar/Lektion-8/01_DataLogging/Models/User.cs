

using _01_DataLogging.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace _01_DataLogging.Models;

public class User : IUser
{
    public string Id { get; set; } = null!;
    public string FirstName { get; set; } = null!;  
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;

    public byte[] Password { get; private set; } = null!;

    public void GenerateSecurePassword(string password)
    {
        using var hmac = new HMACSHA512();
        Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));    
    }
}
