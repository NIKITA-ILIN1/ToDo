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
        List <TaskEntity> ReadTask(TaskEntity task);
        void UpdateStatusTask(TaskEntity task);
        void DeleteTask(TaskEntity task);
    }
}
