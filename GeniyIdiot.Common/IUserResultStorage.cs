namespace GeniyIdiot.Common
{
    public interface IUserResultStorage
    {
        void SaveResultTesting(User user);
        List<User> GetUserResults();
    }
}