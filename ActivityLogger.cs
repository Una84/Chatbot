using System;
using System.Collections.Generic;
using System.Linq;

namespace CybersecurityAwarenessBot
{
    public class ActivityLogger
    {
        private List<ActivityLog> logs = new List<ActivityLog>();

        public void Add(string action)
        {
            logs.Add(new ActivityLog
            {
                TimeStamp = DateTime.Now,
                Action = action
            });
        }

        public List<ActivityLog> GetRecentLogs()
        {
            return logs.TakeLast(10).ToList();
        }
    }
}
