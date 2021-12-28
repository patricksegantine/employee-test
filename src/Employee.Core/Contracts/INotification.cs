using System.Collections.Generic;

namespace Employee.Core.Contracts
{
    public interface INotification
    {
        HashSet<string> Notifications { get; }
        void AddNotification(string message);
        bool HasNotification();
    }
}
