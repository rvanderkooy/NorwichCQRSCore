﻿namespace NorwichCQRS.Infrastructure.EventMessaging
{
    public interface IEventHandler<TEvent> where TEvent : IEvent
    {
        void Handle(TEvent @event);
    }
}
