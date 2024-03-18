using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
