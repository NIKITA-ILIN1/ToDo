using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Entity
{
    internal class TaskEntity
    {
        public long Id { get; set; }         
        public long UserId { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeStop { get; set; }

        public TaskEntity()
        {

        }

        public TaskEntity(long id, long userId, string description, string status, DateTime timeStart, DateTime timeStop)
        {
            Id = id;
            UserId = userId;
            Description = description;
            Status = status;
            TimeStart = timeStart;
            TimeStop = timeStop;
        }
    }
}
