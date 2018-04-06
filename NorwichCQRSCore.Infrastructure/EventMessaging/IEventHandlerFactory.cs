using System.Collections.Generic;

namespace NorwichCQRS.Infrastructure.EventMessaging
{
    public interface IEventHandlerFactory
    {
        IEnumerable<IEventHandler<TEvent>> GetHandlers<TEvent>() where TEvent : IEvent;
        void RegisterHandlerType<TEvent, TEventHandler>()
            where TEvent : IEvent
            where TEventHandler : IEventHandler<TEvent>;
    }
}
