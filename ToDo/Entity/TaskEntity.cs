using System;

namespace ToDo.Entity
{
    internal class TaskEntity
    {
        public long Id { get; set; }         
        public long UserId { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeStop { get; set; }

        public TaskEntity()
        {

        }

        public TaskEntity(long id, long userId, string status, string name, string description, DateTime timeStart, DateTime timeStop)
        {
            Id = id;
            UserId = userId;
            Status = status;
            Name = name;
            Description = description;
            TimeStart = timeStart;
            TimeStop = timeStop;
        }
    }
}
