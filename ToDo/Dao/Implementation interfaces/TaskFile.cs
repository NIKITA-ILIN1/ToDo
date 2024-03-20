using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Dao.Interfaces;
using ToDo.Entity;

namespace ToDo.Dao.Implementation_interfaces
{
    internal class TaskFile : ITaskDao
    {
        public void CreateTask(TaskEntity task)
        {
            throw new NotImplementedException();
        }

        public TaskEntity ReadTask(string description)
        {
            throw new NotImplementedException();
        }

        public void UpdateStatusTask(TaskEntity task)
        {
            throw new NotImplementedException();
        }

        public void DeleteTask(TaskEntity task)
        {
            throw new NotImplementedException();
        }
    }
}
