namespace NorwichCQRS.Infrastructure.EventMessaging
{
    public interface IEventBus
    {
        void Publish<TEvent>(TEvent @event) where TEvent : IEvent;
    }
}
