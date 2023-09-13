

using _01_Exercisse.Models;
using System.Linq.Expressions;

namespace _01_Exercisse.Interfaces;

internal interface IUserService
{
    public void CreateUser(UserCreateRequest userCreateRequest);

    public User GetUser(Func<User, bool> expression);

   // public User GetUser(Expression<Func<User, bool>> expression);

    public IEnumerable<User> GetAllUsers();
    
}
