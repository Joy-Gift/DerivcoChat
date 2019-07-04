namespace ChatAppWinterSchool
{
    public interface IChatSystemStore
    {
        bool ValidateUser(LoginCredentials credentials);
    }

}