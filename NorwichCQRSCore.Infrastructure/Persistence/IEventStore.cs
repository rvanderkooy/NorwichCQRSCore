using System;
using System.Collections.Generic;

namespace NorwichCQRS.Infrastructure.Persistence
{
    public interface IEventStore
    {
        IEnumerable<IAggregateEvent> LoadAggregate(Guid aggregateGuid);
        void SaveChanges(Type aggregateType, IEnumerable<IAggregateEvent> uncommittedEvents);
    }
}
