using Employee.SharedKernel.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Employee.Core.Services
{
    public class Notification : INotification
    {
        public HashSet<string> Notifications { get; }

        public Notification()
        {
            Notifications = new HashSet<string>();
        }

        public void AddNotification(string message)
        {
            Notifications.Add(message);
        }

        public bool HasNotification() => Notifications.Any();
    }
}
