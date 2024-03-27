using ToDo.Entity;

namespace ToDo.Dao.Interfaces
{
    internal interface IUserDao
    {
        void CreateUser(User user);
        User ReadUser(string login, string password);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}
