using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Entity;

namespace ToDo.Dao.Interfaces
{
    internal interface ITaskDao
    {
        void CreateTask(TaskEntity task);
        TaskEntity ReadTask(string description);
        void UpdateStatusTask(TaskEntity task);
        void DeleteTask(TaskEntity task);
    }
}
