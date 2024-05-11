namespace AuthServer.Core
{
    public class IUserService
    {
        Task<User> GetUserAsync(string username);
        Task<bool> CreateUserAsync(User user);
    }
}
