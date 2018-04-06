using NorwichCQRS.Infrastructure.EventMessaging;
using System.Collections.Generic;

namespace NorwichCQRS.Infrastructure
{
    public interface IEventProvider
    {
        void LoadsFromHistory(IEnumerable<IEvent> history);
        IEnumerable<IEvent> GetUncommittedChanges();

    }
}
