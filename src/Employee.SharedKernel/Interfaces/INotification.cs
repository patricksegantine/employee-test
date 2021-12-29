using System.Collections.Generic;

namespace Employee.SharedKernel.Interfaces
{
    public interface INotification
    {
        HashSet<string> Notifications { get; }
        void AddNotification(string message);
        bool HasNotification();
    }
}
