namespace QualificationsAPI.Identity
{
    public interface ITokenGenerator
    {
        string GenerateToken(string username);
    }
}
