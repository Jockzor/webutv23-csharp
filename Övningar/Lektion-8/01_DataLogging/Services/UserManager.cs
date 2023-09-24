

using _01_DataLogging.Interfaces;

namespace _01_DataLogging.Services;

public class UserManager : IUserManager
{
    private readonly IDataLogger _logger;

    public UserManager(IDataLogger logger)
    {
        _logger = logger;
    }

    public IUser CreateUser(IUser user, string password)
    {
        try
        {
            user.Id = Guid.NewGuid().ToString();
            user.GenerateSecurePassword(password);
        }
        catch (Exception ex)
        {
            _logger.Log(ex.Message);
        }
        return null!;
    }

    public IUser GetUser(Func<IUser, bool> expression)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IUser> GetUsers()
    {
        throw new NotImplementedException();
    }
}
