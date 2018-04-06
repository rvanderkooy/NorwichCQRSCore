namespace NorwichCQRS.Infrastructure.EventMessaging
{
    public interface IHandle<TEvent> where TEvent : IEvent
    {
        void Handle(TEvent e);
    }
}
