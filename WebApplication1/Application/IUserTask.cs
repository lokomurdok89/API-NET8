namespace WebApplication1.Application
{
    public interface IUserTask
    {
        List<User> Get();
        User Get(Guid idUs);
        User AddUser(User us);
    }
}
