using ToDo.Entity;

namespace ToDo.Dao.Interfaces
{
    internal interface IAuthorizationAndLogOutDao
    {
        User Authorization(User user);
        void LogOut();
    }
}
