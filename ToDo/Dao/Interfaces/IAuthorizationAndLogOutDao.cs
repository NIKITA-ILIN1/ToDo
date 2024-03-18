using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Entity;

namespace ToDo.Dao.Interfaces
{
    internal interface IAuthorizationAndLogOutDao
    {
        void Authorization(User user);
        void LogOut();
    }
}
