using NorwichCQRS.Infrastructure;
using System;

namespace NorwichCQRS.Core
{
    public class AggregateEvent:IAggregateEvent
    {
        public int AggregateEventID { get; set; }
        public Guid AggregateEventGuid { get; set; }
        public Guid AggregateGuid { get; set; }
        public string EventType { get; set; }
        public string EventValue { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
