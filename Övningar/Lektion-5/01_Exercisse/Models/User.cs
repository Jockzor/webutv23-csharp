
namespace _01_Exercisse.Models;

internal class User
{

    public User()
    {
        
    }
    public Guid Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;   
    public string Email { get; set; } = null!;

    
}
