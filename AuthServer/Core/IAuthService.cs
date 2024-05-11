namespace AuthServer.Core
{
    public class IAuthService
    {
        Task<string> GenerateJwtTokenAsync(User user);
    }
}
