using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Dao.Interfaces;

namespace ToDo.Dao.Implementation_interfaces
{
    internal class TaskFile : ITaskDao
    {
        public void CreateTask(Task task)
        {
            throw new NotImplementedException();
        }

        public Task ReadTask(string description)
        {
            throw new NotImplementedException();
        }

        public void UpdateStatusTask(Task task)
        {
            throw new NotImplementedException();
        }

        public void DeleteTask(Task task)
        {
            throw new NotImplementedException();
        }
    }
}
