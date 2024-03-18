using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Dao.Interfaces
{
    internal interface ITaskDao
    {
        void CreateTask(Task task);
        Task ReadTask(string description);
        void UpdateStatusTask(Task task);
        void DeleteTask(Task task);
    }
}
