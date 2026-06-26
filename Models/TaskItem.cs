using System;

namespace CybersecurityAwarenessBot
{
    public class TaskItem
    {
        public int TaskID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime ReminderDate { get; set; }

        public bool Completed { get; set; }
    }
}
