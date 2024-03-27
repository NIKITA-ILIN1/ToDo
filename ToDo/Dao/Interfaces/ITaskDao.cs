using System.Collections.Generic;
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
