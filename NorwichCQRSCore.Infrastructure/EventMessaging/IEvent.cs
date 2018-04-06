using System;

namespace NorwichCQRS.Infrastructure.EventMessaging
{
    public interface IEvent
    {
        DateTime DateTime { get; }
    }
}
