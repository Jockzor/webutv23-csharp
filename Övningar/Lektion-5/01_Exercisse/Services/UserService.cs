

using _01_Exercisse.Interfaces;
using _01_Exercisse.Models;
using System.Linq.Expressions;

namespace _01_Exercisse.Services;

internal class UserService : IUserService
{
    private List<User> _listOfUsers = new List<User>();
    public void CreateUser(UserCreateRequest userCreateRequest)
    {
        _listOfUsers.Add(new User
        {
            Id = Guid.NewGuid(),
            FirstName = userCreateRequest.FirstName,
            LastName = userCreateRequest.LastName,  
            Email = userCreateRequest.Email,    
        });

        // Lösenordet får vi hantera separat, av säkerhetsskäl
    }

    public IEnumerable<User> GetAllUsers()
    {
        return _listOfUsers;
    }

    //public User GetUser(Expression<Func<User, bool>> expression)
    //{
    //    throw new NotImplementedException();
    //}

    public User GetUser(Func<User, bool> expression )
    {
        
        var user = _listOfUsers.FirstOrDefault(expression, null!);
        
            return user;

        
    }
}
